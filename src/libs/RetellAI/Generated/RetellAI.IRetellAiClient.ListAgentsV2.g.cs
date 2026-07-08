#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// List unique agents with pagination.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: descending
        /// </param>
        /// <param name="paginationKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentsV2Response2>> ListAgentsV2Async(

            global::RetellAI.ListAgentsV2Request request,
            int? limit = default,
            global::RetellAI.ListAgentsV2SortOrder? sortOrder = default,
            string? paginationKey = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List unique agents with pagination.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: descending
        /// </param>
        /// <param name="paginationKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentsV2Response2>>> ListAgentsV2AsResponseAsync(

            global::RetellAI.ListAgentsV2Request request,
            int? limit = default,
            global::RetellAI.ListAgentsV2SortOrder? sortOrder = default,
            string? paginationKey = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List unique agents with pagination.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: descending
        /// </param>
        /// <param name="paginationKey"></param>
        /// <param name="filterCriteria">
        /// Filters for listing agents. All provided filters are connected with AND.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAgentsV2Response2>> ListAgentsV2Async(
            int? limit = default,
            global::RetellAI.ListAgentsV2SortOrder? sortOrder = default,
            string? paginationKey = default,
            global::RetellAI.AgentListFilter? filterCriteria = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}