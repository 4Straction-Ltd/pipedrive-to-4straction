using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO.Swagger.Model;

namespace pipedrive_to_4straction.Pipedrive
{
    public class PipeDriveImportSettings
    {
        private String m_rootDomain;
        private String m_ApiKey;
        private List<PipeDrivePipelineSettings> m_pipelines;

        public string RootDomain
        {
            get { return m_rootDomain; }
            set { m_rootDomain = value; }
        }

        public string ApiKey
        {
            get { return m_ApiKey; }
            set { m_ApiKey = value; }
        }

        public List<PipeDrivePipelineSettings> Pipelines
        {
            get { return m_pipelines; }
            set { m_pipelines = value; }
        }
    }
}
