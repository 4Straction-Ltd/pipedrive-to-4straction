using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;
using Newtonsoft.Json;
using System.Globalization;

namespace pipedrive_to_4straction
{
    class Program
    {
        static void Main(string[] args)
        {

            Configuration config = new Configuration();
            config.AddDefaultHeader("4S-API-User-ID", "");
            config.AddDefaultHeader("4S-API-User-Password", "");
            config.AddDefaultHeader("4S-API-Partner-Key", "");
            config.AddDefaultHeader("4S-API-CompanyID-Override", "");


            Pipedrive.PipeDriveImportSettings settings = new Pipedrive.PipeDriveImportSettings();
            settings.RootDomain = "https://xxxx.pipedrive.com/v1/";
            settings.ApiKey = "";

            settings.Pipelines = new List<Pipedrive.PipeDrivePipelineSettings>() {
                new Pipedrive.PipeDrivePipelineSettings() {
                    PipelineID = 0,
                    Name = "xx",
                    Link = new CorporateStructureLink(),
                    Stages = new List<Pipedrive.PipeDriveStageImportSettings>() {
                    new Pipedrive.PipeDriveStageImportSettings() {
                        StageId = 0,
                        Name = "",
                        IncludeDescription = false,
                        IndicatorCountId = 0,
                        IndicatorSumId = 0,
                        IndicatorCumulativeSumId = 0
                    }
                    }
                }
            };

            _4Straction.PerformanceIndicatorStorage storage = new _4Straction.PerformanceIndicatorStorage();

            foreach (Pipedrive.PipeDrivePipelineSettings pipeline in settings.Pipelines)
            {
                Console.WriteLine(" Accessing pipeline: " + pipeline.Name);

                foreach (Pipedrive.PipeDriveStageImportSettings stage in pipeline.Stages)
                {
                    int pagingStart = 0;
                    bool moreResults = true;

                    do
                    {
                        util.HTTPRequest http = new util.HTTPRequest();
                        String reply = http.DoGetRequest(settings.RootDomain + "/deals?start=" + pagingStart + "&stage_id=" + stage.StageId + "&api_token=" + settings.ApiKey);
                        dynamic rawResponse = (dynamic)JsonConvert.DeserializeObject(reply);

                        Console.WriteLine("  Accessing stage: " + stage.StageId);

                        foreach (dynamic row in rawResponse.data)
                        {

                            DateTime addTime = DateTime.ParseExact((String)row.add_time, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                            String statusChangeRaw = (String)row.stage_change_time;
                            DateTime lastStatusChangeTime = addTime;

                            // modify link here if you need to add more
                            // detailed filters such as product segments, customer segments..
                            CorporateStructureLink corporateLink = pipeline.Link;

                            if (!string.IsNullOrEmpty(statusChangeRaw))
                            {
                                lastStatusChangeTime = DateTime.ParseExact(statusChangeRaw, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                            }

                            if (stage.IndicatorCountId != 0) {
                                storage.addMonthValue(lastStatusChangeTime.Year, lastStatusChangeTime.Month, corporateLink, stage.IndicatorCountId, 1);
                            }

                            if (stage.IndicatorSumId != 0) {
                                storage.addMonthValue(lastStatusChangeTime.Year, lastStatusChangeTime.Month, corporateLink, stage.IndicatorSumId, (double)row.value);
                            }

                        }

                        if ((bool)rawResponse.success)
                        {
                            if ((bool)rawResponse.additional_data.pagination.more_items_in_collection)
                            {
                                pagingStart = rawResponse.additional_data.pagination.start + rawResponse.additional_data.pagination.limit + 1;
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


            foreach (_4Straction.PerformanceIndicatorMonthData data in storage.getRows())
            {
                Console.WriteLine($"Merging value indicator: {data.IndicatorId} to {data.Year}/{data.Month} with value: {data.Actual}");
                PerformanceIndicatorMonthDataApi months = new PerformanceIndicatorMonthDataApi(config);
                months.PerformanceIndicatorMonthDataMergeTargetValuePut("", data.Link, data.Year, data.Month, data.IndicatorId, data.Actual, 0, 0, 0, null, null);
            }

        }
    }
}
