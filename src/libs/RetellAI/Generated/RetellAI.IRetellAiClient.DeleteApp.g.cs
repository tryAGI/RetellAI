#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Delete an App. Fails when agents or knowledge bases still reference it, unless force_delete is set. If a CRM config is linked to this App, the link is cleared.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="forceDelete"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAppAsync(
            string appId,
            bool? forceDelete = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an App. Fails when agents or knowledge bases still reference it, unless force_delete is set. If a CRM config is linked to this App, the link is cleared.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="forceDelete"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse> DeleteAppAsResponseAsync(
            string appId,
            bool? forceDelete = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}