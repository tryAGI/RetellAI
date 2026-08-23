#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Create an App: the connection to one external system (a CRM, calendar, support desk, and so on), holding its credentials and settings. Providers that authenticate with a key, token, or refresh token can be connected in this one call by passing auth_config; the credential is stored encrypted and never returned. Up to 20 apps per provider.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AppResponse> CreateAppAsync(

            global::RetellAI.CreateAppRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an App: the connection to one external system (a CRM, calendar, support desk, and so on), holding its credentials and settings. Providers that authenticate with a key, token, or refresh token can be connected in this one call by passing auth_config; the credential is stored encrypted and never returned. Up to 20 apps per provider.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.AppResponse>> CreateAppAsResponseAsync(

            global::RetellAI.CreateAppRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an App: the connection to one external system (a CRM, calendar, support desk, and so on), holding its credentials and settings. Providers that authenticate with a key, token, or refresh token can be connected in this one call by passing auth_config; the credential is stored encrypted and never returned. Up to 20 apps per provider.
        /// </summary>
        /// <param name="type">
        /// App integration category.
        /// </param>
        /// <param name="provider">
        /// Provider name. Must be valid for the App's type; the supported providers per type are listed by list-app-templates.
        /// </param>
        /// <param name="name">
        /// Display name.
        /// </param>
        /// <param name="tenantUrl">
        /// Per-tenant API base URL.
        /// </param>
        /// <param name="tenantId">
        /// Sub-account id, for providers that scope requests by a sub-account id on a shared host.
        /// </param>
        /// <param name="authConfig"></param>
        /// <param name="crmConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AppResponse> CreateAppAsync(
            global::RetellAI.AppType type,
            string provider,
            string? name = default,
            string? tenantUrl = default,
            string? tenantId = default,
            global::RetellAI.AuthConfigRequest? authConfig = default,
            global::RetellAI.AppCRMConfig? crmConfig = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}