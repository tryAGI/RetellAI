
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OptInBillingV2Response
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_profile_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingProfileId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CadenceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_plan_subscription_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PricingPlanSubscriptionId { get; set; }

        /// <summary>
        /// Echo of starting_credits from the request (cents).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starting_credits_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartingCreditsCents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptInBillingV2Response" /> class.
        /// </summary>
        /// <param name="billingProfileId"></param>
        /// <param name="cadenceId"></param>
        /// <param name="pricingPlanSubscriptionId"></param>
        /// <param name="startingCreditsCents">
        /// Echo of starting_credits from the request (cents).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OptInBillingV2Response(
            string billingProfileId,
            string cadenceId,
            string pricingPlanSubscriptionId,
            int startingCreditsCents)
        {
            this.BillingProfileId = billingProfileId ?? throw new global::System.ArgumentNullException(nameof(billingProfileId));
            this.CadenceId = cadenceId ?? throw new global::System.ArgumentNullException(nameof(cadenceId));
            this.PricingPlanSubscriptionId = pricingPlanSubscriptionId ?? throw new global::System.ArgumentNullException(nameof(pricingPlanSubscriptionId));
            this.StartingCreditsCents = startingCreditsCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptInBillingV2Response" /> class.
        /// </summary>
        public OptInBillingV2Response()
        {
        }

    }
}