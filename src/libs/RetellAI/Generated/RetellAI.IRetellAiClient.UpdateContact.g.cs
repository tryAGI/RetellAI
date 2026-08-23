#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Update an existing contact.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.Contact> UpdateContactAsync(
            string contactId,

            global::RetellAI.UpdateContactRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing contact.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.Contact>> UpdateContactAsResponseAsync(
            string contactId,

            global::RetellAI.UpdateContactRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing contact.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="firstName">
        /// First name of the contact.
        /// </param>
        /// <param name="lastName">
        /// Last name of the contact.
        /// </param>
        /// <param name="doNotCall"></param>
        /// <param name="customFields">
        /// Values must match the types defined in CRM config custom fields. Set a value to null to clear it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.Contact> UpdateContactAsync(
            string contactId,
            string? firstName = default,
            string? lastName = default,
            bool? doNotCall = default,
            object? customFields = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}