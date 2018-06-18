/* 
 * ForStraction service API
 *
 * Lead your organisation’s full potential to creating results
 *
 * OpenAPI spec version: 2.0.578377820
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIntegrationPipedriveSettingsPipelineStageApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// loadAll
        /// </summary>
        /// <remarks>
        /// loadAll
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_4SAPIAppID"></param>
        /// <returns>List&lt;IntegrationPipedriveSettingsPipelineStage&gt;</returns>
        List<IntegrationPipedriveSettingsPipelineStage> IntegrationPipedriveSettingsPipelineStageLoadAllGet (string _4SAPIAppID);

        /// <summary>
        /// loadAll
        /// </summary>
        /// <remarks>
        /// loadAll
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_4SAPIAppID"></param>
        /// <returns>ApiResponse of List&lt;IntegrationPipedriveSettingsPipelineStage&gt;</returns>
        ApiResponse<List<IntegrationPipedriveSettingsPipelineStage>> IntegrationPipedriveSettingsPipelineStageLoadAllGetWithHttpInfo (string _4SAPIAppID);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// loadAll
        /// </summary>
        /// <remarks>
        /// loadAll
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_4SAPIAppID"></param>
        /// <returns>Task of List&lt;IntegrationPipedriveSettingsPipelineStage&gt;</returns>
        System.Threading.Tasks.Task<List<IntegrationPipedriveSettingsPipelineStage>> IntegrationPipedriveSettingsPipelineStageLoadAllGetAsync (string _4SAPIAppID);

        /// <summary>
        /// loadAll
        /// </summary>
        /// <remarks>
        /// loadAll
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_4SAPIAppID"></param>
        /// <returns>Task of ApiResponse (List&lt;IntegrationPipedriveSettingsPipelineStage&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<IntegrationPipedriveSettingsPipelineStage>>> IntegrationPipedriveSettingsPipelineStageLoadAllGetAsyncWithHttpInfo (string _4SAPIAppID);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IntegrationPipedriveSettingsPipelineStageApi : IIntegrationPipedriveSettingsPipelineStageApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationPipedriveSettingsPipelineStageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IntegrationPipedriveSettingsPipelineStageApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationPipedriveSettingsPipelineStageApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IntegrationPipedriveSettingsPipelineStageApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// loadAll loadAll
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_4SAPIAppID"></param>
        /// <returns>List&lt;IntegrationPipedriveSettingsPipelineStage&gt;</returns>
        public List<IntegrationPipedriveSettingsPipelineStage> IntegrationPipedriveSettingsPipelineStageLoadAllGet (string _4SAPIAppID)
        {
             ApiResponse<List<IntegrationPipedriveSettingsPipelineStage>> localVarResponse = IntegrationPipedriveSettingsPipelineStageLoadAllGetWithHttpInfo(_4SAPIAppID);
             return localVarResponse.Data;
        }

        /// <summary>
        /// loadAll loadAll
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_4SAPIAppID"></param>
        /// <returns>ApiResponse of List&lt;IntegrationPipedriveSettingsPipelineStage&gt;</returns>
        public ApiResponse< List<IntegrationPipedriveSettingsPipelineStage> > IntegrationPipedriveSettingsPipelineStageLoadAllGetWithHttpInfo (string _4SAPIAppID)
        {
            // verify the required parameter '_4SAPIAppID' is set
            if (_4SAPIAppID == null)
                throw new ApiException(400, "Missing required parameter '_4SAPIAppID' when calling IntegrationPipedriveSettingsPipelineStageApi->IntegrationPipedriveSettingsPipelineStageLoadAllGet");

            var localVarPath = "/IntegrationPipedriveSettingsPipelineStage/loadAll";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (_4SAPIAppID != null) localVarHeaderParams.Add("4S-API-App-ID", Configuration.ApiClient.ParameterToString(_4SAPIAppID)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("IntegrationPipedriveSettingsPipelineStageLoadAllGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<IntegrationPipedriveSettingsPipelineStage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<IntegrationPipedriveSettingsPipelineStage>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<IntegrationPipedriveSettingsPipelineStage>)));
            
        }

        /// <summary>
        /// loadAll loadAll
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_4SAPIAppID"></param>
        /// <returns>Task of List&lt;IntegrationPipedriveSettingsPipelineStage&gt;</returns>
        public async System.Threading.Tasks.Task<List<IntegrationPipedriveSettingsPipelineStage>> IntegrationPipedriveSettingsPipelineStageLoadAllGetAsync (string _4SAPIAppID)
        {
             ApiResponse<List<IntegrationPipedriveSettingsPipelineStage>> localVarResponse = await IntegrationPipedriveSettingsPipelineStageLoadAllGetAsyncWithHttpInfo(_4SAPIAppID);
             return localVarResponse.Data;

        }

        /// <summary>
        /// loadAll loadAll
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_4SAPIAppID"></param>
        /// <returns>Task of ApiResponse (List&lt;IntegrationPipedriveSettingsPipelineStage&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<IntegrationPipedriveSettingsPipelineStage>>> IntegrationPipedriveSettingsPipelineStageLoadAllGetAsyncWithHttpInfo (string _4SAPIAppID)
        {
            // verify the required parameter '_4SAPIAppID' is set
            if (_4SAPIAppID == null)
                throw new ApiException(400, "Missing required parameter '_4SAPIAppID' when calling IntegrationPipedriveSettingsPipelineStageApi->IntegrationPipedriveSettingsPipelineStageLoadAllGet");

            var localVarPath = "/IntegrationPipedriveSettingsPipelineStage/loadAll";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (_4SAPIAppID != null) localVarHeaderParams.Add("4S-API-App-ID", Configuration.ApiClient.ParameterToString(_4SAPIAppID)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("IntegrationPipedriveSettingsPipelineStageLoadAllGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<IntegrationPipedriveSettingsPipelineStage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<IntegrationPipedriveSettingsPipelineStage>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<IntegrationPipedriveSettingsPipelineStage>)));
            
        }

    }
}