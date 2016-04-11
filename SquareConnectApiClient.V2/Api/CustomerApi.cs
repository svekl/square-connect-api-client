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
    public interface ICustomerApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// CreateCustomer
        /// </summary>
        /// <remarks>
        /// Creates a new customer for the business, which can have associated cards on file.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>CreateCustomerResponse</returns>
        CreateCustomerResponse CreateCustomer (string authorization, CreateCustomerRequest body);
  
        /// <summary>
        /// CreateCustomer
        /// </summary>
        /// <remarks>
        /// Creates a new customer for the business, which can have associated cards on file.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of CreateCustomerResponse</returns>
        ApiResponse<CreateCustomerResponse> CreateCustomerWithHttpInfo (string authorization, CreateCustomerRequest body);
        
        /// <summary>
        /// DeleteCustomer
        /// </summary>
        /// <remarks>
        /// Deletes a customer from a business.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <returns>DeleteCustomerResponse</returns>
        DeleteCustomerResponse DeleteCustomer (string authorization, string customerId);
  
        /// <summary>
        /// DeleteCustomer
        /// </summary>
        /// <remarks>
        /// Deletes a customer from a business.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <returns>ApiResponse of DeleteCustomerResponse</returns>
        ApiResponse<DeleteCustomerResponse> DeleteCustomerWithHttpInfo (string authorization, string customerId);
        
        /// <summary>
        /// ListCustomers
        /// </summary>
        /// <remarks>
        /// Lists a business&#39;s customers.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="cursor"> (optional)</param>
        /// <returns>ListCustomersResponse</returns>
        ListCustomersResponse ListCustomers (string authorization, string cursor = null);
  
        /// <summary>
        /// ListCustomers
        /// </summary>
        /// <remarks>
        /// Lists a business&#39;s customers.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="cursor"> (optional)</param>
        /// <returns>ApiResponse of ListCustomersResponse</returns>
        ApiResponse<ListCustomersResponse> ListCustomersWithHttpInfo (string authorization, string cursor = null);
        
        /// <summary>
        /// RetrieveCustomer
        /// </summary>
        /// <remarks>
        /// Returns details for a single customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <returns>RetrieveCustomerResponse</returns>
        RetrieveCustomerResponse RetrieveCustomer (string authorization, string customerId);
  
        /// <summary>
        /// RetrieveCustomer
        /// </summary>
        /// <remarks>
        /// Returns details for a single customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <returns>ApiResponse of RetrieveCustomerResponse</returns>
        ApiResponse<RetrieveCustomerResponse> RetrieveCustomerWithHttpInfo (string authorization, string customerId);
        
        /// <summary>
        /// UpdateCustomer
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId">The customer to update.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>UpdateCustomerResponse</returns>
        UpdateCustomerResponse UpdateCustomer (string authorization, string customerId, UpdateCustomerRequest body);
  
        /// <summary>
        /// UpdateCustomer
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId">The customer to update.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of UpdateCustomerResponse</returns>
        ApiResponse<UpdateCustomerResponse> UpdateCustomerWithHttpInfo (string authorization, string customerId, UpdateCustomerRequest body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// CreateCustomer
        /// </summary>
        /// <remarks>
        /// Creates a new customer for the business, which can have associated cards on file.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of CreateCustomerResponse</returns>
        System.Threading.Tasks.Task<CreateCustomerResponse> CreateCustomerAsync (string authorization, CreateCustomerRequest body);

        /// <summary>
        /// CreateCustomer
        /// </summary>
        /// <remarks>
        /// Creates a new customer for the business, which can have associated cards on file.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (CreateCustomerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateCustomerResponse>> CreateCustomerAsyncWithHttpInfo (string authorization, CreateCustomerRequest body);
        
        /// <summary>
        /// DeleteCustomer
        /// </summary>
        /// <remarks>
        /// Deletes a customer from a business.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <returns>Task of DeleteCustomerResponse</returns>
        System.Threading.Tasks.Task<DeleteCustomerResponse> DeleteCustomerAsync (string authorization, string customerId);

        /// <summary>
        /// DeleteCustomer
        /// </summary>
        /// <remarks>
        /// Deletes a customer from a business.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (DeleteCustomerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeleteCustomerResponse>> DeleteCustomerAsyncWithHttpInfo (string authorization, string customerId);
        
        /// <summary>
        /// ListCustomers
        /// </summary>
        /// <remarks>
        /// Lists a business&#39;s customers.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="cursor"> (optional)</param>
        /// <returns>Task of ListCustomersResponse</returns>
        System.Threading.Tasks.Task<ListCustomersResponse> ListCustomersAsync (string authorization, string cursor = null);

        /// <summary>
        /// ListCustomers
        /// </summary>
        /// <remarks>
        /// Lists a business&#39;s customers.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="cursor"> (optional)</param>
        /// <returns>Task of ApiResponse (ListCustomersResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListCustomersResponse>> ListCustomersAsyncWithHttpInfo (string authorization, string cursor = null);
        
        /// <summary>
        /// RetrieveCustomer
        /// </summary>
        /// <remarks>
        /// Returns details for a single customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <returns>Task of RetrieveCustomerResponse</returns>
        System.Threading.Tasks.Task<RetrieveCustomerResponse> RetrieveCustomerAsync (string authorization, string customerId);

        /// <summary>
        /// RetrieveCustomer
        /// </summary>
        /// <remarks>
        /// Returns details for a single customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (RetrieveCustomerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RetrieveCustomerResponse>> RetrieveCustomerAsyncWithHttpInfo (string authorization, string customerId);
        
        /// <summary>
        /// UpdateCustomer
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId">The customer to update.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of UpdateCustomerResponse</returns>
        System.Threading.Tasks.Task<UpdateCustomerResponse> UpdateCustomerAsync (string authorization, string customerId, UpdateCustomerRequest body);

        /// <summary>
        /// UpdateCustomer
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing customer.
        /// </remarks>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId">The customer to update.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (UpdateCustomerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpdateCustomerResponse>> UpdateCustomerAsyncWithHttpInfo (string authorization, string customerId, UpdateCustomerRequest body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CustomerApi : ICustomerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomerApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CustomerApi(Configuration configuration = null)
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
        /// CreateCustomer Creates a new customer for the business, which can have associated cards on file.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param> 
        /// <returns>CreateCustomerResponse</returns>
        public CreateCustomerResponse CreateCustomer (string authorization, CreateCustomerRequest body)
        {
             ApiResponse<CreateCustomerResponse> localVarResponse = CreateCustomerWithHttpInfo(authorization, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// CreateCustomer Creates a new customer for the business, which can have associated cards on file.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param> 
        /// <returns>ApiResponse of CreateCustomerResponse</returns>
        public ApiResponse< CreateCustomerResponse > CreateCustomerWithHttpInfo (string authorization, CreateCustomerRequest body)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling CustomerApi->CreateCustomer");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiV2Exception(400, "Missing required parameter 'body' when calling CustomerApi->CreateCustomer");
            
    
            var localVarPath = "/v2/customers";
    
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
                throw new ApiV2Exception (localVarStatusCode, "Error calling CreateCustomer: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling CreateCustomer: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CreateCustomerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateCustomerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCustomerResponse)));
            
        }

        
        /// <summary>
        /// CreateCustomer Creates a new customer for the business, which can have associated cards on file.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of CreateCustomerResponse</returns>
        public async System.Threading.Tasks.Task<CreateCustomerResponse> CreateCustomerAsync (string authorization, CreateCustomerRequest body)
        {
             ApiResponse<CreateCustomerResponse> localVarResponse = await CreateCustomerAsyncWithHttpInfo(authorization, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// CreateCustomer Creates a new customer for the business, which can have associated cards on file.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (CreateCustomerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateCustomerResponse>> CreateCustomerAsyncWithHttpInfo (string authorization, CreateCustomerRequest body)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling CreateCustomer");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiV2Exception(400, "Missing required parameter 'body' when calling CreateCustomer");
            
    
            var localVarPath = "/v2/customers";
    
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
                throw new ApiV2Exception (localVarStatusCode, "Error calling CreateCustomer: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling CreateCustomer: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCustomerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateCustomerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCustomerResponse)));
            
        }
        
        /// <summary>
        /// DeleteCustomer Deletes a customer from a business.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="customerId"></param> 
        /// <returns>DeleteCustomerResponse</returns>
        public DeleteCustomerResponse DeleteCustomer (string authorization, string customerId)
        {
             ApiResponse<DeleteCustomerResponse> localVarResponse = DeleteCustomerWithHttpInfo(authorization, customerId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// DeleteCustomer Deletes a customer from a business.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="customerId"></param> 
        /// <returns>ApiResponse of DeleteCustomerResponse</returns>
        public ApiResponse< DeleteCustomerResponse > DeleteCustomerWithHttpInfo (string authorization, string customerId)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling CustomerApi->DeleteCustomer");
            
            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiV2Exception(400, "Missing required parameter 'customerId' when calling CustomerApi->DeleteCustomer");
            
    
            var localVarPath = "/v2/customers/{customer_id}";
    
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
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiV2Exception (localVarStatusCode, "Error calling DeleteCustomer: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling DeleteCustomer: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeleteCustomerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeleteCustomerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteCustomerResponse)));
            
        }

        
        /// <summary>
        /// DeleteCustomer Deletes a customer from a business.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <returns>Task of DeleteCustomerResponse</returns>
        public async System.Threading.Tasks.Task<DeleteCustomerResponse> DeleteCustomerAsync (string authorization, string customerId)
        {
             ApiResponse<DeleteCustomerResponse> localVarResponse = await DeleteCustomerAsyncWithHttpInfo(authorization, customerId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// DeleteCustomer Deletes a customer from a business.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (DeleteCustomerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeleteCustomerResponse>> DeleteCustomerAsyncWithHttpInfo (string authorization, string customerId)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling DeleteCustomer");
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiV2Exception(400, "Missing required parameter 'customerId' when calling DeleteCustomer");
            
    
            var localVarPath = "/v2/customers/{customer_id}";
    
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
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiV2Exception (localVarStatusCode, "Error calling DeleteCustomer: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling DeleteCustomer: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeleteCustomerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeleteCustomerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteCustomerResponse)));
            
        }
        
        /// <summary>
        /// ListCustomers Lists a business&#39;s customers.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="cursor"> (optional)</param> 
        /// <returns>ListCustomersResponse</returns>
        public ListCustomersResponse ListCustomers (string authorization, string cursor = null)
        {
             ApiResponse<ListCustomersResponse> localVarResponse = ListCustomersWithHttpInfo(authorization, cursor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// ListCustomers Lists a business&#39;s customers.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="cursor"> (optional)</param> 
        /// <returns>ApiResponse of ListCustomersResponse</returns>
        public ApiResponse< ListCustomersResponse > ListCustomersWithHttpInfo (string authorization, string cursor = null)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling CustomerApi->ListCustomers");
            
    
            var localVarPath = "/v2/customers";
    
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
            
            if (cursor != null) localVarQueryParams.Add("cursor", Configuration.ApiClient.ParameterToString(cursor)); // query parameter
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiV2Exception (localVarStatusCode, "Error calling ListCustomers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling ListCustomers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ListCustomersResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListCustomersResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListCustomersResponse)));
            
        }

        
        /// <summary>
        /// ListCustomers Lists a business&#39;s customers.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="cursor"> (optional)</param>
        /// <returns>Task of ListCustomersResponse</returns>
        public async System.Threading.Tasks.Task<ListCustomersResponse> ListCustomersAsync (string authorization, string cursor = null)
        {
             ApiResponse<ListCustomersResponse> localVarResponse = await ListCustomersAsyncWithHttpInfo(authorization, cursor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// ListCustomers Lists a business&#39;s customers.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="cursor"> (optional)</param>
        /// <returns>Task of ApiResponse (ListCustomersResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListCustomersResponse>> ListCustomersAsyncWithHttpInfo (string authorization, string cursor = null)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling ListCustomers");
            
    
            var localVarPath = "/v2/customers";
    
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
            
            if (cursor != null) localVarQueryParams.Add("cursor", Configuration.ApiClient.ParameterToString(cursor)); // query parameter
            
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiV2Exception (localVarStatusCode, "Error calling ListCustomers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling ListCustomers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ListCustomersResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListCustomersResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListCustomersResponse)));
            
        }
        
        /// <summary>
        /// RetrieveCustomer Returns details for a single customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="customerId"></param> 
        /// <returns>RetrieveCustomerResponse</returns>
        public RetrieveCustomerResponse RetrieveCustomer (string authorization, string customerId)
        {
             ApiResponse<RetrieveCustomerResponse> localVarResponse = RetrieveCustomerWithHttpInfo(authorization, customerId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// RetrieveCustomer Returns details for a single customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="customerId"></param> 
        /// <returns>ApiResponse of RetrieveCustomerResponse</returns>
        public ApiResponse< RetrieveCustomerResponse > RetrieveCustomerWithHttpInfo (string authorization, string customerId)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling CustomerApi->RetrieveCustomer");
            
            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiV2Exception(400, "Missing required parameter 'customerId' when calling CustomerApi->RetrieveCustomer");
            
    
            var localVarPath = "/v2/customers/{customer_id}";
    
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
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiV2Exception (localVarStatusCode, "Error calling RetrieveCustomer: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling RetrieveCustomer: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RetrieveCustomerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RetrieveCustomerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RetrieveCustomerResponse)));
            
        }

        
        /// <summary>
        /// RetrieveCustomer Returns details for a single customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <returns>Task of RetrieveCustomerResponse</returns>
        public async System.Threading.Tasks.Task<RetrieveCustomerResponse> RetrieveCustomerAsync (string authorization, string customerId)
        {
             ApiResponse<RetrieveCustomerResponse> localVarResponse = await RetrieveCustomerAsyncWithHttpInfo(authorization, customerId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// RetrieveCustomer Returns details for a single customer.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (RetrieveCustomerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RetrieveCustomerResponse>> RetrieveCustomerAsyncWithHttpInfo (string authorization, string customerId)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling RetrieveCustomer");
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiV2Exception(400, "Missing required parameter 'customerId' when calling RetrieveCustomer");
            
    
            var localVarPath = "/v2/customers/{customer_id}";
    
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
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiV2Exception (localVarStatusCode, "Error calling RetrieveCustomer: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling RetrieveCustomer: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RetrieveCustomerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RetrieveCustomerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RetrieveCustomerResponse)));
            
        }
        
        /// <summary>
        /// UpdateCustomer Updates the details of an existing customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="customerId">The customer to update.</param> 
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param> 
        /// <returns>UpdateCustomerResponse</returns>
        public UpdateCustomerResponse UpdateCustomer (string authorization, string customerId, UpdateCustomerRequest body)
        {
             ApiResponse<UpdateCustomerResponse> localVarResponse = UpdateCustomerWithHttpInfo(authorization, customerId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// UpdateCustomer Updates the details of an existing customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param> 
        /// <param name="customerId">The customer to update.</param> 
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param> 
        /// <returns>ApiResponse of UpdateCustomerResponse</returns>
        public ApiResponse< UpdateCustomerResponse > UpdateCustomerWithHttpInfo (string authorization, string customerId, UpdateCustomerRequest body)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling CustomerApi->UpdateCustomer");
            
            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiV2Exception(400, "Missing required parameter 'customerId' when calling CustomerApi->UpdateCustomer");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiV2Exception(400, "Missing required parameter 'body' when calling CustomerApi->UpdateCustomer");
            
    
            var localVarPath = "/v2/customers/{customer_id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiV2Exception (localVarStatusCode, "Error calling UpdateCustomer: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling UpdateCustomer: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UpdateCustomerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateCustomerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateCustomerResponse)));
            
        }

        
        /// <summary>
        /// UpdateCustomer Updates the details of an existing customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId">The customer to update.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of UpdateCustomerResponse</returns>
        public async System.Threading.Tasks.Task<UpdateCustomerResponse> UpdateCustomerAsync (string authorization, string customerId, UpdateCustomerRequest body)
        {
             ApiResponse<UpdateCustomerResponse> localVarResponse = await UpdateCustomerAsyncWithHttpInfo(authorization, customerId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// UpdateCustomer Updates the details of an existing customer.
        /// </summary>
        /// <exception cref="ApiV2Exception">Thrown when fails to make API call</exception>
        /// <param name="authorization">The value to provide in the Authorization header of\nyour request. This value should follow the format `Bearer YOUR_ACCESS_TOKEN_HERE`.</param>
        /// <param name="customerId">The customer to update.</param>
        /// <param name="body">An object containing the fields to POST for the request.\n\nSee the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (UpdateCustomerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpdateCustomerResponse>> UpdateCustomerAsyncWithHttpInfo (string authorization, string customerId, UpdateCustomerRequest body)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiV2Exception(400, "Missing required parameter 'authorization' when calling UpdateCustomer");
            // verify the required parameter 'customerId' is set
            if (customerId == null) throw new ApiV2Exception(400, "Missing required parameter 'customerId' when calling UpdateCustomer");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiV2Exception(400, "Missing required parameter 'body' when calling UpdateCustomer");
            
    
            var localVarPath = "/v2/customers/{customer_id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiV2Exception (localVarStatusCode, "Error calling UpdateCustomer: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiV2Exception (localVarStatusCode, "Error calling UpdateCustomer: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UpdateCustomerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateCustomerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateCustomerResponse)));
            
        }
        
    }
    
}
