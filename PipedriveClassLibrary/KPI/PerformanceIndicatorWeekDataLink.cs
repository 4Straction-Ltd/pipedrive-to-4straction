﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipedriveClassLibrary.KPI
{
    public class PerformanceIndicatorWeekDataLink
    {
        private int m_indicatorId;
        private int m_year;
        private int m_weekNumber;
        private IO.Swagger.Model.CorporateStructureLink m_link;

        public int IndicatorId
        {
            get { return m_indicatorId; }
            set { m_indicatorId = value; }
        }

        public int Year
        {
            get { return m_year; }
            set { m_year = value; }
        }

        public int WeekNumber
        {
            get { return m_weekNumber; }
            set { m_weekNumber = value; }
        }

        public IO.Swagger.Model.CorporateStructureLink Link
        {
            get { return m_link; }
            set { m_link = value; }
        }

        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PerformanceIndicatorWeekDataLink);
        }

        public bool Equals(PerformanceIndicatorWeekDataLink other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
            (
                this.IndicatorId.Equals(other.IndicatorId) &&
                this.Year.Equals(other.Year) &&
                this.WeekNumber.Equals(other.WeekNumber)
            ) &&
            (
                this.Link == other.Link || this.Link != null && this.Link.Equals(other.Link)
            );
        }

        //Credit to Jon Skeet from https://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode
        //  for inspiration for this method
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = (int)2166136261;
                // Suitable nullity checks etc, of course :)
                hash = hash * 16777619 ^ this.m_indicatorId.GetHashCode();
                hash = hash * 16777619 ^ this.m_year.GetHashCode();
                hash = hash * 16777619 ^ this.m_weekNumber.GetHashCode();
                hash = hash * 16777619 ^ this.m_link.GetHashCode();
                return hash;
            }
        }

    }
}
