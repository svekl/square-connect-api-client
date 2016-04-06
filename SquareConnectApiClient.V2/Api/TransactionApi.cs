using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SquareConnectApiClient.V2.Client;
using SquareConnectApiClient.V2.Model;

namespace SquareConnectApiClient.V2.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// CaptureTransaction
        /// </summary>
        /// <remarks>
        /// Captures a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>CaptureTransactionResponse</returns>
        CaptureTransactionResponse CaptureTransaction (string authorization, string locationId, string transactionId);
  
        /// <summary>
        /// CaptureTransaction
        /// </summary>
        /// <remarks>
        /// Captures a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>ApiResponse of CaptureTransactionResponse</returns>
        ApiResponse<CaptureTransactionResponse> CaptureTransactionWithHttpInfo (string authorization, string locationId, string transactionId);
        
        /// <summary>
        /// Charge
        /// </summary>
        /// <remarks>
        /// Charges a card represented by a token.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to associate the transaction with.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>ChargeResponse</returns>
        ChargeResponse Charge (string authorization, string locationId, ChargeRequest body);
  
        /// <summary>
        /// Charge
        /// </summary>
        /// <remarks>
        /// Charges a card represented by a token.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to associate the transaction with.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of ChargeResponse</returns>
        ApiResponse<ChargeResponse> ChargeWithHttpInfo (string authorization, string locationId, ChargeRequest body);
        
        /// <summary>
        /// ListTransactions
        /// </summary>
        /// <remarks>
        /// Lists transactions for a particular location.\n\nWhen making a request to this endpoint, your request body **must** include either the `cursor` parameter, or it must\ninclude both `begin_time` and `end_time` with an optional `sort_order`.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to list transactions for.</param>
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="sortOrder">The order in which results are listed in the response (`ASC` for\nchronological, `DESC` for reverse-chronological). (optional)</param>
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param>
        /// <returns>ListTransactionsResponse</returns>
        ListTransactionsResponse ListTransactions (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null);
  
        /// <summary>
        /// ListTransactions
        /// </summary>
        /// <remarks>
        /// Lists transactions for a particular location.\n\nWhen making a request to this endpoint, your request body **must** include either the `cursor` parameter, or it must\ninclude both `begin_time` and `end_time` with an optional `sort_order`.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to list transactions for.</param>
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="sortOrder">The order in which results are listed in the response (`ASC` for\nchronological, `DESC` for reverse-chronological). (optional)</param>
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param>
        /// <returns>ApiResponse of ListTransactionsResponse</returns>
        ApiResponse<ListTransactionsResponse> ListTransactionsWithHttpInfo (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null);
        
        /// <summary>
        /// RetrieveTransaction
        /// </summary>
        /// <remarks>
        /// Retrieves details for a single transaction.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>RetrieveTransactionResponse</returns>
        RetrieveTransactionResponse RetrieveTransaction (string authorization, string locationId, string transactionId);
  
        /// <summary>
        /// RetrieveTransaction
        /// </summary>
        /// <remarks>
        /// Retrieves details for a single transaction.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>ApiResponse of RetrieveTransactionResponse</returns>
        ApiResponse<RetrieveTransactionResponse> RetrieveTransactionWithHttpInfo (string authorization, string locationId, string transactionId);
        
        /// <summary>
        /// VoidTransaction
        /// </summary>
        /// <remarks>
        /// Cancels a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>VoidTransactionResponse</returns>
        VoidTransactionResponse VoidTransaction (string authorization, string locationId, string transactionId);
  
        /// <summary>
        /// VoidTransaction
        /// </summary>
        /// <remarks>
        /// Cancels a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>ApiResponse of VoidTransactionResponse</returns>
        ApiResponse<VoidTransactionResponse> VoidTransactionWithHttpInfo (string authorization, string locationId, string transactionId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// CaptureTransaction
        /// </summary>
        /// <remarks>
        /// Captures a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>Task of CaptureTransactionResponse</returns>
        System.Threading.Tasks.Task<CaptureTransactionResponse> CaptureTransactionAsync (string authorization, string locationId, string transactionId);

        /// <summary>
        /// CaptureTransaction
        /// </summary>
        /// <remarks>
        /// Captures a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>Task of ApiResponse (CaptureTransactionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CaptureTransactionResponse>> CaptureTransactionAsyncWithHttpInfo (string authorization, string locationId, string transactionId);
        
        /// <summary>
        /// Charge
        /// </summary>
        /// <remarks>
        /// Charges a card represented by a token.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to associate the transaction with.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ChargeResponse</returns>
        System.Threading.Tasks.Task<ChargeResponse> ChargeAsync (string authorization, string locationId, ChargeRequest body);

        /// <summary>
        /// Charge
        /// </summary>
        /// <remarks>
        /// Charges a card represented by a token.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to associate the transaction with.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (ChargeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChargeResponse>> ChargeAsyncWithHttpInfo (string authorization, string locationId, ChargeRequest body);
        
        /// <summary>
        /// ListTransactions
        /// </summary>
        /// <remarks>
        /// Lists transactions for a particular location.\n\nWhen making a request to this endpoint, your request body **must** include either the `cursor` parameter, or it must\ninclude both `begin_time` and `end_time` with an optional `sort_order`.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to list transactions for.</param>
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="sortOrder">The order in which results are listed in the response (`ASC` for\nchronological, `DESC` for reverse-chronological). (optional)</param>
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param>
        /// <returns>Task of ListTransactionsResponse</returns>
        System.Threading.Tasks.Task<ListTransactionsResponse> ListTransactionsAsync (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null);

        /// <summary>
        /// ListTransactions
        /// </summary>
        /// <remarks>
        /// Lists transactions for a particular location.\n\nWhen making a request to this endpoint, your request body **must** include either the `cursor` parameter, or it must\ninclude both `begin_time` and `end_time` with an optional `sort_order`.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to list transactions for.</param>
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="sortOrder">The order in which results are listed in the response (`ASC` for\nchronological, `DESC` for reverse-chronological). (optional)</param>
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param>
        /// <returns>Task of ApiResponse (ListTransactionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListTransactionsResponse>> ListTransactionsAsyncWithHttpInfo (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null);
        
        /// <summary>
        /// RetrieveTransaction
        /// </summary>
        /// <remarks>
        /// Retrieves details for a single transaction.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>Task of RetrieveTransactionResponse</returns>
        System.Threading.Tasks.Task<RetrieveTransactionResponse> RetrieveTransactionAsync (string authorization, string locationId, string transactionId);

        /// <summary>
        /// RetrieveTransaction
        /// </summary>
        /// <remarks>
        /// Retrieves details for a single transaction.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>Task of ApiResponse (RetrieveTransactionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RetrieveTransactionResponse>> RetrieveTransactionAsyncWithHttpInfo (string authorization, string locationId, string transactionId);
        
        /// <summary>
        /// VoidTransaction
        /// </summary>
        /// <remarks>
        /// Cancels a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>Task of VoidTransactionResponse</returns>
        System.Threading.Tasks.Task<VoidTransactionResponse> VoidTransactionAsync (string authorization, string locationId, string transactionId);

        /// <summary>
        /// VoidTransaction
        /// </summary>
        /// <remarks>
        /// Cancels a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>Task of ApiResponse (VoidTransactionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoidTransactionResponse>> VoidTransactionAsyncWithHttpInfo (string authorization, string locationId, string transactionId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransactionApi : ITransactionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionApi(Configuration configuration = null)
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
        /// CaptureTransaction Captures a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="locationId"></param> 
        /// <param name="transactionId"></param> 
        /// <returns>CaptureTransactionResponse</returns>
        public CaptureTransactionResponse CaptureTransaction (string authorization, string locationId, string transactionId)
        {
             ApiResponse<CaptureTransactionResponse> localVarResponse = CaptureTransactionWithHttpInfo(authorization, locationId, transactionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// CaptureTransaction Captures a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="locationId"></param> 
        /// <param name="transactionId"></param> 
        /// <returns>ApiResponse of CaptureTransactionResponse</returns>
        public ApiResponse< CaptureTransactionResponse > CaptureTransactionWithHttpInfo (string authorization, string locationId, string transactionId)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling TransactionApi->CaptureTransaction");
            
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling TransactionApi->CaptureTransaction");
            
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionApi->CaptureTransaction");
            
    
            var localVarPath = "/v2/locations/{location_id}/transactions/{transaction_id}/capture";
    
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
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CaptureTransaction: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CaptureTransaction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CaptureTransactionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CaptureTransactionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaptureTransactionResponse)));
            
        }

        
        /// <summary>
        /// CaptureTransaction Captures a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>Task of CaptureTransactionResponse</returns>
        public async System.Threading.Tasks.Task<CaptureTransactionResponse> CaptureTransactionAsync (string authorization, string locationId, string transactionId)
        {
             ApiResponse<CaptureTransactionResponse> localVarResponse = await CaptureTransactionAsyncWithHttpInfo(authorization, locationId, transactionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// CaptureTransaction Captures a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>Task of ApiResponse (CaptureTransactionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CaptureTransactionResponse>> CaptureTransactionAsyncWithHttpInfo (string authorization, string locationId, string transactionId)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling CaptureTransaction");
            // verify the required parameter 'locationId' is set
            if (locationId == null) throw new ApiException(400, "Missing required parameter 'locationId' when calling CaptureTransaction");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null) throw new ApiException(400, "Missing required parameter 'transactionId' when calling CaptureTransaction");
            
    
            var localVarPath = "/v2/locations/{location_id}/transactions/{transaction_id}/capture";
    
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
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CaptureTransaction: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CaptureTransaction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CaptureTransactionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CaptureTransactionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaptureTransactionResponse)));
            
        }
        
        /// <summary>
        /// Charge Charges a card represented by a token.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="locationId">The ID of the location to associate the transaction with.</param> 
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param> 
        /// <returns>ChargeResponse</returns>
        public ChargeResponse Charge (string authorization, string locationId, ChargeRequest body)
        {
             ApiResponse<ChargeResponse> localVarResponse = ChargeWithHttpInfo(authorization, locationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Charge Charges a card represented by a token.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="locationId">The ID of the location to associate the transaction with.</param> 
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param> 
        /// <returns>ApiResponse of ChargeResponse</returns>
        public ApiResponse< ChargeResponse > ChargeWithHttpInfo (string authorization, string locationId, ChargeRequest body)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling TransactionApi->Charge");
            
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling TransactionApi->Charge");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TransactionApi->Charge");
            
    
            var localVarPath = "/v2/locations/{location_id}/transactions";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Charge: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Charge: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ChargeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChargeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChargeResponse)));
            
        }

        
        /// <summary>
        /// Charge Charges a card represented by a token.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to associate the transaction with.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ChargeResponse</returns>
        public async System.Threading.Tasks.Task<ChargeResponse> ChargeAsync (string authorization, string locationId, ChargeRequest body)
        {
             ApiResponse<ChargeResponse> localVarResponse = await ChargeAsyncWithHttpInfo(authorization, locationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Charge Charges a card represented by a token.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to associate the transaction with.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (ChargeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChargeResponse>> ChargeAsyncWithHttpInfo (string authorization, string locationId, ChargeRequest body)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling Charge");
            // verify the required parameter 'locationId' is set
            if (locationId == null) throw new ApiException(400, "Missing required parameter 'locationId' when calling Charge");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Charge");
            
    
            var localVarPath = "/v2/locations/{location_id}/transactions";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Charge: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Charge: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChargeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChargeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChargeResponse)));
            
        }
        
        /// <summary>
        /// ListTransactions Lists transactions for a particular location.\n\nWhen making a request to this endpoint, your request body **must** include either the `cursor` parameter, or it must\ninclude both `begin_time` and `end_time` with an optional `sort_order`.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="locationId">The ID of the location to list transactions for.</param> 
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param> 
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param> 
        /// <param name="sortOrder">The order in which results are listed in the response (`ASC` for\nchronological, `DESC` for reverse-chronological). (optional)</param> 
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param> 
        /// <returns>ListTransactionsResponse</returns>
        public ListTransactionsResponse ListTransactions (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)
        {
             ApiResponse<ListTransactionsResponse> localVarResponse = ListTransactionsWithHttpInfo(authorization, locationId, beginTime, endTime, sortOrder, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// ListTransactions Lists transactions for a particular location.\n\nWhen making a request to this endpoint, your request body **must** include either the `cursor` parameter, or it must\ninclude both `begin_time` and `end_time` with an optional `sort_order`.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="locationId">The ID of the location to list transactions for.</param> 
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param> 
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param> 
        /// <param name="sortOrder">The order in which results are listed in the response (`ASC` for\nchronological, `DESC` for reverse-chronological). (optional)</param> 
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param> 
        /// <returns>ApiResponse of ListTransactionsResponse</returns>
        public ApiResponse< ListTransactionsResponse > ListTransactionsWithHttpInfo (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling TransactionApi->ListTransactions");
            
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling TransactionApi->ListTransactions");
            
    
            var localVarPath = "/v2/locations/{location_id}/transactions";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListTransactions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListTransactions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ListTransactionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListTransactionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListTransactionsResponse)));
            
        }

        
        /// <summary>
        /// ListTransactions Lists transactions for a particular location.\n\nWhen making a request to this endpoint, your request body **must** include either the `cursor` parameter, or it must\ninclude both `begin_time` and `end_time` with an optional `sort_order`.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to list transactions for.</param>
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="sortOrder">The order in which results are listed in the response (`ASC` for\nchronological, `DESC` for reverse-chronological). (optional)</param>
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param>
        /// <returns>Task of ListTransactionsResponse</returns>
        public async System.Threading.Tasks.Task<ListTransactionsResponse> ListTransactionsAsync (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)
        {
             ApiResponse<ListTransactionsResponse> localVarResponse = await ListTransactionsAsyncWithHttpInfo(authorization, locationId, beginTime, endTime, sortOrder, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// ListTransactions Lists transactions for a particular location.\n\nWhen making a request to this endpoint, your request body **must** include either the `cursor` parameter, or it must\ninclude both `begin_time` and `end_time` with an optional `sort_order`.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId">The ID of the location to list transactions for.</param>
        /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format. (optional)</param>
        /// <param name="sortOrder">The order in which results are listed in the response (`ASC` for\nchronological, `DESC` for reverse-chronological). (optional)</param>
        /// <param name="cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint. (optional)</param>
        /// <returns>Task of ApiResponse (ListTransactionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListTransactionsResponse>> ListTransactionsAsyncWithHttpInfo (string authorization, string locationId, string beginTime = null, string endTime = null, string sortOrder = null, string cursor = null)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling ListTransactions");
            // verify the required parameter 'locationId' is set
            if (locationId == null) throw new ApiException(400, "Missing required parameter 'locationId' when calling ListTransactions");
            
    
            var localVarPath = "/v2/locations/{location_id}/transactions";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListTransactions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListTransactions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ListTransactionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListTransactionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListTransactionsResponse)));
            
        }
        
        /// <summary>
        /// RetrieveTransaction Retrieves details for a single transaction.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="locationId"></param> 
        /// <param name="transactionId"></param> 
        /// <returns>RetrieveTransactionResponse</returns>
        public RetrieveTransactionResponse RetrieveTransaction (string authorization, string locationId, string transactionId)
        {
             ApiResponse<RetrieveTransactionResponse> localVarResponse = RetrieveTransactionWithHttpInfo(authorization, locationId, transactionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// RetrieveTransaction Retrieves details for a single transaction.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="locationId"></param> 
        /// <param name="transactionId"></param> 
        /// <returns>ApiResponse of RetrieveTransactionResponse</returns>
        public ApiResponse< RetrieveTransactionResponse > RetrieveTransactionWithHttpInfo (string authorization, string locationId, string transactionId)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling TransactionApi->RetrieveTransaction");
            
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling TransactionApi->RetrieveTransaction");
            
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionApi->RetrieveTransaction");
            
    
            var localVarPath = "/v2/locations/{location_id}/transactions/{transaction_id}";
    
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
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RetrieveTransaction: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RetrieveTransaction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RetrieveTransactionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RetrieveTransactionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RetrieveTransactionResponse)));
            
        }

        
        /// <summary>
        /// RetrieveTransaction Retrieves details for a single transaction.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>Task of RetrieveTransactionResponse</returns>
        public async System.Threading.Tasks.Task<RetrieveTransactionResponse> RetrieveTransactionAsync (string authorization, string locationId, string transactionId)
        {
             ApiResponse<RetrieveTransactionResponse> localVarResponse = await RetrieveTransactionAsyncWithHttpInfo(authorization, locationId, transactionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// RetrieveTransaction Retrieves details for a single transaction.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>Task of ApiResponse (RetrieveTransactionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RetrieveTransactionResponse>> RetrieveTransactionAsyncWithHttpInfo (string authorization, string locationId, string transactionId)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling RetrieveTransaction");
            // verify the required parameter 'locationId' is set
            if (locationId == null) throw new ApiException(400, "Missing required parameter 'locationId' when calling RetrieveTransaction");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null) throw new ApiException(400, "Missing required parameter 'transactionId' when calling RetrieveTransaction");
            
    
            var localVarPath = "/v2/locations/{location_id}/transactions/{transaction_id}";
    
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
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RetrieveTransaction: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RetrieveTransaction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RetrieveTransactionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RetrieveTransactionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RetrieveTransactionResponse)));
            
        }
        
        /// <summary>
        /// VoidTransaction Cancels a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="locationId"></param> 
        /// <param name="transactionId"></param> 
        /// <returns>VoidTransactionResponse</returns>
        public VoidTransactionResponse VoidTransaction (string authorization, string locationId, string transactionId)
        {
             ApiResponse<VoidTransactionResponse> localVarResponse = VoidTransactionWithHttpInfo(authorization, locationId, transactionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// VoidTransaction Cancels a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="locationId"></param> 
        /// <param name="transactionId"></param> 
        /// <returns>ApiResponse of VoidTransactionResponse</returns>
        public ApiResponse< VoidTransactionResponse > VoidTransactionWithHttpInfo (string authorization, string locationId, string transactionId)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling TransactionApi->VoidTransaction");
            
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling TransactionApi->VoidTransaction");
            
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionApi->VoidTransaction");
            
    
            var localVarPath = "/v2/locations/{location_id}/transactions/{transaction_id}/void";
    
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
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling VoidTransaction: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoidTransaction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VoidTransactionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoidTransactionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoidTransactionResponse)));
            
        }

        
        /// <summary>
        /// VoidTransaction Cancels a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>Task of VoidTransactionResponse</returns>
        public async System.Threading.Tasks.Task<VoidTransactionResponse> VoidTransactionAsync (string authorization, string locationId, string transactionId)
        {
             ApiResponse<VoidTransactionResponse> localVarResponse = await VoidTransactionAsyncWithHttpInfo(authorization, locationId, transactionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// VoidTransaction Cancels a transaction that was created with the **Charge**\nendpoint with a `delay_capture` value of `true`.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="locationId"></param>
        /// <param name="transactionId"></param>
        /// <returns>Task of ApiResponse (VoidTransactionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoidTransactionResponse>> VoidTransactionAsyncWithHttpInfo (string authorization, string locationId, string transactionId)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling VoidTransaction");
            // verify the required parameter 'locationId' is set
            if (locationId == null) throw new ApiException(400, "Missing required parameter 'locationId' when calling VoidTransaction");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null) throw new ApiException(400, "Missing required parameter 'transactionId' when calling VoidTransaction");
            
    
            var localVarPath = "/v2/locations/{location_id}/transactions/{transaction_id}/void";
    
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
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling VoidTransaction: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoidTransaction: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoidTransactionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoidTransactionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoidTransactionResponse)));
            
        }
        
    }
    
}
