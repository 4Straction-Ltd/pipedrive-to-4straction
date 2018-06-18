using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IO.Swagger.Model;
using Newtonsoft.Json;

namespace PipedriveClassLibrary.Pipedrive
{
    public class PipedriveClient
    {
        private KPI.PerformanceIndicatorStorage m_storage;
        private List<PartnerReport> m_partners;
        private Func<String, int> m_userCreation;
        private Dictionary<int, String> m_users = new Dictionary<int, String>();
        private static int YEARS_SAFE_TO_GET_DEALS_FROM = 2;

        public PipedriveClient()
        {
            m_storage = new KPI.PerformanceIndicatorStorage();
        }

        public void extractInformation(IntegrationPipedriveSettings settings, List<IntegrationPipedriveSettingsPipeline> pipelines, List<IntegrationPipedriveSettingsPipelineStage> stages, Func<String, int> userCreation)
        {
            m_userCreation = userCreation;
            loadUsers(settings);

            /*
             * Within the class we manage starttime so that we get activities/deals older than 1 year
             * and we only update items that are not older than 10 months
             * 
             * This is due that we don't have a flag in pipedrive API that we could only extract
             * updated information. We might have a deal that is CHANGED now and is 6 months old
             * that we want to keep track of
             */
            if (settings.LastSyncTime.HasValue && settings.LastSyncTime.Value != null) {
                m_storage.StartDate  = settings.LastSyncTime.Value.AddMonths(-10);
            }

            if (settings.ImportOpenDeals.HasValue && (bool)settings.ImportOpenDeals.Value) {
                importOpenedDeals(settings);
            }

            if (pipelines != null && pipelines.Count > 0) {
                importPipelines(settings, pipelines, stages);
            }

            if (settings.ImportActivities.HasValue && (bool)settings.ImportActivities) {
                importActivities(settings);
            }
        }

        public void setUsers(List<PartnerReport> partners)
        {
            m_partners = partners;
        }

