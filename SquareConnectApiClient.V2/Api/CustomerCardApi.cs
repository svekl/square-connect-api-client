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
    public interface ICustomerCardApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// CreateCustomerCard
        /// </summary>
        /// <remarks>
        /// Adds a card on file to an existing customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>CreateCustomerCardResponse</returns>
        CreateCustomerCardResponse CreateCustomerCard (string authorization, string customerId, CreateCustomerCardRequest body);
  
        /// <summary>
        /// CreateCustomerCard
        /// </summary>
        /// <remarks>
        /// Adds a card on file to an existing customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of CreateCustomerCardResponse</returns>
        ApiResponse<CreateCustomerCardResponse> CreateCustomerCardWithHttpInfo (string authorization, string customerId, CreateCustomerCardRequest body);
        
        /// <summary>
        /// DeleteCustomerCard
        /// </summary>
        /// <remarks>
        /// Removes a card on file from a customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <param name="cardId"></param>
        /// <returns>DeleteCustomerCardResponse</returns>
        DeleteCustomerCardResponse DeleteCustomerCard (string authorization, string customerId, string cardId);
  
        /// <summary>
        /// DeleteCustomerCard
        /// </summary>
        /// <remarks>
        /// Removes a card on file from a customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <param name="cardId"></param>
        /// <returns>ApiResponse of DeleteCustomerCardResponse</returns>
        ApiResponse<DeleteCustomerCardResponse> DeleteCustomerCardWithHttpInfo (string authorization, string customerId, string cardId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// CreateCustomerCard
        /// </summary>
        /// <remarks>
        /// Adds a card on file to an existing customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of CreateCustomerCardResponse</returns>
        System.Threading.Tasks.Task<CreateCustomerCardResponse> CreateCustomerCardAsync (string authorization, string customerId, CreateCustomerCardRequest body);

        /// <summary>
        /// CreateCustomerCard
        /// </summary>
        /// <remarks>
        /// Adds a card on file to an existing customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (CreateCustomerCardResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateCustomerCardResponse>> CreateCustomerCardAsyncWithHttpInfo (string authorization, string customerId, CreateCustomerCardRequest body);
        
        /// <summary>
        /// DeleteCustomerCard
        /// </summary>
        /// <remarks>
        /// Removes a card on file from a customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <param name="cardId"></param>
        /// <returns>Task of DeleteCustomerCardResponse</returns>
        System.Threading.Tasks.Task<DeleteCustomerCardResponse> DeleteCustomerCardAsync (string authorization, string customerId, string cardId);

        /// <summary>
        /// DeleteCustomerCard
        /// </summary>
        /// <remarks>
        /// Removes a card on file from a customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <param name="cardId"></param>
        /// <returns>Task of ApiResponse (DeleteCustomerCardResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeleteCustomerCardResponse>> DeleteCustomerCardAsyncWithHttpInfo (string authorization, string customerId, string cardId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CustomerCardApi : ICustomerCardApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCardApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomerCardApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCardApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CustomerCardApi(Configuration configuration = null)
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
        /// CreateCustomerCard Adds a card on file to an existing customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="customerId"></param> 
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param> 
        /// <returns>CreateCustomerCardResponse</returns>
        public CreateCustomerCardResponse CreateCustomerCard (string authorization, string customerId, CreateCustomerCardRequest body)
        {
             ApiResponse<CreateCustomerCardResponse> localVarResponse = CreateCustomerCardWithHttpInfo(authorization, customerId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// CreateCustomerCard Adds a card on file to an existing customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="customerId"></param> 
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param> 
        /// <returns>ApiResponse of CreateCustomerCardResponse</returns>
        public ApiResponse< CreateCustomerCardResponse > CreateCustomerCardWithHttpInfo (string authorization, string customerId, CreateCustomerCardRequest body)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling CustomerCardApi->CreateCustomerCard");
            
            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiV2Exception(400, "Missing required parameter 'customerId' when calling CustomerCardApi->CreateCustomerCard");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiV2Exception(400, "Missing required parameter 'body' when calling CustomerCardApi->CreateCustomerCard");
            
    
            var localVarPath = "/v2/customers/{customer_id}/cards";
    
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
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter
            
            
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
                throw new ApiV2Exception (localVarStatusCode, "Error calling CreateCustomerCard: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling CreateCustomerCard: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CreateCustomerCardResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateCustomerCardResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCustomerCardResponse)));
            
        }

        
        /// <summary>
        /// CreateCustomerCard Adds a card on file to an existing customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of CreateCustomerCardResponse</returns>
        public async System.Threading.Tasks.Task<CreateCustomerCardResponse> CreateCustomerCardAsync (string authorization, string customerId, CreateCustomerCardRequest body)
        {
             ApiResponse<CreateCustomerCardResponse> localVarResponse = await CreateCustomerCardAsyncWithHttpInfo(authorization, customerId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// CreateCustomerCard Adds a card on file to an existing customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (CreateCustomerCardResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateCustomerCardResponse>> CreateCustomerCardAsyncWithHttpInfo (string authorization, string customerId, CreateCustomerCardRequest body)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling CreateCustomerCard");
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiV2Exception(400, "Missing required parameter 'customerId' when calling CreateCustomerCard");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiV2Exception(400, "Missing required parameter 'body' when calling CreateCustomerCard");
            
    
            var localVarPath = "/v2/customers/{customer_id}/cards";
    
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
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter
            
            
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
                throw new ApiV2Exception (localVarStatusCode, "Error calling CreateCustomerCard: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling CreateCustomerCard: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCustomerCardResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateCustomerCardResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCustomerCardResponse)));
            
        }
        
        /// <summary>
        /// DeleteCustomerCard Removes a card on file from a customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="customerId"></param> 
        /// <param name="cardId"></param> 
        /// <returns>DeleteCustomerCardResponse</returns>
        public DeleteCustomerCardResponse DeleteCustomerCard (string authorization, string customerId, string cardId)
        {
             ApiResponse<DeleteCustomerCardResponse> localVarResponse = DeleteCustomerCardWithHttpInfo(authorization, customerId, cardId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// DeleteCustomerCard Removes a card on file from a customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="customerId"></param> 
        /// <param name="cardId"></param> 
        /// <returns>ApiResponse of DeleteCustomerCardResponse</returns>
        public ApiResponse< DeleteCustomerCardResponse > DeleteCustomerCardWithHttpInfo (string authorization, string customerId, string cardId)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling CustomerCardApi->DeleteCustomerCard");
            
            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiV2Exception(400, "Missing required parameter 'customerId' when calling CustomerCardApi->DeleteCustomerCard");
            
            // verify the required parameter 'cardId' is set
            if (cardId == null)
                throw new ApiV2Exception(400, "Missing required parameter 'cardId' when calling CustomerCardApi->DeleteCustomerCard");
            
    
            var localVarPath = "/v2/customers/{customer_id}/cards/{card_id}";
    
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
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter
            if (cardId != null) localVarPathParams.Add("card_id", Configuration.ApiClient.ParameterToString(cardId)); // path parameter
            
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiV2Exception (localVarStatusCode, "Error calling DeleteCustomerCard: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling DeleteCustomerCard: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeleteCustomerCardResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeleteCustomerCardResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteCustomerCardResponse)));
            
        }

        
        /// <summary>
        /// DeleteCustomerCard Removes a card on file from a customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <param name="cardId"></param>
        /// <returns>Task of DeleteCustomerCardResponse</returns>
        public async System.Threading.Tasks.Task<DeleteCustomerCardResponse> DeleteCustomerCardAsync (string authorization, string customerId, string cardId)
        {
             ApiResponse<DeleteCustomerCardResponse> localVarResponse = await DeleteCustomerCardAsyncWithHttpInfo(authorization, customerId, cardId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// DeleteCustomerCard Removes a card on file from a customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <param name="cardId"></param>
        /// <returns>Task of ApiResponse (DeleteCustomerCardResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeleteCustomerCardResponse>> DeleteCustomerCardAsyncWithHttpInfo (string authorization, string customerId, string cardId)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling DeleteCustomerCard");
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiV2Exception(400, "Missing required parameter 'customerId' when calling DeleteCustomerCard");
            // verify the required parameter 'cardId' is set
            if (cardId == null) throw new ApiV2Exception(400, "Missing required parameter 'cardId' when calling DeleteCustomerCard");
            
    
            var localVarPath = "/v2/customers/{customer_id}/cards/{card_id}";
    
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
            if (customerId != null) localVarPathParams.Add("customer_id", Configuration.ApiClient.ParameterToString(customerId)); // path parameter
            if (cardId != null) localVarPathParams.Add("card_id", Configuration.ApiClient.ParameterToString(cardId)); // path parameter
            
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiV2Exception (localVarStatusCode, "Error calling DeleteCustomerCard: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling DeleteCustomerCard: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeleteCustomerCardResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeleteCustomerCardResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteCustomerCardResponse)));
            
        }
        
    }
    
}
