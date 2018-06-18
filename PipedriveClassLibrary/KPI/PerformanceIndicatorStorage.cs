using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipedriveClassLibrary.KPI
{
    public class PerformanceIndicatorStorage
    {
        private Dictionary<PerformanceIndicatorMonthLink, double> m_monthlyValues;
        private Dictionary<PerformanceIndicatorWeekDataLink, double> m_weeklyValues;
        private DateTime m_startDate;

        public DateTime StartDate
        {
            get { return m_startDate; }
            set { m_startDate = value; }
        }

        public PerformanceIndicatorStorage()
        {
            m_monthlyValues = new Dictionary<PerformanceIndicatorMonthLink, double>();
            m_weeklyValues = new Dictionary<PerformanceIndicatorWeekDataLink, double>();
            m_startDate = DateTime.MinValue;
        }


        public void addWeekValue(int year, int weekNumber, IO.Swagger.Model.CorporateStructureLink link, int indicatorId, double actual)
        {
            PerformanceIndicatorWeekDataLink dataLink = new PerformanceIndicatorWeekDataLink();
            dataLink.Year = year;
            dataLink.WeekNumber = weekNumber;
            dataLink.Link = new IO.Swagger.Model.CorporateStructureLink(link.ProductID, link.GeoAreaID, link.CustomerID, link.CompetitorID, link.SupplierID, link.PartnerID, link.OtherPlayerID, link.CompanyLegalEntityID, link.CompanyFunctionID);
            dataLink.IndicatorId = indicatorId;

            if (m_weeklyValues.ContainsKey(dataLink))
            {
                m_weeklyValues[dataLink] += actual;
            }
            else
            {
                m_weeklyValues.Add(dataLink, actual);
            }
        }

        public void addWeeklyAverageValue(int year, int weekNumber, IO.Swagger.Model.CorporateStructureLink link, int indicatorId, double actual, int count)
        {
            addWeekValue(year, weekNumber, link, indicatorId, actual);
            addWeekValue(year, weekNumber, link, -indicatorId, count);
        }

        public void addMonthValue(int year, int month, IO.Swagger.Model.CorporateStructureLink link, int indicatorId, double actual)
        {
            PerformanceIndicatorMonthLink dataLink = new PerformanceIndicatorMonthLink();
            dataLink.Year = year;
            dataLink.Month = month;
            dataLink.Link = new IO.Swagger.Model.CorporateStructureLink(link.ProductID, link.GeoAreaID, link.CustomerID, link.CompetitorID, link.SupplierID, link.PartnerID, link.OtherPlayerID, link.CompanyLegalEntityID, link.CompanyFunctionID);
            dataLink.IndicatorId = indicatorId;

            if (m_monthlyValues.ContainsKey(dataLink))
            {
                m_monthlyValues[dataLink] += actual;
            }
            else
            {
                m_monthlyValues.Add(dataLink, actual);
            }
        }

        private void calculateMonthlyLevelRows()
        {
            /*
             * Iterate all indicators and every used corporatefilter value
             * and generate "sum" row for this filter
             */

            int minYear = m_monthlyValues.Keys.Min(x => x.Year);
            int maxYear = m_monthlyValues.Keys.Max(x => x.Year);

            List<int> distinctIndicators = m_monthlyValues.Keys.Select(x => x.IndicatorId).Distinct().ToList();
            foreach (int indicatorId in distinctIndicators)
            {
                for (int selYear = minYear; selYear <= maxYear; selYear++)
                {
                    for (int selMonth = 1; selMonth <= 12; selMonth++)
                    {
                        if (m_monthlyValues.Keys.Where(x => x.Year == selYear && x.Month == selMonth && x.IndicatorId == indicatorId).Count() == 0)
                        {
                            continue;
                        }

                        /*
                         * If we have some items stored where filters are set (e.g. productid is something)
                         * then aggregate those items to top level too. We assume they are not there yet
                         */

                        PerformanceIndicatorMonthLink topLevelLink = new PerformanceIndicatorMonthLink();
                        topLevelLink.Year = selYear;
                        topLevelLink.Month = selMonth;
                        topLevelLink.IndicatorId = indicatorId;
                        topLevelLink.Link = new IO.Swagger.Model.CorporateStructureLink(null, null, null, null, null, null, null, null, null);

                        double totalValue = 0;
                        foreach (PerformanceIndicatorMonthLink entryWithSomething in m_monthlyValues.Keys.Where(x => x.Year == selYear && x.Month == selMonth && x.IndicatorId == indicatorId &&
                            (x.Link.CompanyFunctionID != 0 || x.Link.CompanyLegalEntityID != 0 || x.Link.CompetitorID != 0 || x.Link.CustomerID != 0 || x.Link.GeoAreaID != 0 || x.Link.OtherPlayerID != 0 || x.Link.PartnerID != 0 || x.Link.ProductID != 0 || x.Link.SupplierID != 0)
                        ))
                        {
                            totalValue += m_monthlyValues[entryWithSomething];
                        }

                        if (m_monthlyValues.ContainsKey(topLevelLink)) {
                            m_monthlyValues[topLevelLink] += totalValue;
                        }
                        else {
                            m_monthlyValues.Add(topLevelLink, totalValue);
                        }

                        List<PerformanceIndicatorMonthLink> thisPeriodValues = m_monthlyValues.Keys.Where(x => x.Year == selYear && x.Month == selMonth && x.IndicatorId == indicatorId).ToList();
                        foreach (PerformanceIndicatorMonthLink entryWithSomething in thisPeriodValues)
                        {
                            if (entryWithSomething.Link.GeoAreaID != null)
                            {
                                PerformanceIndicatorMonthLink entryWithoutOtherLinks = new PerformanceIndicatorMonthLink();
                                entryWithoutOtherLinks.Year = selYear;
                                entryWithoutOtherLinks.Month = selMonth;
                                entryWithoutOtherLinks.IndicatorId = indicatorId;
                                entryWithoutOtherLinks.Link = new IO.Swagger.Model.CorporateStructureLink(null, entryWithSomething.Link.GeoAreaID, null, null, null, null, null, null, null);

                                if (!m_monthlyValues.ContainsKey(entryWithoutOtherLinks))
                                {
                                    totalValue = 0;
                                    foreach (PerformanceIndicatorMonthLink entryWithGeoAreaSet in m_monthlyValues.Keys.Where(x => x.Year == selYear && x.Month == selMonth && x.IndicatorId == indicatorId && x.Link.GeoAreaID == entryWithSomething.Link.GeoAreaID))
                                    {
                                        totalValue += m_monthlyValues[entryWithGeoAreaSet];
                                    }

                                    m_monthlyValues.Add(entryWithoutOtherLinks, totalValue);
                                }
                            }

                            if (entryWithSomething.Link.PartnerID != null)
                            {
                                PerformanceIndicatorMonthLink entryWithoutOtherLinks = new PerformanceIndicatorMonthLink();
                                entryWithoutOtherLinks.Year = selYear;
                                entryWithoutOtherLinks.Month = selMonth;
                                entryWithoutOtherLinks.IndicatorId = indicatorId;
                                entryWithoutOtherLinks.Link = new IO.Swagger.Model.CorporateStructureLink(null, null, null, null, null, entryWithSomething.Link.PartnerID, null, null, null);

                                if (!m_monthlyValues.ContainsKey(entryWithoutOtherLinks))
                                {
                                    totalValue = 0;
                                    foreach (PerformanceIndicatorMonthLink entryWithPartnerSet in m_monthlyValues.Keys.Where(x => x.Year == selYear && x.Month == selMonth && x.IndicatorId == indicatorId && x.Link.PartnerID == entryWithSomething.Link.PartnerID))
                                    {
                                        totalValue += m_monthlyValues[entryWithPartnerSet];
                                    }

                                    m_monthlyValues.Add(entryWithoutOtherLinks, totalValue);
                                }
                            }

                            if (entryWithSomething.Link.ProductID != null)
                            {
                                PerformanceIndicatorMonthLink entryWithoutOtherLinks = new PerformanceIndicatorMonthLink();
                                entryWithoutOtherLinks.Year = selYear;
                                entryWithoutOtherLinks.Month = selMonth;
                                entryWithoutOtherLinks.IndicatorId = indicatorId;
                                entryWithoutOtherLinks.Link = new IO.Swagger.Model.CorporateStructureLink(entryWithSomething.Link.ProductID, null, null, null, null, null, null, null, null);

                                if (!m_monthlyValues.ContainsKey(entryWithoutOtherLinks))
                                {
                                    totalValue = 0;
                                    foreach (PerformanceIndicatorMonthLink entryWithPartnerSet in m_monthlyValues.Keys.Where(x => x.Year == selYear && x.Month == selMonth && x.IndicatorId == indicatorId && x.Link.ProductID == entryWithSomething.Link.ProductID))
                                    {
                                        totalValue += m_monthlyValues[entryWithPartnerSet];
                                    }

                                    m_monthlyValues.Add(entryWithoutOtherLinks, totalValue);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void calculateWeeklyLevelRows()
        {
            /*
             * Iterate all indicators and every used corporatefilter value
             * and generate "sum" row for this filter
             */

            int minYear = m_weeklyValues.Keys.Min(x => x.Year);
            int maxYear = m_weeklyValues.Keys.Max(x => x.Year);

            List<int> distinctIndicators = m_weeklyValues.Keys.Select(x => x.IndicatorId).Distinct().ToList();
            foreach (int indicatorId in distinctIndicators)
            {
                for (int selYear = minYear; selYear <= maxYear; selYear++)
                {
                    for (int selWeek = 1; selWeek <= 52; selWeek++)
                    {
                        if (m_weeklyValues.Keys.Where(x => x.Year == selYear && x.WeekNumber == selWeek && x.IndicatorId == indicatorId).Count() == 0)
                        {
                            continue;
                        }

                        PerformanceIndicatorWeekDataLink topLevelLink = new PerformanceIndicatorWeekDataLink();
                        topLevelLink.Year = selYear;
                        topLevelLink.WeekNumber = selWeek;
                        topLevelLink.IndicatorId = indicatorId;
                        topLevelLink.Link = new IO.Swagger.Model.CorporateStructureLink(null, null, null, null, null, null, null, null, null);

                        double totalValue = 0;
                        foreach (PerformanceIndicatorWeekDataLink entryWithSomething in m_weeklyValues.Keys.Where(x => x.Year == selYear && x.WeekNumber == selWeek && x.IndicatorId == indicatorId &&
                                    (x.Link.CompanyFunctionID != 0 || x.Link.CompanyLegalEntityID != 0 || x.Link.CompetitorID != 0 || x.Link.CustomerID != 0 || x.Link.GeoAreaID != 0 || x.Link.OtherPlayerID != 0 || x.Link.PartnerID != 0 || x.Link.ProductID != 0 || x.Link.SupplierID != 0)
                        ))
                        {
                            totalValue += m_weeklyValues[entryWithSomething];
                        }

                        if (m_weeklyValues.ContainsKey(topLevelLink)) {
                            m_weeklyValues[topLevelLink] += totalValue;
                        }
                        else {
                            m_weeklyValues.Add(topLevelLink, totalValue);
                        }

                        List<PerformanceIndicatorWeekDataLink> thisPeriodValues = m_weeklyValues.Keys.Where(x => x.Year == selYear && x.WeekNumber == selWeek && x.IndicatorId == indicatorId).ToList();
                        foreach (PerformanceIndicatorWeekDataLink entryWithSomething in thisPeriodValues)
                        {
                            if (entryWithSomething.Link.GeoAreaID != null)
                            {
                                PerformanceIndicatorWeekDataLink entryWithoutOtherLinks = new PerformanceIndicatorWeekDataLink();
                                entryWithoutOtherLinks.Year = selYear;
                                entryWithoutOtherLinks.WeekNumber = selWeek;
                                entryWithoutOtherLinks.IndicatorId = indicatorId;
                                entryWithoutOtherLinks.Link = new IO.Swagger.Model.CorporateStructureLink(null, entryWithSomething.Link.GeoAreaID, null, null, null, null, null, null, null);

                                if (!m_weeklyValues.ContainsKey(entryWithoutOtherLinks))
                                {
                                    totalValue = 0;
                                    foreach (PerformanceIndicatorWeekDataLink entryWithGeoAreaSet in m_weeklyValues.Keys.Where(x => x.Year == selYear && x.WeekNumber == selWeek && x.IndicatorId == indicatorId && x.Link.GeoAreaID == entryWithSomething.Link.GeoAreaID))
                                    {
                                        totalValue += m_weeklyValues[entryWithGeoAreaSet];
                                    }

                                    m_weeklyValues.Add(entryWithoutOtherLinks, totalValue);
                                }
                            }

                            if (entryWithSomething.Link.PartnerID != null)
                            {
                                PerformanceIndicatorWeekDataLink entryWithoutOtherLinks = new PerformanceIndicatorWeekDataLink();
                                entryWithoutOtherLinks.Year = selYear;
                                entryWithoutOtherLinks.WeekNumber = selWeek;
                                entryWithoutOtherLinks.IndicatorId = indicatorId;
                                entryWithoutOtherLinks.Link = new IO.Swagger.Model.CorporateStructureLink(null, null, null, null, null, entryWithSomething.Link.PartnerID, null, null, null);

                                if (!m_weeklyValues.ContainsKey(entryWithoutOtherLinks))
                                {
                                    totalValue = 0;
                                    foreach (PerformanceIndicatorWeekDataLink entryWithPartnerSet in m_weeklyValues.Keys.Where(x => x.Year == selYear && x.WeekNumber == selWeek && x.IndicatorId == indicatorId && x.Link.PartnerID == entryWithSomething.Link.PartnerID))
                                    {
                                        totalValue += m_weeklyValues[entryWithPartnerSet];
                                    }

                                    m_weeklyValues.Add(entryWithoutOtherLinks, totalValue);
                                }
                            }
                        }
                    }
                }
            }

        }

        public List<PerformanceIndicatorMonthData> getMonthlyRows()
        {
            calculateMonthlyLevelRows();

            List<PerformanceIndicatorMonthData> rows = new List<PerformanceIndicatorMonthData>();
            foreach (PerformanceIndicatorMonthLink value in m_monthlyValues.Keys) {
                bool oldPeriod = value.Year < m_startDate.Year || (value.Year == m_startDate.Year && value.Month < m_startDate.Month);
                if (oldPeriod)
                    continue;

                rows.Add(new PerformanceIndicatorMonthData(value, m_monthlyValues[value]));
            }

            return rows;
        }

        public List<PerformanceIndicatorWeekData> getWeeklyRows()
        {
            calculateWeeklyLevelRows();

            List<PerformanceIndicatorWeekData> rows = new List<PerformanceIndicatorWeekData>();
            foreach (PerformanceIndicatorWeekDataLink value in m_weeklyValues.Keys)
            {
                bool oldPeriod = value.Year < m_startDate.Year || (value.Year == m_startDate.Year && value.WeekNumber < GetWeekNumberFromDate(m_startDate));
                if (oldPeriod)
                    continue;

                rows.Add(new PerformanceIndicatorWeekData(value, m_weeklyValues[value]));
            }

            return rows;
        }

        private int GetWeekNumberFromDate(DateTime selectedDate)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(selectedDate, CalendarWeekRule.FirstFourDayWeek, System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek);
        }
    }
}
