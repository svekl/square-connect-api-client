using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using SquareConnectApiClient.Client;
using SquareConnectApiClient.V1.Model;

namespace SquareConnectApiClient.V1.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorizationApi
    {
        #region Synchronous Operations

        /// <summary>
        /// ObtainToken
        /// </summary>
        /// <remarks>
        /// If you obtained a temporary authorization code from a request to the Authorize endpoint, you exchange that code for an access token with a request to this endpoint.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>ObtainTokenResponse</returns>
        ObtainTokenResponse ObtainToken(ObtainTokenRequest body);

        /// <summary>
        /// ObtainTokenWithHttpInfo
        /// </summary>
        /// <remarks>
        /// If you obtained a temporary authorization code from a request to the Authorize endpoint, you exchange that code for an access token with a request to this endpoint.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of ObtainTokenResponse</returns>
        ApiResponse<ObtainTokenResponse> ObtainTokenWithHttpInfo(ObtainTokenRequest body);

        /// <summary>
        /// RenewToken
        /// </summary>
        /// <remarks>
        /// OAuth access tokens besides your application's personal access token expire after 30 days. Use this endpoint to renew an expired token. If you provide a token that isn't expired, this endpoint does not extend its lifetime.
        /// You cannot renew an access token that has been expired for more than 15 days.Instead, the associated merchant must complete the OAuth flow from the beginning.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Important: The Authorization header you provide to this endpoint must have the following format: Authorization: Client APPLICATION_SECRET. Replace APPLICATION_SECRET with your application's secret, available from the application dashboard.</param>
        /// <param name="clientId">Your application's ID, available from the application dashboard.</param>
        /// <param name="body">>An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>RenewTokenResponse</returns>
        RenewTokenResponse RenewToken(string authorization, string clientId, RenewTokenRequest body);

        /// <summary>
        /// RenewToken
        /// </summary>
        /// <remarks>
        /// OAuth access tokens besides your application's personal access token expire after 30 days. Use this endpoint to renew an expired token. If you provide a token that isn't expired, this endpoint does not extend its lifetime.
        /// You cannot renew an access token that has been expired for more than 15 days.Instead, the associated merchant must complete the OAuth flow from the beginning.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Important: The Authorization header you provide to this endpoint must have the following format: Authorization: Client APPLICATION_SECRET. Replace APPLICATION_SECRET with your application's secret, available from the application dashboard.</param>
        /// <param name="clientId">Your application's ID, available from the application dashboard.</param>
        /// <param name="body">>An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of RenewTokenResponse</returns>
        ApiResponse<RenewTokenResponse> RenewTokenWithHttpInfo(string authorization, string clientId, RenewTokenRequest body);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// ObtainToken
        /// </summary>
        /// <remarks>
        /// If you obtained a temporary authorization code from a request to the Authorize endpoint, you exchange that code for an access token with a request to this endpoint.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ObtainTokenResponse</returns>
        Task<ObtainTokenResponse> ObtainTokenAsync(ObtainTokenRequest body);

        /// <summary>
        /// ObtainTokenWithHttpInfo
        /// </summary>
        /// <remarks>
        /// If you obtained a temporary authorization code from a request to the Authorize endpoint, you exchange that code for an access token with a request to this endpoint.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (ObtainTokenResponse)</returns>
        Task<ApiResponse<ObtainTokenResponse>> ObtainTokenAsyncWithHttpInfo(ObtainTokenRequest body);

        /// <summary>
        /// RenewToken
        /// </summary>
        /// <remarks>
        /// OAuth access tokens besides your application's personal access token expire after 30 days. Use this endpoint to renew an expired token. If you provide a token that isn't expired, this endpoint does not extend its lifetime.
        /// You cannot renew an access token that has been expired for more than 15 days.Instead, the associated merchant must complete the OAuth flow from the beginning.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Important: The Authorization header you provide to this endpoint must have the following format: Authorization: Client APPLICATION_SECRET. Replace APPLICATION_SECRET with your application's secret, available from the application dashboard.</param>
        /// <param name="clientId">Your application's ID, available from the application dashboard.</param>
        /// <param name="body">>An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ARenewTokenResponse</returns>
        Task<RenewTokenResponse> RenewTokenAsync(string authorization, string clientId, RenewTokenRequest body);

        /// <summary>
        /// RenewToken
        /// </summary>
        /// <remarks>
        /// OAuth access tokens besides your application's personal access token expire after 30 days. Use this endpoint to renew an expired token. If you provide a token that isn't expired, this endpoint does not extend its lifetime.
        /// You cannot renew an access token that has been expired for more than 15 days.Instead, the associated merchant must complete the OAuth flow from the beginning.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Important: The Authorization header you provide to this endpoint must have the following format: Authorization: Client APPLICATION_SECRET. Replace APPLICATION_SECRET with your application's secret, available from the application dashboard.</param>
        /// <param name="clientId">Your application's ID, available from the application dashboard.</param>
        /// <param name="body">>An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (RenewTokenResponse)</returns>
        Task<ApiResponse<RenewTokenResponse>> RenewTokenAsyncWithHttpInfo(string authorization, string clientId, RenewTokenRequest body);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Before your application can access a Square merchant's data, the merchant needs to give your application permission. The Connect API uses the OAuth 2.0 protocol for this purpose. This is the same method that services like Twitter and Facebook use to let applications post on your behalf.
    /// </summary>
    public class AuthorizationApi : IAuthorizationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthorizationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthorizationApi(Configuration configuration = null)
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
        /// ObtainToken
        /// </summary>
        /// <remarks>
        /// If you obtained a temporary authorization code from a request to the Authorize endpoint, you exchange that code for an access token with a request to this endpoint.
        /// </remarks>
        /// <exception cref="T:SquareConnectApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>ObtainTokenResponse</returns>
        public ObtainTokenResponse ObtainToken(ObtainTokenRequest body)
        {
            ApiResponse<ObtainTokenResponse> localVarResponse = ObtainTokenWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ObtainTokenWithHttpInfo
        /// </summary>
        /// <remarks>
        /// If you obtained a temporary authorization code from a request to the Authorize endpoint, you exchange that code for an access token with a request to this endpoint.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of ObtainTokenResponse</returns>
        public ApiResponse<ObtainTokenResponse> ObtainTokenWithHttpInfo(ObtainTokenRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OAuthApi->ObtainToken");


            var localVarPath = "/oauth2/token";

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

            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling Obtain Token: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling Obtain Token: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObtainTokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObtainTokenResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObtainTokenResponse)));

        }

        /// <summary>
        /// RenewToken
        /// </summary>
        /// <remarks>
        /// OAuth access tokens besides your application's personal access token expire after 30 days. Use this endpoint to renew an expired token. If you provide a token that isn't expired, this endpoint does not extend its lifetime.
        /// You cannot renew an access token that has been expired for more than 15 days.Instead, the associated merchant must complete the OAuth flow from the beginning.
        /// </remarks>
        /// <exception cref="T:SquareConnectApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Important: The Authorization header you provide to this endpoint must have the following format: Authorization: Client APPLICATION_SECRET. Replace APPLICATION_SECRET with your application's secret, available from the application dashboard.</param>
        /// <param name="clientId">Your application's ID, available from the application dashboard.</param>
        /// <param name="body">&gt;An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>RenewTokenResponse</returns>
        public RenewTokenResponse RenewToken(string authorization, string clientId, RenewTokenRequest body)
        {
            ApiResponse<RenewTokenResponse> localVarResponse =  RenewTokenWithHttpInfo(authorization, clientId, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// RenewToken
        /// </summary>
        /// <remarks>
        /// OAuth access tokens besides your application's personal access token expire after 30 days. Use this endpoint to renew an expired token. If you provide a token that isn't expired, this endpoint does not extend its lifetime.
        /// You cannot renew an access token that has been expired for more than 15 days.Instead, the associated merchant must complete the OAuth flow from the beginning.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Important: The Authorization header you provide to this endpoint must have the following format: Authorization: Client APPLICATION_SECRET. Replace APPLICATION_SECRET with your application's secret, available from the application dashboard.</param>
        /// <param name="clientId">Your application's ID, available from the application dashboard.</param>
        /// <param name="body">>An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of RenewTokenResponse</returns>
        public ApiResponse<RenewTokenResponse> RenewTokenWithHttpInfo(string authorization, string clientId, RenewTokenRequest body)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling RenewToken");
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling RenewToken");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling RenewToken");


            var localVarPath = "/oauth2/clients/{client_id}/access-token/renew";

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
            if (clientId != null) localVarPathParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // path parameter


            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling Renew Token: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling Renew Token: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RenewTokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RenewTokenResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(RenewTokenResponse)));

        }

        /// <summary>
        /// ObtainToken
        /// </summary>
        /// <remarks>
        /// If you obtained a temporary authorization code from a request to the Authorize endpoint, you exchange that code for an access token with a request to this endpoint.
        /// </remarks>
        /// <exception cref="T:SquareConnectApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ObtainTokenResponse</returns>
        public async Task<ObtainTokenResponse> ObtainTokenAsync(ObtainTokenRequest body)
        {
            ApiResponse<ObtainTokenResponse> localVarResponse = await ObtainTokenAsyncWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ObtainTokenWithHttpInfo
        /// </summary>
        /// <remarks>
        /// If you obtained a temporary authorization code from a request to the Authorize endpoint, you exchange that code for an access token with a request to this endpoint.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (ObtainTokenResponse)</returns>
        public async Task<ApiResponse<ObtainTokenResponse>> ObtainTokenAsyncWithHttpInfo(ObtainTokenRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OAuthApi->ObtainToken");


            var localVarPath = "/oauth2/token";

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

            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling Obtain Token: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling Obtain Token: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObtainTokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObtainTokenResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObtainTokenResponse)));
        }

        /// <summary>
        /// RenewToken
        /// </summary>
        /// <remarks>
        /// OAuth access tokens besides your application's personal access token expire after 30 days. Use this endpoint to renew an expired token. If you provide a token that isn't expired, this endpoint does not extend its lifetime.
        /// You cannot renew an access token that has been expired for more than 15 days.Instead, the associated merchant must complete the OAuth flow from the beginning.
        /// </remarks>
        /// <exception cref="T:SquareConnectApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Important: The Authorization header you provide to this endpoint must have the following format: Authorization: Client APPLICATION_SECRET. Replace APPLICATION_SECRET with your application's secret, available from the application dashboard.</param>
        /// <param name="clientId">Your application's ID, available from the application dashboard.</param>
        /// <param name="body">&gt;An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ARenewTokenResponse</returns>
        public async Task<RenewTokenResponse> RenewTokenAsync(string authorization, string clientId, RenewTokenRequest body)
        {
            ApiResponse<RenewTokenResponse> localVarResponse = await RenewTokenAsyncWithHttpInfo(authorization, clientId, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// RenewToken
        /// </summary>
        /// <remarks>
        /// OAuth access tokens besides your application's personal access token expire after 30 days. Use this endpoint to renew an expired token. If you provide a token that isn't expired, this endpoint does not extend its lifetime.
        /// You cannot renew an access token that has been expired for more than 15 days.Instead, the associated merchant must complete the OAuth flow from the beginning.
        /// </remarks>
        /// <exception cref="T:SquareConnectApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Important: The Authorization header you provide to this endpoint must have the following format: Authorization: Client APPLICATION_SECRET. Replace APPLICATION_SECRET with your application's secret, available from the application dashboard.</param>
        /// <param name="clientId">Your application's ID, available from the application dashboard.</param>
        /// <param name="body">&gt;An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (RenewTokenResponse)</returns>
        public async Task<ApiResponse<RenewTokenResponse>> RenewTokenAsyncWithHttpInfo(string authorization, string clientId, RenewTokenRequest body)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling RenewToken");
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling RenewToken");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling RenewToken");


            var localVarPath = "/oauth2/clients/{client_id}/access-token/renew";

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
            if (clientId != null) localVarPathParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // path parameter


            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling Renew Token: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling Renew Token: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RenewTokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RenewTokenResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(RenewTokenResponse)));
        }
    }
    
}
