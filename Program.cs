using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

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

            Configuration config = new Configuration();

            //https://4straction.io/v1/CompanyFunction/loadAll?4S-API-User-ID=risto.matikainen@4straction.com&4S-API-User-Password=Kolmendal&4S-API-Partner-Key=65180b15884bf62abf91e6d586504af7

            /*  */
            config.AddDefaultHeader("4S-API-User-ID", "risto.matikainen@4straction.com");
            config.AddDefaultHeader("4S-API-User-Password", "K0lmendal");
            config.AddDefaultHeader("4S-API-Partner-Key", "65180b15884bf62abf91e6d586504af7");
            config.AddDefaultHeader("4S-API-Organization-Identifier-Override", "2700787-8");

            // should we expose business id to company report?

            UserCompanyAccessApi accesses = new UserCompanyAccessApi(config);
            foreach (UserCompanyAccessReport access in accesses.UserCompanyAccessLoadMyAccessGet(""))
            {
                Console.WriteLine(access.CompanyName);
            }

            // client id?!
            // http methods!?
            // indicatorids is just "body" here. Not really helpful
            // mergeIndicatordata not available in swagger

            PerformanceIndicatorMonthDataApi months = new PerformanceIndicatorMonthDataApi(config);
            List<int?> indicators = new List<int?>();
            indicators.Add(208);

            foreach (PerformanceIndicatorMonthData data in months.PerformanceIndicatorMonthDataLoadCompetitorValuesForYearPut("", indicators, 2017, 30))
            {
                Console.WriteLine(data.ID);
            }


        }
    }
}
