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
    public interface IRefundApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// CreateRefund
        /// </summary>
        /// <remarks>
        /// Initiates a refund for a previously charged tender.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the original transaction&#39;s associated location.</param>
        /// <param name="transactionId"></param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>CreateRefundResponse</returns>
        CreateRefundResponse CreateRefund (string authorization, string locationId, string transactionId, CreateRefundRequest body);
  
        /// <summary>
        /// CreateRefund
        /// </summary>
        /// <remarks>
        /// Initiates a refund for a previously charged tender.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the original transaction&#39;s associated location.</param>
        /// <param name="transactionId"></param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of CreateRefundResponse</returns>
        ApiResponse<CreateRefundResponse> CreateRefundWithHttpInfo (string authorization, string locationId, string transactionId, CreateRefundRequest body);
        
        /// <summary>
        /// ListRefunds
        /// </summary>
        /// <remarks>
        /// Lists refunds for one of a business&#39;s locations.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to list refunds for.</param>
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="sortOrder">The order in which results are listed in the response. (optional)</param>
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param>
        /// <returns>ListRefundsResponse</returns>
        ListRefundsResponse ListRefunds (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null);
  
        /// <summary>
        /// ListRefunds
        /// </summary>
        /// <remarks>
        /// Lists refunds for one of a business&#39;s locations.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to list refunds for.</param>
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="sortOrder">The order in which results are listed in the response. (optional)</param>
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param>
        /// <returns>ApiResponse of ListRefundsResponse</returns>
        ApiResponse<ListRefundsResponse> ListRefundsWithHttpInfo (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// CreateRefund
        /// </summary>
        /// <remarks>
        /// Initiates a refund for a previously charged tender.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the original transaction&#39;s associated location.</param>
        /// <param name="transactionId"></param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of CreateRefundResponse</returns>
        System.Threading.Tasks.Task<CreateRefundResponse> CreateRefundAsync (string authorization, string locationId, string transactionId, CreateRefundRequest body);

        /// <summary>
        /// CreateRefund
        /// </summary>
        /// <remarks>
        /// Initiates a refund for a previously charged tender.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the original transaction&#39;s associated location.</param>
        /// <param name="transactionId"></param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (CreateRefundResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateRefundResponse>> CreateRefundAsyncWithHttpInfo (string authorization, string locationId, string transactionId, CreateRefundRequest body);
        
        /// <summary>
        /// ListRefunds
        /// </summary>
        /// <remarks>
        /// Lists refunds for one of a business&#39;s locations.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to list refunds for.</param>
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="sortOrder">The order in which results are listed in the response. (optional)</param>
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param>
        /// <returns>Task of ListRefundsResponse</returns>
        System.Threading.Tasks.Task<ListRefundsResponse> ListRefundsAsync (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null);

        /// <summary>
        /// ListRefunds
        /// </summary>
        /// <remarks>
        /// Lists refunds for one of a business&#39;s locations.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to list refunds for.</param>
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="sortOrder">The order in which results are listed in the response. (optional)</param>
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param>
        /// <returns>Task of ApiResponse (ListRefundsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListRefundsResponse>> ListRefundsAsyncWithHttpInfo (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RefundApi : IRefundApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RefundApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RefundApi(Configuration configuration = null)
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
        /// CreateRefund Initiates a refund for a previously charged tender.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="locationId">The ID of the original transaction&#39;s associated location.</param> 
        /// <param name="transactionId"></param> 
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param> 
        /// <returns>CreateRefundResponse</returns>
        public CreateRefundResponse CreateRefund (string authorization, string locationId, string transactionId, CreateRefundRequest body)
        {
             ApiResponse<CreateRefundResponse> localVarResponse = CreateRefundWithHttpInfo(authorization, locationId, transactionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// CreateRefund Initiates a refund for a previously charged tender.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="locationId">The ID of the original transaction&#39;s associated location.</param> 
        /// <param name="transactionId"></param> 
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param> 
        /// <returns>ApiResponse of CreateRefundResponse</returns>
        public ApiResponse< CreateRefundResponse > CreateRefundWithHttpInfo (string authorization, string locationId, string transactionId, CreateRefundRequest body)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling RefundApi->CreateRefund");
            
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling RefundApi->CreateRefund");
            
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling RefundApi->CreateRefund");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RefundApi->CreateRefund");
            
    
            var localVarPath = "/v2/locations/{location_id}/transactions/{transaction_id}/refund";
    
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
            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            if (transactionId != null) localVarPathParams.Add("transaction_id", Configuration.ApiClient.ParameterToString(transactionId)); // path parameter
            
            
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

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateRefund: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateRefund: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CreateRefundResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateRefundResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateRefundResponse)));
            
        }

        
        /// <summary>
        /// CreateRefund Initiates a refund for a previously charged tender.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the original transaction&#39;s associated location.</param>
        /// <param name="transactionId"></param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of CreateRefundResponse</returns>
        public async System.Threading.Tasks.Task<CreateRefundResponse> CreateRefundAsync (string authorization, string locationId, string transactionId, CreateRefundRequest body)
        {
             ApiResponse<CreateRefundResponse> localVarResponse = await CreateRefundAsyncWithHttpInfo(authorization, locationId, transactionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// CreateRefund Initiates a refund for a previously charged tender.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the original transaction&#39;s associated location.</param>
        /// <param name="transactionId"></param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (CreateRefundResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateRefundResponse>> CreateRefundAsyncWithHttpInfo (string authorization, string locationId, string transactionId, CreateRefundRequest body)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling CreateRefund");
            // verify the required parameter 'locationId' is set
            if (locationId == null) throw new ApiException(400, "Missing required parameter 'locationId' when calling CreateRefund");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null) throw new ApiException(400, "Missing required parameter 'transactionId' when calling CreateRefund");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateRefund");
            
    
            var localVarPath = "/v2/locations/{location_id}/transactions/{transaction_id}/refund";
    
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
            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            if (transactionId != null) localVarPathParams.Add("transaction_id", Configuration.ApiClient.ParameterToString(transactionId)); // path parameter
            
            
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

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateRefund: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateRefund: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateRefundResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateRefundResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateRefundResponse)));
            
        }
        
        /// <summary>
        /// ListRefunds Lists refunds for one of a business&#39;s locations.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="locationId">The ID of the location to list refunds for.</param> 
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param> 
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param> 
        /// <param name="sortOrder">The order in which results are listed in the response. (optional)</param> 
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param> 
        /// <returns>ListRefundsResponse</returns>
        public ListRefundsResponse ListRefunds (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)
        {
             ApiResponse<ListRefundsResponse> localVarResponse = ListRefundsWithHttpInfo(authorization, locationId, beginTime, endTime, sortOrder, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// ListRefunds Lists refunds for one of a business&#39;s locations.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="locationId">The ID of the location to list refunds for.</param> 
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param> 
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param> 
        /// <param name="sortOrder">The order in which results are listed in the response. (optional)</param> 
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param> 
        /// <returns>ApiResponse of ListRefundsResponse</returns>
        public ApiResponse< ListRefundsResponse > ListRefundsWithHttpInfo (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling RefundApi->ListRefunds");
            
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling RefundApi->ListRefunds");
            
    
            var localVarPath = "/v2/locations/{location_id}/refunds";
    
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
            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            
            if (beginTime != null) localVarQueryParams.Add("begin_time", Configuration.ApiClient.ParameterToString(beginTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("end_time", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sort_order", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (cursor != null) localVarQueryParams.Add("cursor", Configuration.ApiClient.ParameterToString(cursor)); // query parameter
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListRefunds: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListRefunds: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ListRefundsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListRefundsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListRefundsResponse)));
            
        }

        
        /// <summary>
        /// ListRefunds Lists refunds for one of a business&#39;s locations.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to list refunds for.</param>
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="sortOrder">The order in which results are listed in the response. (optional)</param>
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param>
        /// <returns>Task of ListRefundsResponse</returns>
        public async System.Threading.Tasks.Task<ListRefundsResponse> ListRefundsAsync (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)
        {
             ApiResponse<ListRefundsResponse> localVarResponse = await ListRefundsAsyncWithHttpInfo(authorization, locationId, beginTime, endTime, sortOrder, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// ListRefunds Lists refunds for one of a business&#39;s locations.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to list refunds for.</param>
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="sortOrder">The order in which results are listed in the response. (optional)</param>
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param>
        /// <returns>Task of ApiResponse (ListRefundsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListRefundsResponse>> ListRefundsAsyncWithHttpInfo (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling ListRefunds");
            // verify the required parameter 'locationId' is set
            if (locationId == null) throw new ApiException(400, "Missing required parameter 'locationId' when calling ListRefunds");
            
    
            var localVarPath = "/v2/locations/{location_id}/refunds";
    
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
            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            
            if (beginTime != null) localVarQueryParams.Add("begin_time", Configuration.ApiClient.ParameterToString(beginTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("end_time", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sort_order", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (cursor != null) localVarQueryParams.Add("cursor", Configuration.ApiClient.ParameterToString(cursor)); // query parameter
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListRefunds: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListRefunds: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ListRefundsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListRefundsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListRefundsResponse)));
            
        }
        
    }
    
}
