
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OptInCreditBasedRequest
    {
        /// <summary>
        /// Initial prepaid credit purchase when migrating from Billing V1 to credit-based billing, in cents (same bounds as amount_in_cents on credit top-up). Charged to the card on file via a one-time Stripe invoice before the migration completes.<br/>
        /// Example: 5000
        /// </summary>
        /// <example>5000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("starting_credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartingCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptInCreditBasedRequest" /> class.
        /// </summary>
        /// <param name="startingCredits">
        /// Initial prepaid credit purchase when migrating from Billing V1 to credit-based billing, in cents (same bounds as amount_in_cents on credit top-up). Charged to the card on file via a one-time Stripe invoice before the migration completes.<br/>
        /// Example: 5000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OptInCreditBasedRequest(
            int startingCredits)
        {
            this.StartingCredits = startingCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptInCreditBasedRequest" /> class.
        /// </summary>
        public OptInCreditBasedRequest()
        {
        }

    }
}