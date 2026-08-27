
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Organization
    {
        /// <summary>
        /// Name of the organization<br/>
        /// Example: My Organization
        /// </summary>
        /// <example>My Organization</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_name")]
        public string? OrgName { get; set; }

        /// <summary>
        /// Name of the organization<br/>
        /// Example: My Organization
        /// </summary>
        /// <example>My Organization</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgName")]
        public string? OrgName2 { get; set; }

        /// <summary>
        /// Whether outage mode is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outage_mode_enabled")]
        public bool? OutageModeEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_urls")]
        public global::System.Collections.Generic.IList<global::RetellAI.OrganizationWebhookUrl>? WebhookUrls { get; set; }

        /// <summary>
        /// API key for webhook authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_key")]
        public string? WebhookKey { get; set; }

        /// <summary>
        /// Maximum concurrent calls allowed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        public int? Concurrency { get; set; }

        /// <summary>
        /// Number of concurrency slots reserved for inbound calls. Outbound calls can use at most the remaining concurrency; inbound calls can still use the full org concurrency limit when capacity is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reserved_inbound_concurrency")]
        public int? ReservedInboundConcurrency { get; set; }

        /// <summary>
        /// Whether burst concurrency mode is enabled. When enabled, allows the org to exceed their normal concurrency limit (up to 3x or +300, whichever is lower) with a $0.10/min surcharge on burst calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency_burst_enabled")]
        public bool? ConcurrencyBurstEnabled { get; set; }

        /// <summary>
        /// Maximum token length
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_token_length")]
        public int? MaxTokenLength { get; set; }

        /// <summary>
        /// Maximum call duration in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_call_duration_ms")]
        public int? MaxCallDurationMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_voice_ids")]
        public global::System.Collections.Generic.IList<string>? CustomVoiceIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilio_subaccount_sid")]
        public string? TwilioSubaccountSid { get; set; }

        /// <summary>
        /// Whether KYC verification has been passed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kyc_passed")]
        public bool? KycPassed { get; set; }

        /// <summary>
        /// Unix timestamp of creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CreatedTimestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_audit")]
        public bool? SkipAudit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_provided")]
        public bool? ReviewProvided { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cps_config")]
        public global::RetellAI.OrganizationCpsConfig? CpsConfig { get; set; }

        /// <summary>
        /// Both values are in cents. `target_amount` must be strictly greater than `threshold`, and the gap must be at least 1000 cents ($10).<br/>
        /// Example: {"threshold":10000,"target_amount":25000}
        /// </summary>
        /// <example>{"threshold":10000,"target_amount":25000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_credit_reload_config")]
        public global::RetellAI.AutoCreditReloadConfig? AutoCreditReloadConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_id")]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// Org feature gates. Includes Dynamo-stored buckets plus computed Redis rollout flags marked exposeToApi; computed flags win on name collision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature_bucket")]
        public object? FeatureBucket { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_stable_server")]
        public bool? UseStableServer { get; set; }

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
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="orgName">
        /// Name of the organization<br/>
        /// Example: My Organization
        /// </param>
        /// <param name="orgName2">
        /// Name of the organization<br/>
        /// Example: My Organization
        /// </param>
        /// <param name="outageModeEnabled">
        /// Whether outage mode is enabled
        /// </param>
        /// <param name="webhookUrls"></param>
        /// <param name="webhookKey">
        /// API key for webhook authentication
        /// </param>
        /// <param name="concurrency">
        /// Maximum concurrent calls allowed
        /// </param>
        /// <param name="reservedInboundConcurrency">
        /// Number of concurrency slots reserved for inbound calls. Outbound calls can use at most the remaining concurrency; inbound calls can still use the full org concurrency limit when capacity is available.
        /// </param>
        /// <param name="concurrencyBurstEnabled">
        /// Whether burst concurrency mode is enabled. When enabled, allows the org to exceed their normal concurrency limit (up to 3x or +300, whichever is lower) with a $0.10/min surcharge on burst calls.
        /// </param>
        /// <param name="maxTokenLength">
        /// Maximum token length
        /// </param>
        /// <param name="maxCallDurationMs">
        /// Maximum call duration in milliseconds
        /// </param>
        /// <param name="customVoiceIds"></param>
        /// <param name="twilioSubaccountSid"></param>
        /// <param name="kycPassed">
        /// Whether KYC verification has been passed
        /// </param>
        /// <param name="createdTimestamp">
        /// Unix timestamp of creation
        /// </param>
        /// <param name="skipAudit"></param>
        /// <param name="reviewProvided"></param>
        /// <param name="cpsConfig"></param>
        /// <param name="autoCreditReloadConfig">
        /// Both values are in cents. `target_amount` must be strictly greater than `threshold`, and the gap must be at least 1000 cents ($10).<br/>
        /// Example: {"threshold":10000,"target_amount":25000}
        /// </param>
        /// <param name="enterpriseId"></param>
        /// <param name="featureBucket">
        /// Org feature gates. Includes Dynamo-stored buckets plus computed Redis rollout flags marked exposeToApi; computed flags win on name collision.
        /// </param>
        /// <param name="useStableServer"></param>
        /// <param name="conductorOverage">
        /// Conductor overage policy applied once the per-user/per-org daily free limits are exhausted. "off" rejects requests past the daily limit; "limited" allows up to `monthly_limit_usd` (USD) of metered overage per month; "unlimited" allows metered overage with no monthly cap.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Organization(
            string? orgName,
            string? orgName2,
            bool? outageModeEnabled,
            global::System.Collections.Generic.IList<global::RetellAI.OrganizationWebhookUrl>? webhookUrls,
            string? webhookKey,
            int? concurrency,
            int? reservedInboundConcurrency,
            bool? concurrencyBurstEnabled,
            int? maxTokenLength,
            int? maxCallDurationMs,
            global::System.Collections.Generic.IList<string>? customVoiceIds,
            string? twilioSubaccountSid,
            bool? kycPassed,
            global::System.DateTimeOffset? createdTimestamp,
            bool? skipAudit,
            bool? reviewProvided,
            global::RetellAI.OrganizationCpsConfig? cpsConfig,
            global::RetellAI.AutoCreditReloadConfig? autoCreditReloadConfig,
            string? enterpriseId,
            object? featureBucket,
            bool? useStableServer,
            global::RetellAI.ConductorOverageConfig? conductorOverage)
        {
            this.OrgName = orgName;
            this.OrgName2 = orgName2;
            this.OutageModeEnabled = outageModeEnabled;
            this.WebhookUrls = webhookUrls;
            this.WebhookKey = webhookKey;
            this.Concurrency = concurrency;
            this.ReservedInboundConcurrency = reservedInboundConcurrency;
            this.ConcurrencyBurstEnabled = concurrencyBurstEnabled;
            this.MaxTokenLength = maxTokenLength;
            this.MaxCallDurationMs = maxCallDurationMs;
            this.CustomVoiceIds = customVoiceIds;
            this.TwilioSubaccountSid = twilioSubaccountSid;
            this.KycPassed = kycPassed;
            this.CreatedTimestamp = createdTimestamp;
            this.SkipAudit = skipAudit;
            this.ReviewProvided = reviewProvided;
            this.CpsConfig = cpsConfig;
            this.AutoCreditReloadConfig = autoCreditReloadConfig;
            this.EnterpriseId = enterpriseId;
            this.FeatureBucket = featureBucket;
            this.UseStableServer = useStableServer;
            this.ConductorOverage = conductorOverage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        public Organization()
        {
        }

    }
}