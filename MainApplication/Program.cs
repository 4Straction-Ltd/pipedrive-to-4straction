using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;
using Newtonsoft.Json;
using System.Globalization;

namespace pipedrive_to_4straction
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * You can use 4straction pipedrive ui configuration tool
             * or you can also manually manage pipedrivesettings. Just set
             * - pipedrivesettings
             * - pipedrive pipelines
             * - pipedrive stages
             */

            Configuration config = new Configuration();
            config.AddDefaultHeader("4S-API-User-ID", "");
            config.AddDefaultHeader("4S-API-User-Password", "");
            config.AddDefaultHeader("4S-API-Partner-Key", "");
            config.AddDefaultHeader("4S-API-CompanyID-Override", "");

            IntegrationPipedriveSettingsApi settingsApi = new IntegrationPipedriveSettingsApi(config);
            IntegrationPipedriveSettingsPipelineApi pipelineApi = new IntegrationPipedriveSettingsPipelineApi(config);
            IntegrationPipedriveSettingsPipelineStageApi stageApi = new IntegrationPipedriveSettingsPipelineStageApi(config);
            PartnerApi partnerApi = new PartnerApi(config);

            List<IntegrationPipedriveSettings> settings = settingsApi.IntegrationPipedriveSettingsLoadAllGet("");
            List<IntegrationPipedriveSettingsPipeline> pipelines = pipelineApi.IntegrationPipedriveSettingsPipelineLoadAllGet("");
            List<IntegrationPipedriveSettingsPipelineStage> stages = stageApi.IntegrationPipedriveSettingsPipelineStageLoadAllGet("");

            PipedriveClassLibrary.Pipedrive.PipedriveClient client = new PipedriveClassLibrary.Pipedrive.PipedriveClient();
            client.setUsers(partnerApi.PartnerLoadAllGet(""));
            client.extractInformation(settings.FirstOrDefault(), pipelines, stages, null);

            foreach (PipedriveClassLibrary.KPI.PerformanceIndicatorMonthData data in client.getMonthlyRows())
            {
                Console.WriteLine($"Merging value indicator: {data.IndicatorId} to {data.Year}/{data.Month} with value: {data.Actual}");
                PerformanceIndicatorMonthDataApi months = new PerformanceIndicatorMonthDataApi(config);
                months.PerformanceIndicatorMonthDataMergeTargetValuePut("", data.Link, data.Year, data.Month, data.IndicatorId, data.Actual, 0, 0, 0, null, null);
            }

            foreach (PipedriveClassLibrary.KPI.PerformanceIndicatorWeekData data in client.getWeeklyRows())
            {
                Console.WriteLine($"Merging value indicator: {data.IndicatorId} to {data.Year}/{data.WeekNumber} with value: {data.Actual}");
                PerformanceIndicatorWeekDataApi weeks = new PerformanceIndicatorWeekDataApi(config);
                weeks.PerformanceIndicatorWeekDataMergeTargetValuePut("", data.Link, data.Year, data.WeekNumber, data.IndicatorId, data.Actual, 0, 0, 0, null, null);
            }

        }

    }
}
