using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipedrive_to_4straction
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Consume API from yaml description and generate client
             * -> separate command line switch?
             * -> do we really need swagger?
             * → only couple entities. Or then generate data beforehand (no update)
             * 
             * Read companies
             * -> read companies with access to
             * 
             * Read pipedrive settings
             * -> read settings
             * 
             * Iterate pipelines and stages
             * -> Write data to 4straction
             * 
             * Settings:
             * 4Straction API credentials
             * 
             * get only partial classes
             * - UserCompanyAccess -> loadMyAccess()
             * - iterate each company
             * - get settings
             * - read pipedrive
             * - push to 4straction
             * 
             * Settings (app.config)
             * 4straction credentials
             */


        }
    }
}
