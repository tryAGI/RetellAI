#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// List a contact's conversations (inbound calls, outbound calls, and chats) merged into a single timeline, most recent first. Results are matched by the contact's phone number. Use the returned `pagination_key` to fetch the next page.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="paginationKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.ContactConversationListResponse> ListContactConversationsAsync(
            string contactId,
            int? limit = default,
            string? paginationKey = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List a contact's conversations (inbound calls, outbound calls, and chats) merged into a single timeline, most recent first. Results are matched by the contact's phone number. Use the returned `pagination_key` to fetch the next page.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="paginationKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.ContactConversationListResponse>> ListContactConversationsAsResponseAsync(
            string contactId,
            int? limit = default,
            string? paginationKey = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}