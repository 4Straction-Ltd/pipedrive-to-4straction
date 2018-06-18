using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipedriveClassLibrary.KPI
{
    public class PerformanceIndicatorWeekData : PerformanceIndicatorWeekDataLink
    {
        private double m_actual;

        public PerformanceIndicatorWeekData(PerformanceIndicatorWeekDataLink link, double actual)
        {
            base.Link = link.Link;
            base.IndicatorId = link.IndicatorId;
            base.WeekNumber = link.WeekNumber;
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
