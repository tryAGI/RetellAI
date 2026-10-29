#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// List the static catalog of available integration apps — provider, display name, description, and the tools each exposes. Not the organization's connected Apps.
        /// </summary>
        /// <param name="privacyScope">
        /// Privacy scope of an integration function.
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="paginationKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppTemplatesResponse2>> ListAppTemplatesAsync(
            global::RetellAI.PrivacyScope? privacyScope = default,
            int? limit = default,
            string? paginationKey = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List the static catalog of available integration apps — provider, display name, description, and the tools each exposes. Not the organization's connected Apps.
        /// </summary>
        /// <param name="privacyScope">
        /// Privacy scope of an integration function.
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="paginationKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.AllOf<global::RetellAI.PaginatedResponseBase, global::RetellAI.ListAppTemplatesResponse2>>> ListAppTemplatesAsResponseAsync(
            global::RetellAI.PrivacyScope? privacyScope = default,
            int? limit = default,
            string? paginationKey = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}