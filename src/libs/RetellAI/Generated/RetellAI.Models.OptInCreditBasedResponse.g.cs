
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OptInCreditBasedResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metronome_customer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MetronomeCustomerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metronome_contract_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MetronomeContractId { get; set; }

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
        /// Initializes a new instance of the <see cref="OptInCreditBasedResponse" /> class.
        /// </summary>
        /// <param name="metronomeCustomerId"></param>
        /// <param name="metronomeContractId"></param>
        /// <param name="startingCreditsCents">
        /// Echo of starting_credits from the request (cents).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OptInCreditBasedResponse(
            string metronomeCustomerId,
            string metronomeContractId,
            int startingCreditsCents)
        {
            this.MetronomeCustomerId = metronomeCustomerId ?? throw new global::System.ArgumentNullException(nameof(metronomeCustomerId));
            this.MetronomeContractId = metronomeContractId ?? throw new global::System.ArgumentNullException(nameof(metronomeContractId));
            this.StartingCreditsCents = startingCreditsCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptInCreditBasedResponse" /> class.
        /// </summary>
        public OptInCreditBasedResponse()
        {
        }

    }
}