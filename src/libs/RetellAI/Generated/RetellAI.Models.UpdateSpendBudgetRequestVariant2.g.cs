
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_alerts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.SpendBudgetCustomAlertRequest> CustomAlerts { get; set; }

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
        /// <param name="customAlerts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSpendBudgetRequestVariant2(
            bool enabled,
            int monthlyBudgetCents,
            global::System.Collections.Generic.IList<global::RetellAI.SpendBudgetCustomAlertRequest> customAlerts)
        {
            this.Enabled = enabled;
            this.MonthlyBudgetCents = monthlyBudgetCents;
            this.CustomAlerts = customAlerts ?? throw new global::System.ArgumentNullException(nameof(customAlerts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSpendBudgetRequestVariant2" /> class.
        /// </summary>
        public UpdateSpendBudgetRequestVariant2()
        {
        }

    }
}