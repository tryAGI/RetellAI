
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Enable spend budget (monthly cap required).
    /// </summary>
    public sealed partial class UpdateSpendBudgetRequestVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Monthly spend cap in cents (greater than 0).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_budget_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MonthlyBudgetCents { get; set; }

        /// <summary>
        /// Shared recipient list for ALL budget alerts (auto 80/100 and custom). Empty or omitted falls back to the org's billing recipients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        public global::System.Collections.Generic.IList<string>? Recipients { get; set; }

        /// <summary>
        /// User-configured spend alerts (at most 5); automatic alerts are managed internally, and their 80/100 percentages are ignored if submitted (hence the max of 7 items).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alerts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.SpendBudgetCustomAlertRequest> Alerts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSpendBudgetRequestVariant2" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="monthlyBudgetCents">
        /// Monthly spend cap in cents (greater than 0).
        /// </param>
        /// <param name="alerts">
        /// User-configured spend alerts (at most 5); automatic alerts are managed internally, and their 80/100 percentages are ignored if submitted (hence the max of 7 items).
        /// </param>
        /// <param name="recipients">
        /// Shared recipient list for ALL budget alerts (auto 80/100 and custom). Empty or omitted falls back to the org's billing recipients.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSpendBudgetRequestVariant2(
            bool enabled,
            int monthlyBudgetCents,
            global::System.Collections.Generic.IList<global::RetellAI.SpendBudgetCustomAlertRequest> alerts,
            global::System.Collections.Generic.IList<string>? recipients)
        {
            this.Enabled = enabled;
            this.MonthlyBudgetCents = monthlyBudgetCents;
            this.Recipients = recipients;
            this.Alerts = alerts ?? throw new global::System.ArgumentNullException(nameof(alerts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSpendBudgetRequestVariant2" /> class.
        /// </summary>
        public UpdateSpendBudgetRequestVariant2()
        {
        }

    }
}