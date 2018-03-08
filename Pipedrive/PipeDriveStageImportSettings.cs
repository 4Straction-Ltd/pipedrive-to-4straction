using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipedrive_to_4straction.Pipedrive
{
    public class PipeDriveStageImportSettings
    {
        private String m_Name;
        private int m_stageId;
        private int m_indicatorCountId;
        private int m_indicatorSumId;
        private int m_indicatorCumulativeSumId;
        private bool m_includeDescription;

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public int StageId
        {
            get { return m_stageId; }
            set { m_stageId = value; }
        }

        public int IndicatorCountId
        {
            get { return m_indicatorCountId; }
            set { m_indicatorCountId = value; }
        }

        public int IndicatorSumId
        {
            get { return m_indicatorSumId; }
            set { m_indicatorSumId = value; }
        }

        public int IndicatorCumulativeSumId
        {
            get { return m_indicatorCumulativeSumId; }
            set { m_indicatorCumulativeSumId = value; }
        }

        public bool IncludeDescription
        {
            get { return m_includeDescription; }
            set { m_includeDescription = value; }
        }
    }
}
