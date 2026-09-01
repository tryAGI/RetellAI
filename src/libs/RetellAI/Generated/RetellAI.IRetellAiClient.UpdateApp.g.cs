#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Partially update an App. Omitted fields remain unchanged. Updating auth_config or tenant metadata invalidates the cached provider token immediately. Providers using the OAuth callback reject auth_config and must be reauthorized through connect-app.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AppResponse> UpdateAppAsync(
            string appId,

            global::RetellAI.UpdateAppRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update an App. Omitted fields remain unchanged. Updating auth_config or tenant metadata invalidates the cached provider token immediately. Providers using the OAuth callback reject auth_config and must be reauthorized through connect-app.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.AppResponse>> UpdateAppAsResponseAsync(
            string appId,

            global::RetellAI.UpdateAppRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update an App. Omitted fields remain unchanged. Updating auth_config or tenant metadata invalidates the cached provider token immediately. Providers using the OAuth callback reject auth_config and must be reauthorized through connect-app.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="name"></param>
        /// <param name="tenantUrl">
        /// Per-tenant API base URL.
        /// </param>
        /// <param name="tenantId">
        /// Sub-account id, for providers that scope requests by a sub-account id on a shared host.
        /// </param>
        /// <param name="authConfig">
        /// Caller-managed credentials. Providers using the OAuth callback reject auth_config and must be authorized through connect-app.
        /// </param>
        /// <param name="crmConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AppResponse> UpdateAppAsync(
            string appId,
            string? name = default,
            string? tenantUrl = default,
            string? tenantId = default,
            global::RetellAI.AuthConfigRequest? authConfig = default,
            global::RetellAI.AppCRMConfig? crmConfig = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}