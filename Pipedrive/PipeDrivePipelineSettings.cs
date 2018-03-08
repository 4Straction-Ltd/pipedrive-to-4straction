using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipedrive_to_4straction.Pipedrive
{
    public class PipeDrivePipelineSettings
    {
        private int m_pipelineID;
        private String m_Name;
        private IO.Swagger.Model.CorporateStructureLink m_link;
        private List<PipeDriveStageImportSettings> m_stages;

        public int PipelineID
        {
            get { return m_pipelineID; }
            set { m_pipelineID = value; }
        }

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public CorporateStructureLink Link
        {
            get { return m_link; }
            set { m_link = value; }
        }

        public List<PipeDriveStageImportSettings> Stages
        {
            get { return m_stages; }
            set { m_stages = value; }
        }
    }
}
