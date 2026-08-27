
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAppRequest
    {
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
        /// Display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Per-tenant API base URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_url")]
        public string? TenantUrl { get; set; }

        /// <summary>
        /// Sub-account id, for providers that scope requests by a sub-account id on a shared host.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AuthConfigRequestJsonConverter))]
        public global::RetellAI.AuthConfigRequest? AuthConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crm_config")]
        public global::RetellAI.AppCRMConfig? CrmConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAppRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAppRequest(
            global::RetellAI.AppType type,
            string provider,
            string? name,
            string? tenantUrl,
            string? tenantId,
            global::RetellAI.AuthConfigRequest? authConfig,
            global::RetellAI.AppCRMConfig? crmConfig)
        {
            this.Type = type;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Name = name;
            this.TenantUrl = tenantUrl;
            this.TenantId = tenantId;
            this.AuthConfig = authConfig;
            this.CrmConfig = crmConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAppRequest" /> class.
        /// </summary>
        public CreateAppRequest()
        {
        }

    }
}