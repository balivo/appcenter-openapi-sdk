// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CrashGroups operations.
    /// </summary>
    public partial class CrashGroups : IServiceOperations<AppCenterClient>, ICrashGroups
    {
        /// <summary>
        /// Initializes a new instance of the CrashGroups class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public CrashGroups(AppCenterClient client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the AppCenterClient
        /// </summary>
        public AppCenterClient Client { get; private set; }

        /// <summary>
        /// Gets a stacktrace for a specific crash
        /// </summary>
        /// <param name='crashGroupId'>
        /// id of a specific group
        /// </param>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='groupingOnly'>
        /// true if the stacktrace should be only the relevant thread / exception.
        /// Default is false
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="FailureException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<Stacktrace>> GetStacktraceWithHttpMessagesAsync(string crashGroupId, string ownerName, string appName, bool? groupingOnly = false, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (crashGroupId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "crashGroupId");
            }
            if (ownerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ownerName");
            }
            if (appName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "appName");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("crashGroupId", crashGroupId);
                tracingParameters.Add("groupingOnly", groupingOnly);
                tracingParameters.Add("ownerName", ownerName);
                tracingParameters.Add("appName", appName);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetStacktrace", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "v0.1/apps/{owner_name}/{app_name}/crash_groups/{crash_group_id}/stacktrace").ToString();
            _url = _url.Replace("{crash_group_id}", System.Uri.EscapeDataString(crashGroupId));
            _url = _url.Replace("{owner_name}", System.Uri.EscapeDataString(ownerName));
            _url = _url.Replace("{app_name}", System.Uri.EscapeDataString(appName));
            List<string> _queryParameters = new List<string>();
            if (groupingOnly != null)
            {
                _queryParameters.Add(string.Format("grouping_only={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(groupingOnly, Client.SerializationSettings).Trim('"'))));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new FailureException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Failure _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Failure>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<Stacktrace>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Stacktrace>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// Gets a specific group
        /// </summary>
        /// <param name='crashGroupId'>
        /// id of a specific group
        /// </param>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="FailureException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<CrashGroup>> GetWithHttpMessagesAsync(string crashGroupId, string ownerName, string appName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (crashGroupId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "crashGroupId");
            }
            if (ownerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ownerName");
            }
            if (appName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "appName");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("crashGroupId", crashGroupId);
                tracingParameters.Add("ownerName", ownerName);
                tracingParameters.Add("appName", appName);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "Get", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "v0.1/apps/{owner_name}/{app_name}/crash_groups/{crash_group_id}").ToString();
            _url = _url.Replace("{crash_group_id}", System.Uri.EscapeDataString(crashGroupId));
            _url = _url.Replace("{owner_name}", System.Uri.EscapeDataString(ownerName));
            _url = _url.Replace("{app_name}", System.Uri.EscapeDataString(appName));
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new FailureException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Failure _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Failure>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<CrashGroup>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<CrashGroup>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// Updates a group
        /// </summary>
        /// <param name='crashGroupId'>
        /// id of a specific group
        /// </param>
        /// <param name='group'>
        /// Group change object. All fields are optional and only provided fields will
        /// get updated.
        /// </param>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="FailureException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<CrashGroup>> UpdateWithHttpMessagesAsync(string crashGroupId, CrashGroupChange group, string ownerName, string appName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (crashGroupId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "crashGroupId");
            }
            if (group == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "group");
            }
            if (ownerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ownerName");
            }
            if (appName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "appName");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("crashGroupId", crashGroupId);
                tracingParameters.Add("group", group);
                tracingParameters.Add("ownerName", ownerName);
                tracingParameters.Add("appName", appName);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "Update", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "v0.1/apps/{owner_name}/{app_name}/crash_groups/{crash_group_id}").ToString();
            _url = _url.Replace("{crash_group_id}", System.Uri.EscapeDataString(crashGroupId));
            _url = _url.Replace("{owner_name}", System.Uri.EscapeDataString(ownerName));
            _url = _url.Replace("{app_name}", System.Uri.EscapeDataString(appName));
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("PATCH");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            if(group != null)
            {
                _requestContent = Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(group, Client.SerializationSettings);
                _httpRequest.Content = new StringContent(_requestContent, System.Text.Encoding.UTF8);
                _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            }
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new FailureException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Failure _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Failure>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<CrashGroup>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<CrashGroup>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// Gets a list of crash groups and whether the list contains all available
        /// groups.
        /// </summary>
        /// <remarks>
        /// Gets a list of crash groups and whether the list contains all available
        /// groups.
        /// </remarks>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='lastOccurrenceFrom'>
        /// Earliest date when the last time a crash occured in a crash group
        /// </param>
        /// <param name='lastOccurrenceTo'>
        /// Latest date when the last time a crash occured in a crash group
        /// </param>
        /// <param name='appVersion'>
        /// version
        /// </param>
        /// <param name='groupType'>
        /// Possible values include: 'GroupType1', 'GroupType2'
        /// </param>
        /// <param name='groupStatus'>
        /// Possible values include: 'open', 'closed', 'ignored'
        /// </param>
        /// <param name='groupTextSearch'>
        /// A freetext search that matches in crash, crash types, crash stack_traces
        /// and crash user
        /// </param>
        /// <param name='orderby'>
        /// the OData-like $orderby argument. Possible values include: 'last_occurrence
        /// asc', 'last_occurrence desc', 'count asc', 'count desc', 'display_id asc',
        /// 'display_id desc', 'impacted_users asc', 'impacted_users desc'
        /// </param>
        /// <param name='continuationToken'>
        /// Cassandra request continuation token. The token is used for pagination.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="FailureException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<CrashGroupsContainer>> ListWithHttpMessagesAsync(string ownerName, string appName, System.DateTime? lastOccurrenceFrom = default(System.DateTime?), System.DateTime? lastOccurrenceTo = default(System.DateTime?), string appVersion = default(string), string groupType = default(string), string groupStatus = default(string), string groupTextSearch = default(string), string orderby = default(string), string continuationToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (ownerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ownerName");
            }
            if (appName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "appName");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("lastOccurrenceFrom", lastOccurrenceFrom);
                tracingParameters.Add("lastOccurrenceTo", lastOccurrenceTo);
                tracingParameters.Add("appVersion", appVersion);
                tracingParameters.Add("groupType", groupType);
                tracingParameters.Add("groupStatus", groupStatus);
                tracingParameters.Add("groupTextSearch", groupTextSearch);
                tracingParameters.Add("orderby", orderby);
                tracingParameters.Add("continuationToken", continuationToken);
                tracingParameters.Add("ownerName", ownerName);
                tracingParameters.Add("appName", appName);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "List", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "v0.1/apps/{owner_name}/{app_name}/crash_groups").ToString();
            _url = _url.Replace("{owner_name}", System.Uri.EscapeDataString(ownerName));
            _url = _url.Replace("{app_name}", System.Uri.EscapeDataString(appName));
            List<string> _queryParameters = new List<string>();
            if (lastOccurrenceFrom != null)
            {
                _queryParameters.Add(string.Format("last_occurrence_from={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(lastOccurrenceFrom, Client.SerializationSettings).Trim('"'))));
            }
            if (lastOccurrenceTo != null)
            {
                _queryParameters.Add(string.Format("last_occurrence_to={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(lastOccurrenceTo, Client.SerializationSettings).Trim('"'))));
            }
            if (appVersion != null)
            {
                _queryParameters.Add(string.Format("app_version={0}", System.Uri.EscapeDataString(appVersion)));
            }
            if (groupType != null)
            {
                _queryParameters.Add(string.Format("group_type={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(groupType, Client.SerializationSettings).Trim('"'))));
            }
            if (groupStatus != null)
            {
                _queryParameters.Add(string.Format("group_status={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(groupStatus, Client.SerializationSettings).Trim('"'))));
            }
            if (groupTextSearch != null)
            {
                _queryParameters.Add(string.Format("group_text_search={0}", System.Uri.EscapeDataString(groupTextSearch)));
            }
            if (orderby != null)
            {
                _queryParameters.Add(string.Format("$orderby={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(orderby, Client.SerializationSettings).Trim('"'))));
            }
            if (continuationToken != null)
            {
                _queryParameters.Add(string.Format("continuation_token={0}", System.Uri.EscapeDataString(continuationToken)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new FailureException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Failure _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Failure>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<CrashGroupsContainer>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<CrashGroupsContainer>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
