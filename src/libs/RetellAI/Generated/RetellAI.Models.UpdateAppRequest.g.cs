
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateAppRequest
    {
        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="UpdateAppRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
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
        public UpdateAppRequest(
            string? name,
            string? tenantUrl,
            string? tenantId,
            global::RetellAI.AuthConfigRequest? authConfig,
            global::RetellAI.AppCRMConfig? crmConfig)
        {
            this.Name = name;
            this.TenantUrl = tenantUrl;
            this.TenantId = tenantId;
            this.AuthConfig = authConfig;
            this.CrmConfig = crmConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppRequest" /> class.
        /// </summary>
        public UpdateAppRequest()
        {
        }

    }
}