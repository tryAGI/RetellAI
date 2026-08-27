
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// App integration category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AppTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AppType Type { get; set; }

        /// <summary>
        /// Provider name. Must be valid for the App's type; the supported providers per type are listed by list-app-templates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Connection health of the App, server-managed. `not_connected` after create or a credential / tenant URL change; `connected` once verified via OAuth connect, an auth test, or a successful live tool call; `error` when the provider rejects the credentials (on connect, an auth test, or a live tool call).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AppConnectionStatusJsonConverter))]
        public global::RetellAI.AppConnectionStatus? ConnectionStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Per-tenant API base URL. Set by providers with per-org hosts; omitted by providers on a single global host.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_url")]
        public string? TenantUrl { get; set; }

        /// <summary>
        /// Sub-account id, for providers that scope requests by a sub-account id on a shared host. Omitted by every other provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// Non-secret auth metadata. Encrypted secret fields are never returned by the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AppAuthConfigResponseJsonConverter))]
        public global::RetellAI.AppAuthConfigResponse? AuthConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crm_config")]
        public global::RetellAI.AppCRMConfig? CrmConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedTimestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_modified_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UserModifiedTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppResponse" /> class.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="orgId"></param>
        /// <param name="type">
        /// App integration category.
        /// </param>
        /// <param name="provider">
        /// Provider name. Must be valid for the App's type; the supported providers per type are listed by list-app-templates.
        /// </param>
        /// <param name="createdTimestamp"></param>
        /// <param name="userModifiedTimestamp"></param>
        /// <param name="connectionStatus">
        /// Connection health of the App, server-managed. `not_connected` after create or a credential / tenant URL change; `connected` once verified via OAuth connect, an auth test, or a successful live tool call; `error` when the provider rejects the credentials (on connect, an auth test, or a live tool call).
        /// </param>
        /// <param name="name"></param>
        /// <param name="tenantUrl">
        /// Per-tenant API base URL. Set by providers with per-org hosts; omitted by providers on a single global host.
        /// </param>
        /// <param name="tenantId">
        /// Sub-account id, for providers that scope requests by a sub-account id on a shared host. Omitted by every other provider.
        /// </param>
        /// <param name="authConfig">
        /// Non-secret auth metadata. Encrypted secret fields are never returned by the API.
        /// </param>
        /// <param name="crmConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppResponse(
            string appId,
            string orgId,
            global::RetellAI.AppType type,
            string provider,
            double createdTimestamp,
            double userModifiedTimestamp,
            global::RetellAI.AppConnectionStatus? connectionStatus,
            string? name,
            string? tenantUrl,
            string? tenantId,
            global::RetellAI.AppAuthConfigResponse? authConfig,
            global::RetellAI.AppCRMConfig? crmConfig)
        {
            this.AppId = appId ?? throw new global::System.ArgumentNullException(nameof(appId));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.Type = type;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ConnectionStatus = connectionStatus;
            this.Name = name;
            this.TenantUrl = tenantUrl;
            this.TenantId = tenantId;
            this.AuthConfig = authConfig;
            this.CrmConfig = crmConfig;
            this.CreatedTimestamp = createdTimestamp;
            this.UserModifiedTimestamp = userModifiedTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppResponse" /> class.
        /// </summary>
        public AppResponse()
        {
        }

    }
}