
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlertRuleAppUsage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AlertRuleAppUsageTypeJsonConverter))]
        public global::RetellAI.AlertRuleAppUsageType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_rule_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AlertRuleId { get; set; }

        /// <summary>
        /// Current alert rule name; omitted if it was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_rule_name")]
        public string? AlertRuleName { get; set; }

        /// <summary>
        /// When this reference was last recorded, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configured_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConfiguredTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertRuleAppUsage" /> class.
        /// </summary>
        /// <param name="alertRuleId"></param>
        /// <param name="configuredTimestamp">
        /// When this reference was last recorded, in milliseconds.
        /// </param>
        /// <param name="type"></param>
        /// <param name="alertRuleName">
        /// Current alert rule name; omitted if it was deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertRuleAppUsage(
            string alertRuleId,
            double configuredTimestamp,
            global::RetellAI.AlertRuleAppUsageType type,
            string? alertRuleName)
        {
            this.Type = type;
            this.AlertRuleId = alertRuleId ?? throw new global::System.ArgumentNullException(nameof(alertRuleId));
            this.AlertRuleName = alertRuleName;
            this.ConfiguredTimestamp = configuredTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertRuleAppUsage" /> class.
        /// </summary>
        public AlertRuleAppUsage()
        {
        }

    }
}