
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConductorOverageConfigVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConductorOverageConfigVariant3ModeJsonConverter))]
        public global::RetellAI.ConductorOverageConfigVariant3Mode Mode { get; set; }

        /// <summary>
        /// Max metered overage per month, in USD (max 10000).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_limit_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MonthlyLimitUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorOverageConfigVariant3" /> class.
        /// </summary>
        /// <param name="monthlyLimitUsd">
        /// Max metered overage per month, in USD (max 10000).
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorOverageConfigVariant3(
            int monthlyLimitUsd,
            global::RetellAI.ConductorOverageConfigVariant3Mode mode)
        {
            this.Mode = mode;
            this.MonthlyLimitUsd = monthlyLimitUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorOverageConfigVariant3" /> class.
        /// </summary>
        public ConductorOverageConfigVariant3()
        {
        }

    }
}