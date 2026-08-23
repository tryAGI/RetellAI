#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// List contacts, newest conversation first by default, with the total count of matches alongside the page. Page through results with `pagination_key`; `skip` is available for offset-style paging but is slower on large contact sets and can repeat or miss rows as contacts are updated.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.ContactListResponse> ListContactsAsync(

            global::RetellAI.ListContactsRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List contacts, newest conversation first by default, with the total count of matches alongside the page. Page through results with `pagination_key`; `skip` is available for offset-style paging but is slower on large contact sets and can repeat or miss rows as contacts are updated.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.ContactListResponse>> ListContactsAsResponseAsync(

            global::RetellAI.ListContactsRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List contacts, newest conversation first by default, with the total count of matches alongside the page. Page through results with `pagination_key`; `skip` is available for offset-style paging but is slower on large contact sets and can repeat or miss rows as contacts are updated.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of contacts to return.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="skip">
        /// Number of records to skip for offset-based pagination.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="sortOrder">
        /// Sort contacts by `last_conversation_timestamp` in ascending or descending order. Contacts that have never been contacted sort as if their timestamp were 0.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="paginationKey">
        /// Base64url-encoded pagination key from a previous response.
        /// </param>
        /// <param name="filterCriteria">
        /// Filter criteria for contacts. All conditions are implicitly connected with AND. first_name and last_name are not filterable here; use search_query to match on those.
        /// </param>
        /// <param name="searchQuery">
        /// Case-insensitive substring match against phone number, first name, last name, external ID, and custom field values. This is the only way to match on a contact's name.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.ContactListResponse> ListContactsAsync(
            double? limit = default,
            double? skip = default,
            global::RetellAI.ListContactsRequestSortOrder? sortOrder = default,
            string? paginationKey = default,
            global::RetellAI.ContactFilter? filterCriteria = default,
            string? searchQuery = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}