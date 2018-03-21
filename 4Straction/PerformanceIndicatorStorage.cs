using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipedrive_to_4straction._4Straction
{
    public class PerformanceIndicatorStorage
    {
        private Dictionary<PerformanceIndicatorMonthLink, double> m_values;

        public PerformanceIndicatorStorage()
        {
            m_values = new Dictionary<PerformanceIndicatorMonthLink, double>();
        }

        public void addMonthValue(int year, int month, IO.Swagger.Model.CorporateStructureLink link, int indicatorId, double actual)
        {
            PerformanceIndicatorMonthLink dataLink = new PerformanceIndicatorMonthLink();
            dataLink.Year = year;
            dataLink.Month = month;
            dataLink.Link = new IO.Swagger.Model.CorporateStructureLink(link.ProductID, link.GeoAreaID, link.CustomerID, link.CompetitorID, link.SupplierID, link.PartnerID, link.OtherPlayerID, link.CompanyLegalEntityID, link.CompanyFunctionID);
            dataLink.IndicatorId = indicatorId;

            if (m_values.ContainsKey(dataLink)) {
                m_values[dataLink] += actual;
            }
            else {
                m_values.Add(dataLink, actual);
            }
        }

        public List<PerformanceIndicatorMonthData> getRows()
        {
            List<PerformanceIndicatorMonthData> rows = new List<PerformanceIndicatorMonthData>();
            foreach (PerformanceIndicatorMonthLink value in m_values.Keys)
            {
                rows.Add(new PerformanceIndicatorMonthData(value, m_values[value]));
            }

            return rows;
        }

    }
}
