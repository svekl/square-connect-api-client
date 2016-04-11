using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SquareConnectApiClient.Client;
using SquareConnectApiClient.V2.Model;

namespace SquareConnectApiClient.V2.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILocationApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// ListLocations
        /// </summary>
        /// <remarks>
        /// Provides summary information for all of a business&#39;s locations.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <returns>ListLocationsResponse</returns>
        ListLocationsResponse ListLocations (string authorization);
  
        /// <summary>
        /// ListLocations
        /// </summary>
        /// <remarks>
        /// Provides summary information for all of a business&#39;s locations.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <returns>ApiResponse of ListLocationsResponse</returns>
        ApiResponse<ListLocationsResponse> ListLocationsWithHttpInfo (string authorization);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// ListLocations
        /// </summary>
        /// <remarks>
        /// Provides summary information for all of a business&#39;s locations.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <returns>Task of ListLocationsResponse</returns>
        System.Threading.Tasks.Task<ListLocationsResponse> ListLocationsAsync (string authorization);

        /// <summary>
        /// ListLocations
        /// </summary>
        /// <remarks>
        /// Provides summary information for all of a business&#39;s locations.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <returns>Task of ApiResponse (ListLocationsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListLocationsResponse>> ListLocationsAsyncWithHttpInfo (string authorization);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LocationApi : ILocationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LocationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

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
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// ListLocations Provides summary information for all of a business&#39;s locations.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <returns>ListLocationsResponse</returns>
        public ListLocationsResponse ListLocations (string authorization)
        {
             ApiResponse<ListLocationsResponse> localVarResponse = ListLocationsWithHttpInfo(authorization);
             return localVarResponse.Data;
        }

        /// <summary>
        /// ListLocations Provides summary information for all of a business&#39;s locations.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <returns>ApiResponse of ListLocationsResponse</returns>
        public ApiResponse< ListLocationsResponse > ListLocationsWithHttpInfo (string authorization)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling LocationApi->ListLocations");
            
    
            var localVarPath = "/v2/locations";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiV2Exception (localVarStatusCode, "Error calling ListLocations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling ListLocations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ListLocationsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListLocationsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListLocationsResponse)));
            
        }

        
        /// <summary>
        /// ListLocations Provides summary information for all of a business&#39;s locations.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <returns>Task of ListLocationsResponse</returns>
        public async System.Threading.Tasks.Task<ListLocationsResponse> ListLocationsAsync (string authorization)
        {
             ApiResponse<ListLocationsResponse> localVarResponse = await ListLocationsAsyncWithHttpInfo(authorization);
             return localVarResponse.Data;

        }

        /// <summary>
        /// ListLocations Provides summary information for all of a business&#39;s locations.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <returns>Task of ApiResponse (ListLocationsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListLocationsResponse>> ListLocationsAsyncWithHttpInfo (string authorization)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling ListLocations");
            
    
            var localVarPath = "/v2/locations";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiV2Exception (localVarStatusCode, "Error calling ListLocations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling ListLocations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ListLocationsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListLocationsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListLocationsResponse)));
            
        }
        
    }
    
}
