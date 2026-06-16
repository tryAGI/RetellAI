#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// List chats with unified cursor pagination response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsV3Response2>> ListChatsV3Async(

            global::RetellAI.ListChatsV3Request request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List chats with unified cursor pagination response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsV3Response2>>> ListChatsV3AsResponseAsync(

            global::RetellAI.ListChatsV3Request request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List chats with unified cursor pagination response.
        /// </summary>
        /// <param name="filterCriteria">
        /// Filter criteria for chats. All conditions are implicitly connected with AND.
        /// </param>
        /// <param name="sortOrder">
        /// Sort chats by `start_timestamp` in ascending or descending order.<br/>
        /// Default Value: descending
        /// </param>
        /// <param name="limit">
        /// Maximum number of chats to return.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="skip">
        /// Number of records to skip for pagination.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="paginationKey">
        /// Opaque pagination cursor from a previous response.
        /// </param>
        /// <param name="includeTotal">
        /// Whether to include `total` (count of all chats matching `filter_criteria`, ignoring `limit`/`skip`/`pagination_key`) in the response. Defaults to false. Each enabled request triggers an additional aggregate query, so opt in only when the total is needed.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListChatsV3Response2>> ListChatsV3Async(
            global::RetellAI.ChatFilter? filterCriteria = default,
            global::RetellAI.ListChatsV3RequestSortOrder? sortOrder = default,
            int? limit = default,
            int? skip = default,
            string? paginationKey = default,
            bool? includeTotal = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}