/*
 * Lob
 *
 * The Lob API is organized around REST. Our API is designed to have predictable, resource-oriented URLs and uses HTTP response codes to indicate any API errors. <p> Looking for our [previous documentation](https://lob.github.io/legacy-docs/)? 
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: lob-openapi@lob.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using lob.dotnet.Client;
using lob.dotnet.Model;

namespace lob.dotnet.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIntlAutocompletionsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// autocomplete
        /// </summary>
        /// <remarks>
        /// Given an address prefix consisting of a partial primary line and country, as well as optional input of city, state, and zip code, this functionality returns up to 10 full International address suggestions. Not all of them will turn out to be valid addresses; they&#39;ll need to be [verified](#operation/intl_verification).
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="intlAutocompletionsWritable"></param>
        /// <param name="xLangOutput">* &#x60;native&#x60; - Translate response to the native language of the country in the request * &#x60;match&#x60; - match the response to the language in the request  Default response is in English.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>IntlAutocompletions</returns>
        IntlAutocompletions IntlAutocompletion(IntlAutocompletionsWritable intlAutocompletionsWritable, string xLangOutput = default(string), int operationIndex = 0);

        /// <summary>
        /// autocomplete
        /// </summary>
        /// <remarks>
        /// Given an address prefix consisting of a partial primary line and country, as well as optional input of city, state, and zip code, this functionality returns up to 10 full International address suggestions. Not all of them will turn out to be valid addresses; they&#39;ll need to be [verified](#operation/intl_verification).
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="intlAutocompletionsWritable"></param>
        /// <param name="xLangOutput">* &#x60;native&#x60; - Translate response to the native language of the country in the request * &#x60;match&#x60; - match the response to the language in the request  Default response is in English.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of IntlAutocompletions</returns>
        ApiResponse<IntlAutocompletions> IntlAutocompletionWithHttpInfo(IntlAutocompletionsWritable intlAutocompletionsWritable, string xLangOutput = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIntlAutocompletionsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// autocomplete
        /// </summary>
        /// <remarks>
        /// Given an address prefix consisting of a partial primary line and country, as well as optional input of city, state, and zip code, this functionality returns up to 10 full International address suggestions. Not all of them will turn out to be valid addresses; they&#39;ll need to be [verified](#operation/intl_verification).
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="intlAutocompletionsWritable"></param>
        /// <param name="xLangOutput">* &#x60;native&#x60; - Translate response to the native language of the country in the request * &#x60;match&#x60; - match the response to the language in the request  Default response is in English.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IntlAutocompletions</returns>
        System.Threading.Tasks.Task<IntlAutocompletions> IntlAutocompletionAsync(IntlAutocompletionsWritable intlAutocompletionsWritable, string xLangOutput = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// autocomplete
        /// </summary>
        /// <remarks>
        /// Given an address prefix consisting of a partial primary line and country, as well as optional input of city, state, and zip code, this functionality returns up to 10 full International address suggestions. Not all of them will turn out to be valid addresses; they&#39;ll need to be [verified](#operation/intl_verification).
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="intlAutocompletionsWritable"></param>
        /// <param name="xLangOutput">* &#x60;native&#x60; - Translate response to the native language of the country in the request * &#x60;match&#x60; - match the response to the language in the request  Default response is in English.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IntlAutocompletions)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntlAutocompletions>> IntlAutocompletionWithHttpInfoAsync(IntlAutocompletionsWritable intlAutocompletionsWritable, string xLangOutput = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIntlAutocompletionsApi : IIntlAutocompletionsApiSync, IIntlAutocompletionsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IntlAutocompletionsApi : IIntlAutocompletionsApi
    {
        private lob.dotnet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntlAutocompletionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IntlAutocompletionsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntlAutocompletionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IntlAutocompletionsApi(string basePath)
        {
            this.Configuration = lob.dotnet.Client.Configuration.MergeConfigurations(
                lob.dotnet.Client.GlobalConfiguration.Instance,
                new lob.dotnet.Client.Configuration { BasePath = basePath }
            );
            this.Client = new lob.dotnet.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new lob.dotnet.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = lob.dotnet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntlAutocompletionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IntlAutocompletionsApi(lob.dotnet.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = lob.dotnet.Client.Configuration.MergeConfigurations(
                lob.dotnet.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new lob.dotnet.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new lob.dotnet.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = lob.dotnet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntlAutocompletionsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public IntlAutocompletionsApi(lob.dotnet.Client.ISynchronousClient client, lob.dotnet.Client.IAsynchronousClient asyncClient, lob.dotnet.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = lob.dotnet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public lob.dotnet.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public lob.dotnet.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public lob.dotnet.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public lob.dotnet.Client.ExceptionFactory ExceptionFactory
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
        /// autocomplete Given an address prefix consisting of a partial primary line and country, as well as optional input of city, state, and zip code, this functionality returns up to 10 full International address suggestions. Not all of them will turn out to be valid addresses; they&#39;ll need to be [verified](#operation/intl_verification).
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="intlAutocompletionsWritable"></param>
        /// <param name="xLangOutput">* &#x60;native&#x60; - Translate response to the native language of the country in the request * &#x60;match&#x60; - match the response to the language in the request  Default response is in English.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>IntlAutocompletions</returns>
        public IntlAutocompletions IntlAutocompletion(IntlAutocompletionsWritable intlAutocompletionsWritable, string xLangOutput = default(string), int operationIndex = 0)
        {
            lob.dotnet.Client.ApiResponse<IntlAutocompletions> localVarResponse = IntlAutocompletionWithHttpInfo(intlAutocompletionsWritable, xLangOutput);
            return localVarResponse.Data;
        }

        /// <summary>
        /// autocomplete Given an address prefix consisting of a partial primary line and country, as well as optional input of city, state, and zip code, this functionality returns up to 10 full International address suggestions. Not all of them will turn out to be valid addresses; they&#39;ll need to be [verified](#operation/intl_verification).
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="intlAutocompletionsWritable"></param>
        /// <param name="xLangOutput">* &#x60;native&#x60; - Translate response to the native language of the country in the request * &#x60;match&#x60; - match the response to the language in the request  Default response is in English.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of IntlAutocompletions</returns>
        public lob.dotnet.Client.ApiResponse<IntlAutocompletions> IntlAutocompletionWithHttpInfo(IntlAutocompletionsWritable intlAutocompletionsWritable, string xLangOutput = default(string), int operationIndex = 0)
        {
            // verify the required parameter 'intlAutocompletionsWritable' is set
            if (intlAutocompletionsWritable == null)
            {
                throw new lob.dotnet.Client.ApiException(400, "Missing required parameter 'intlAutocompletionsWritable' when calling IntlAutocompletionsApi->IntlAutocompletion");
            }

            lob.dotnet.Client.RequestOptions localVarRequestOptions = new lob.dotnet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "application/x-www-form-urlencoded",
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = lob.dotnet.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = lob.dotnet.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (xLangOutput != null)
            {
                localVarRequestOptions.HeaderParameters.Add("x-lang-output", lob.dotnet.Client.ClientUtils.ParameterToString(xLangOutput)); // header parameter
            }
            localVarRequestOptions.Data = intlAutocompletionsWritable;

            localVarRequestOptions.Operation = "IntlAutocompletionsApi.IntlAutocompletion";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + lob.dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<IntlAutocompletions>("/intl_autocompletions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IntlAutocompletion", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// autocomplete Given an address prefix consisting of a partial primary line and country, as well as optional input of city, state, and zip code, this functionality returns up to 10 full International address suggestions. Not all of them will turn out to be valid addresses; they&#39;ll need to be [verified](#operation/intl_verification).
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="intlAutocompletionsWritable"></param>
        /// <param name="xLangOutput">* &#x60;native&#x60; - Translate response to the native language of the country in the request * &#x60;match&#x60; - match the response to the language in the request  Default response is in English.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IntlAutocompletions</returns>
        public async System.Threading.Tasks.Task<IntlAutocompletions> IntlAutocompletionAsync(IntlAutocompletionsWritable intlAutocompletionsWritable, string xLangOutput = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            lob.dotnet.Client.ApiResponse<IntlAutocompletions> localVarResponse = await IntlAutocompletionWithHttpInfoAsync(intlAutocompletionsWritable, xLangOutput, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// autocomplete Given an address prefix consisting of a partial primary line and country, as well as optional input of city, state, and zip code, this functionality returns up to 10 full International address suggestions. Not all of them will turn out to be valid addresses; they&#39;ll need to be [verified](#operation/intl_verification).
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="intlAutocompletionsWritable"></param>
        /// <param name="xLangOutput">* &#x60;native&#x60; - Translate response to the native language of the country in the request * &#x60;match&#x60; - match the response to the language in the request  Default response is in English.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IntlAutocompletions)</returns>
        public async System.Threading.Tasks.Task<lob.dotnet.Client.ApiResponse<IntlAutocompletions>> IntlAutocompletionWithHttpInfoAsync(IntlAutocompletionsWritable intlAutocompletionsWritable, string xLangOutput = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'intlAutocompletionsWritable' is set
            if (intlAutocompletionsWritable == null)
            {
                throw new lob.dotnet.Client.ApiException(400, "Missing required parameter 'intlAutocompletionsWritable' when calling IntlAutocompletionsApi->IntlAutocompletion");
            }


            lob.dotnet.Client.RequestOptions localVarRequestOptions = new lob.dotnet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "application/x-www-form-urlencoded", 
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = lob.dotnet.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = lob.dotnet.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (xLangOutput != null)
            {
                localVarRequestOptions.HeaderParameters.Add("x-lang-output", lob.dotnet.Client.ClientUtils.ParameterToString(xLangOutput)); // header parameter
            }
            localVarRequestOptions.Data = intlAutocompletionsWritable;

            localVarRequestOptions.Operation = "IntlAutocompletionsApi.IntlAutocompletion";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + lob.dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<IntlAutocompletions>("/intl_autocompletions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IntlAutocompletion", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}