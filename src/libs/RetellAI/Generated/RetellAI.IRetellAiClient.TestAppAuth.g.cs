#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Probe the App's stored credentials by making a minimal authenticated call to the provider. Returns success=true on a successful round-trip, and records the outcome on the App's connection_status either way.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.TestAppAuthResponse> TestAppAuthAsync(
            string appId,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Probe the App's stored credentials by making a minimal authenticated call to the provider. Returns success=true on a successful round-trip, and records the outcome on the App's connection_status either way.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.TestAppAuthResponse>> TestAppAuthAsResponseAsync(
            string appId,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}