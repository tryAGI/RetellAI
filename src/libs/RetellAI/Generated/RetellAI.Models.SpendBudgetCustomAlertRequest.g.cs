
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpendBudgetCustomAlertRequest
    {
        /// <summary>
        /// Custom alert threshold (1-99). The automatic 80/100 thresholds are accepted and silently ignored so clients can submit the full displayed list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Percentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendBudgetCustomAlertRequest" /> class.
        /// </summary>
        /// <param name="percentage">
        /// Custom alert threshold (1-99). The automatic 80/100 thresholds are accepted and silently ignored so clients can submit the full displayed list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendBudgetCustomAlertRequest(
            int percentage)
        {
            this.Percentage = percentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendBudgetCustomAlertRequest" /> class.
        /// </summary>
        public SpendBudgetCustomAlertRequest()
        {
        }

    }
}