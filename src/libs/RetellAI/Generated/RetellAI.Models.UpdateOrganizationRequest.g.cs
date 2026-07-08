
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Partial update for PATCH /update-organization. All fields optional.
    /// </summary>
    public sealed partial class UpdateOrganizationRequest
    {
        /// <summary>
        /// Name of the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_name")]
        public string? OrgName { get; set; }

        /// <summary>
        /// Name of the organization (legacy field)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgName")]
        public string? OrgName2 { get; set; }

        /// <summary>
        /// Whether outage mode is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outage_mode_enabled")]
        public bool? OutageModeEnabled { get; set; }

        /// <summary>
        /// Whether burst concurrency mode is enabled. When enabled, allows the org to exceed their normal concurrency limit (up to 3x or +300, whichever is lower) with a $0.10/min surcharge on burst calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency_burst_enabled")]
        public bool? ConcurrencyBurstEnabled { get; set; }

        /// <summary>
        /// Whether to route calls and API requests from this organization to the stable server cluster (enterprise only). When enabled, a $0.02/min additional charge will be applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_stable_server")]
        public bool? UseStableServer { get; set; }

        /// <summary>
        /// Number of concurrency slots reserved for inbound calls. Must be less than total normal concurrency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reserved_inbound_concurrency")]
        public int? ReservedInboundConcurrency { get; set; }

        /// <summary>
        /// Auto reload configuration. Set to null to clear existing config. Both values are in cents. `target_amount` must be strictly greater than `threshold`, and the gap must be at least 1000 cents ($10).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_credit_reload_config")]
        public global::RetellAI.UpdateOrganizationRequestAutoCreditReloadConfig? AutoCreditReloadConfig { get; set; }

        /// <summary>
        /// Conductor overage policy applied once the per-user/per-org daily free limits are exhausted. "off" rejects requests past the daily limit; "limited" allows up to `monthly_limit_usd` (USD) of metered overage per month; "unlimited" allows metered overage with no monthly cap.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conductor_overage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConductorOverageConfigJsonConverter))]
        public global::RetellAI.ConductorOverageConfig? ConductorOverage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationRequest" /> class.
        /// </summary>
        /// <param name="orgName">
        /// Name of the organization
        /// </param>
        /// <param name="orgName2">
        /// Name of the organization (legacy field)
        /// </param>
        /// <param name="outageModeEnabled">
        /// Whether outage mode is enabled
        /// </param>
        /// <param name="concurrencyBurstEnabled">
        /// Whether burst concurrency mode is enabled. When enabled, allows the org to exceed their normal concurrency limit (up to 3x or +300, whichever is lower) with a $0.10/min surcharge on burst calls.
        /// </param>
        /// <param name="useStableServer">
        /// Whether to route calls and API requests from this organization to the stable server cluster (enterprise only). When enabled, a $0.02/min additional charge will be applied.
        /// </param>
        /// <param name="reservedInboundConcurrency">
        /// Number of concurrency slots reserved for inbound calls. Must be less than total normal concurrency.
        /// </param>
        /// <param name="autoCreditReloadConfig">
        /// Auto reload configuration. Set to null to clear existing config. Both values are in cents. `target_amount` must be strictly greater than `threshold`, and the gap must be at least 1000 cents ($10).
        /// </param>
        /// <param name="conductorOverage">
        /// Conductor overage policy applied once the per-user/per-org daily free limits are exhausted. "off" rejects requests past the daily limit; "limited" allows up to `monthly_limit_usd` (USD) of metered overage per month; "unlimited" allows metered overage with no monthly cap.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOrganizationRequest(
            string? orgName,
            string? orgName2,
            bool? outageModeEnabled,
            bool? concurrencyBurstEnabled,
            bool? useStableServer,
            int? reservedInboundConcurrency,
            global::RetellAI.UpdateOrganizationRequestAutoCreditReloadConfig? autoCreditReloadConfig,
            global::RetellAI.ConductorOverageConfig? conductorOverage)
        {
            this.OrgName = orgName;
            this.OrgName2 = orgName2;
            this.OutageModeEnabled = outageModeEnabled;
            this.ConcurrencyBurstEnabled = concurrencyBurstEnabled;
            this.UseStableServer = useStableServer;
            this.ReservedInboundConcurrency = reservedInboundConcurrency;
            this.AutoCreditReloadConfig = autoCreditReloadConfig;
            this.ConductorOverage = conductorOverage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationRequest" /> class.
        /// </summary>
        public UpdateOrganizationRequest()
        {
        }

    }
}