#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// List the agents and knowledge bases referencing an App, most recently configured first by default.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: descending
        /// </param>
        /// <param name="paginationKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppUsagesResponse2>> ListAppUsagesAsync(
            string appId,
            int? limit = default,
            global::RetellAI.ListAppUsagesSortOrder? sortOrder = default,
            string? paginationKey = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List the agents and knowledge bases referencing an App, most recently configured first by default.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: descending
        /// </param>
        /// <param name="paginationKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppUsagesResponse2>>> ListAppUsagesAsResponseAsync(
            string appId,
            int? limit = default,
            global::RetellAI.ListAppUsagesSortOrder? sortOrder = default,
            string? paginationKey = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}