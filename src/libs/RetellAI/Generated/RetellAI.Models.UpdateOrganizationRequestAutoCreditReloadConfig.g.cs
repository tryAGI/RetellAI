
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Auto reload configuration. Set to null to clear existing config. Both values are in cents. `target_amount` must be strictly greater than `threshold`, and the gap must be at least 1000 cents ($10).
    /// </summary>
    public sealed partial class UpdateOrganizationRequestAutoCreditReloadConfig
    {
        /// <summary>
        /// Trigger auto reload when balance is &lt;= threshold (in cents). Must be a positive number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Target balance to reach after auto reload (in cents). Must be strictly greater than `threshold` and at least 1000 cents ($10) above `threshold`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_amount")]
        public double? TargetAmount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationRequestAutoCreditReloadConfig" /> class.
        /// </summary>
        /// <param name="threshold">
        /// Trigger auto reload when balance is &lt;= threshold (in cents). Must be a positive number.
        /// </param>
        /// <param name="targetAmount">
        /// Target balance to reach after auto reload (in cents). Must be strictly greater than `threshold` and at least 1000 cents ($10) above `threshold`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOrganizationRequestAutoCreditReloadConfig(
            double? threshold,
            double? targetAmount)
        {
            this.Threshold = threshold;
            this.TargetAmount = targetAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationRequestAutoCreditReloadConfig" /> class.
        /// </summary>
        public UpdateOrganizationRequestAutoCreditReloadConfig()
        {
        }

    }
}