        private void loadUsers(IntegrationPipedriveSettings settings)
        {
            PipedriveClassLibrary.util.HTTPRequest http = new util.HTTPRequest();

            if (settings.ImportActivitiesSyncUsers.HasValue && (bool)settings.ImportActivitiesSyncUsers)
            {
                int pagingStart = 0;
                bool moreResults = true;

                do
                {
                    String reply = http.DoGetRequest(settings.RootDomain + "/users?start=" + pagingStart + "&api_token=" + settings.APIKey);
                    dynamic rawResponse = (dynamic)JsonConvert.DeserializeObject(reply);

                    if (rawResponse.data != null)
                    {
                        foreach (dynamic row in rawResponse.data)
                        {
                            int userId = (int)row.id;
                            String name = (String)row.name;

                            m_users.Add(userId, name);
                        }

                        if ((bool)rawResponse.success)
                        {
                            if (rawResponse.additional_data.pagination != null)
                            {
                                if ((bool)rawResponse.additional_data.pagination.more_items_in_collection)
                                {
                                    pagingStart = rawResponse.additional_data.pagination.start + rawResponse.additional_data.pagination.limit;
                                    moreResults = true;
                                }
                                else
                                {
                                    moreResults = false;
                                }
                            }
                            else
                            {
                                moreResults = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                while (moreResults);
            }
        }

        private void importPipelines(IntegrationPipedriveSettings settings, List<IntegrationPipedriveSettingsPipeline> pipelines, List<IntegrationPipedriveSettingsPipelineStage> stages)
        {

            /*
             * Handle pipelines and stages and get counts + sums
             */

            PipedriveClassLibrary.util.HTTPRequest http = new util.HTTPRequest();

            foreach (IntegrationPipedriveSettingsPipeline pipeline in pipelines)
            {
                Console.WriteLine(" Accessing pipeline: " + pipeline.Name);

                foreach (IntegrationPipedriveSettingsPipelineStage stage in stages.Where(x => x.PipeLineID == pipeline.ID))
                {
                    int pagingStart = 0;
                    bool moreResults = true;

                    do
                    {
                        String fullURI = settings.RootDomain + "/deals?start=" + pagingStart + "&stage_id=" + stage.ExternalStageID + "&api_token=" + settings.APIKey;

                        if (settings.LastSyncTime.HasValue && settings.LastSyncTime.Value != null) {
                            /*
                             * Don't use this yet. We would have to reconcile how to manage changes (if some old deal changes)
                             * and mapping things to date periods
                             */
                            fullURI += "&start_date=" + settings.LastSyncTime.Value.AddYears(-YEARS_SAFE_TO_GET_DEALS_FROM).ToString("yyyy-MM-dd");
                        }

                        String reply = http.DoGetRequest(fullURI);
                        dynamic rawResponse = (dynamic)JsonConvert.DeserializeObject(reply);

                        Console.WriteLine("  Accessing stage: " + stage.ExternalStageID);

                        if (rawResponse.data == null)
                            break;

                        foreach (dynamic row in rawResponse.data)
                        {

                            DateTime addTime = DateTime.ParseExact((String)row.add_time, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                            String statusChangeRaw = (String)row.stage_change_time;
                            DateTime lastStatusChangeTime = addTime;

                            // modify link here if you need to add more
                            // detailed filters such as product segments, customer segments..1;
                            CorporateStructureLink corporateLink = pipeline.CorporateStructureLink;

                            if (settings.ImportActivitiesSyncUsers.HasValue && (bool)settings.ImportActivitiesSyncUsers)
                            {
                                int userId = (int)row.creator_user_id.id;
                                String activityUserName = m_users[userId];
                                int partnerId = 0;

                                foreach (PartnerReport partner in m_partners)
                                {
                                    if (partner.Name.ToLower() == activityUserName.ToLower()) {
                                        partnerId = (int)partner.ID;
                                        break;
                                    }
                                }

                                if (partnerId == 0)
                                {
                                    if (m_userCreation == null) {
                                        throw new ApplicationException("Could not find seller/partner and no way to crate it");
                                    }

                                    int newUser = m_userCreation(activityUserName);
                                    m_partners.Add(new PartnerReport() { Name = activityUserName, ID = newUser });
                                }

                                corporateLink.PartnerID = partnerId;
                            }

                            if (!string.IsNullOrEmpty(statusChangeRaw))
                            {
                                lastStatusChangeTime = DateTime.ParseExact(statusChangeRaw, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                            }

                            if (stage.ImportDealCountIndicatorID != null && stage.ImportDealCountIndicatorID != 0)
                            {
                                m_storage.addMonthValue(lastStatusChangeTime.Year, lastStatusChangeTime.Month, corporateLink, (int)stage.ImportDealCountIndicatorID, 1);
                                m_storage.addWeekValue(lastStatusChangeTime.Year, getWeekNumberFromDate(lastStatusChangeTime), corporateLink, (int)stage.ImportDealCountIndicatorID, 1);
                            }

                            if (stage.ImportDealSumIndicatorID != null && stage.ImportDealSumIndicatorID != 0)
                            {
                                m_storage.addMonthValue(lastStatusChangeTime.Year, lastStatusChangeTime.Month, corporateLink, (int)stage.ImportDealSumIndicatorID, (double)row.value);
                                m_storage.addWeekValue(lastStatusChangeTime.Year, getWeekNumberFromDate(lastStatusChangeTime), corporateLink, (int)stage.ImportDealSumIndicatorID, (double)row.value);
                            }

                            if ((bool)pipeline.ImportWinDealCount)
                            {
                                m_storage.addMonthValue(lastStatusChangeTime.Year, lastStatusChangeTime.Month, corporateLink, (int)pipeline.ImportWinDealCountIndicatorID.Value, 1);
                                m_storage.addWeekValue(lastStatusChangeTime.Year, getWeekNumberFromDate(lastStatusChangeTime), corporateLink, (int)pipeline.ImportWinDealCountIndicatorID.Value, 1);
                            }

                            if ((bool)pipeline.ImportWinDealSum)
                            {
                                m_storage.addMonthValue(lastStatusChangeTime.Year, lastStatusChangeTime.Month, corporateLink, (int)pipeline.ImportWinDealCountIndicatorID.Value, (double)row.value);
                                m_storage.addWeekValue(lastStatusChangeTime.Year, getWeekNumberFromDate(lastStatusChangeTime), corporateLink, (int)pipeline.ImportWinDealCountIndicatorID.Value, (double)row.value);
                            }

                            if ((bool)pipeline.ImportLossDealCount)
                            {
                                m_storage.addMonthValue(lastStatusChangeTime.Year, lastStatusChangeTime.Month, corporateLink, (int)pipeline.ImportLossDealCountIndicatorID.Value, 1);
                                m_storage.addWeekValue(lastStatusChangeTime.Year, getWeekNumberFromDate(lastStatusChangeTime), corporateLink, (int)pipeline.ImportLossDealCountIndicatorID.Value, 1);
                            }

                            if ((bool)pipeline.ImportLossDealSum)
                            {
                                m_storage.addMonthValue(lastStatusChangeTime.Year, lastStatusChangeTime.Month, corporateLink, (int)pipeline.ImportLossDealSumIndicatorID.Value, (double)row.value);
                                m_storage.addWeekValue(lastStatusChangeTime.Year, getWeekNumberFromDate(lastStatusChangeTime), corporateLink, (int)pipeline.ImportLossDealSumIndicatorID.Value, (double)row.value);
                            }

                        }

                        if ((bool)rawResponse.success)
                        {
                            if ((bool)rawResponse.additional_data.pagination.more_items_in_collection)
                            {
                                pagingStart = rawResponse.additional_data.pagination.start + rawResponse.additional_data.pagination.limit;
                                moreResults = true;
                            }
                            else
                            {
                                moreResults = false;
                            }
                        }
                    }
                    while (moreResults);
                }
            }
        }

        private void importOpenedDeals(IO.Swagger.Model.IntegrationPipedriveSettings settings)
        {
            PipedriveClassLibrary.util.HTTPRequest http = new util.HTTPRequest();

            int pagingStart = 0;
            bool moreResults = true;

            do
            {

                String fullURI = settings.RootDomain + "/deals?start=" + pagingStart + "&api_token=" + settings.APIKey;
                if (settings.LastSyncTime.HasValue && settings.LastSyncTime.Value != null) {
                    fullURI += "&start_date=" + settings.LastSyncTime.Value.AddYears(-YEARS_SAFE_TO_GET_DEALS_FROM).ToString("yyyy-MM-dd");
                }

                String reply = http.DoGetRequest(fullURI);

                dynamic rawResponse = (dynamic)JsonConvert.DeserializeObject(reply);

                Console.WriteLine("Retrieving deals for opened deals: " + pagingStart);

                foreach (dynamic row in rawResponse.data)
                {
                    int indicatorId = 0;

                    if ((bool)settings.ImportOpenDeals)
                    {
                        indicatorId = settings.ImportOpenDealsIndicatorID.Value;
                        CorporateStructureLink corporateLink = settings.CorporateStructureLink;
                        DateTime time = DateTime.ParseExact((String)row.add_time, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                        m_storage.addMonthValue(time.Year, time.Month, corporateLink, indicatorId, 1);
                        m_storage.addWeekValue(time.Year, getWeekNumberFromDate(time), corporateLink, indicatorId, 1);
                    }

                }

                if ((bool)rawResponse.success)
                {
                    if ((bool)rawResponse.additional_data.pagination.more_items_in_collection)
                    {
                        pagingStart = rawResponse.additional_data.pagination.start + rawResponse.additional_data.pagination.limit;
                        moreResults = true;
                    }
                    else
                    {
                        moreResults = false;
                    }
                }
            }
            while (moreResults);
        }

        public void importActivities(IntegrationPipedriveSettings settings)
        {
            PipedriveClassLibrary.util.HTTPRequest http = new util.HTTPRequest();

            if (settings.ImportActivities.HasValue && (bool)settings.ImportActivities)
            {
                int pagingStart = 0;
                bool moreResults = true;

                do
                {
                    String fullURI = settings.RootDomain + "/activities?user_id=0&start=" + pagingStart + "&done=1&api_token=" + settings.APIKey;
                    if (settings.LastSyncTime.HasValue && settings.LastSyncTime.Value != null) {
                        fullURI += "&start_date=" + settings.LastSyncTime.Value.AddYears(-YEARS_SAFE_TO_GET_DEALS_FROM).ToString("yyyy-MM-dd");
                    }

                    String reply = http.DoGetRequest(fullURI);
                    dynamic rawResponse = (dynamic)JsonConvert.DeserializeObject(reply);

                    Console.WriteLine("Retrieving actitivies start: " + pagingStart);

                    if (rawResponse.data != null)
                    {
                        foreach (dynamic row in rawResponse.data)
                        {
                            String type = (String)row.type;
                            DateTime doneDate = DateTime.ParseExact((String)row.marked_as_done_time, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                            int indicatorId = settings.ImportActivitiesIndicatorID.Value;

                            // modify link here if you need to add more
                            // detailed filters such as product segments, customer segments..
                            CorporateStructureLink corporateLink = new CorporateStructureLink();

                            if (settings.ImportActivitiesSyncUsers.HasValue && (bool)settings.ImportActivitiesSyncUsers)
                            {
                                int userId = (int)row.user_id;
                                String activityUserName = m_users[userId];
                                int partnerId = 0;

                                foreach (PartnerReport partner in m_partners)
                                {
                                    if (partner.Name.ToLower() == activityUserName.ToLower())
                                    {
                                        partnerId = (int)partner.ID;
                                        break;
                                    }
                                }

                                if (partnerId == 0)
                                {
                                    if (m_userCreation == null) {
                                        throw new ApplicationException("Could not find seller/partner and no way to crate it");
                                    }

                                    int newUser = m_userCreation(activityUserName);
                                    m_partners.Add(new PartnerReport() { Name = activityUserName, ID = newUser });
                                }

                                corporateLink.PartnerID = partnerId;
                            }

                            m_storage.addMonthValue(doneDate.Year, doneDate.Month, corporateLink, indicatorId, 1);
                            m_storage.addWeekValue(doneDate.Year, getWeekNumberFromDate(doneDate), corporateLink, indicatorId, 1);
                        }

                        if ((bool)rawResponse.success)
                        {
                            if ((bool)rawResponse.additional_data.pagination.more_items_in_collection)
                            {
                                pagingStart = rawResponse.additional_data.pagination.start + rawResponse.additional_data.pagination.limit;
                                moreResults = true;
                            }
                            else
                            {
                                moreResults = false;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                while (moreResults);
            }


        }

        public List<KPI.PerformanceIndicatorMonthData> getMonthlyRows()
        {
            return m_storage.getMonthlyRows();
        }

        public List<KPI.PerformanceIndicatorWeekData> getWeeklyRows()
        {
            return m_storage.getWeeklyRows();
        }

        private static int getWeekNumberFromDate(DateTime selDate)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(selDate, CalendarWeekRule.FirstFourDayWeek, System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek);
        }

    }
}
