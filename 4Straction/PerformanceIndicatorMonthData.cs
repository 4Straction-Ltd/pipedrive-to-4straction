using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipedrive_to_4straction._4Straction
{
    public class PerformanceIndicatorMonthData : PerformanceIndicatorMonthLink
    {
        private double m_actual;

        public PerformanceIndicatorMonthData(PerformanceIndicatorMonthLink link, double actual)
        {
            base.Link = link.Link;
            base.IndicatorId  = link.IndicatorId;
            base.Month = link.Month;
            base.Year = link.Year;
            m_actual = actual;
        }

        public double Actual
        {
            get { return m_actual; }
            set { m_actual = value; }
        }
    }
}
