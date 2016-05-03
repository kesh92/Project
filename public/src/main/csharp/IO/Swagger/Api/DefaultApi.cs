using System;
using System.IO;
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
    public interface IDefaultApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Hello, hello, is there anybody in there?
        /// </summary>
        /// <remarks>
        /// Standard_Description
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="streetName"> (optional)</param>
        /// <param name="city222"> (optional)</param>
        /// <returns>Definition1</returns>
        Definition1 GetGet (string streetName = null, string city222 = null);
  
        /// <summary>
        /// Hello, hello, is there anybody in there?
        /// </summary>
        /// <remarks>
        /// Standard_Description
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="streetName"> (optional)</param>
        /// <param name="city222"> (optional)</param>
        /// <returns>ApiResponse of Definition1</returns>
        ApiResponse<Definition1> GetGetWithHttpInfo (string streetName = null, string city222 = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Hello, hello, is there anybody in there?
        /// </summary>
        /// <remarks>
        /// Standard_Description
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="streetName"> (optional)</param>
        /// <param name="city222"> (optional)</param>
        /// <returns>Task of Definition1</returns>
        System.Threading.Tasks.Task<Definition1> GetGetAsync (string streetName = null, string city222 = null);

        /// <summary>
        /// Hello, hello, is there anybody in there?
        /// </summary>
        /// <remarks>
        /// Standard_Description
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="streetName"> (optional)</param>
        /// <param name="city222"> (optional)</param>
        /// <returns>Task of ApiResponse (Definition1)</returns>
        System.Threading.Tasks.Task<ApiResponse<Definition1>> GetGetAsyncWithHttpInfo (string streetName = null, string city222 = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(Configuration configuration = null)
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
        /// Hello, hello, is there anybody in there? Standard_Description
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="streetName"> (optional)</param> 
        /// <param name="city222"> (optional)</param> 
        /// <returns>Definition1</returns>
        public Definition1 GetGet (string streetName = null, string city222 = null)
        {
             ApiResponse<Definition1> localVarResponse = GetGetWithHttpInfo(streetName, city222);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Hello, hello, is there anybody in there? Standard_Description
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="streetName"> (optional)</param> 
        /// <param name="city222"> (optional)</param> 
        /// <returns>ApiResponse of Definition1</returns>
        public ApiResponse< Definition1 > GetGetWithHttpInfo (string streetName = null, string city222 = null)
        {
            
    
            var localVarPath = "/get";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (streetName != null) localVarQueryParams.Add("Street Name", Configuration.ApiClient.ParameterToString(streetName)); // query parameter
            if (city222 != null) localVarQueryParams.Add("City222", Configuration.ApiClient.ParameterToString(city222)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Definition1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Definition1) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Definition1)));
            
        }

        
        /// <summary>
        /// Hello, hello, is there anybody in there? Standard_Description
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="streetName"> (optional)</param>
        /// <param name="city222"> (optional)</param>
        /// <returns>Task of Definition1</returns>
        public async System.Threading.Tasks.Task<Definition1> GetGetAsync (string streetName = null, string city222 = null)
        {
             ApiResponse<Definition1> localVarResponse = await GetGetAsyncWithHttpInfo(streetName, city222);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Hello, hello, is there anybody in there? Standard_Description
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="streetName"> (optional)</param>
        /// <param name="city222"> (optional)</param>
        /// <returns>Task of ApiResponse (Definition1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Definition1>> GetGetAsyncWithHttpInfo (string streetName = null, string city222 = null)
        {
            
    
            var localVarPath = "/get";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (streetName != null) localVarQueryParams.Add("Street Name", Configuration.ApiClient.ParameterToString(streetName)); // query parameter
            if (city222 != null) localVarQueryParams.Add("City222", Configuration.ApiClient.ParameterToString(city222)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Definition1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Definition1) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Definition1)));
            
        }
        
    }
    
}
