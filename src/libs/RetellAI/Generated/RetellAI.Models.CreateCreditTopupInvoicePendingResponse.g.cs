
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCreditTopupInvoicePendingResponse
    {
        /// <summary>
        /// Returned instead of an invoice for organizations billed through Metronome. The top-up is submitted as a payment-gated commit; final outcome (credited or failed) arrives asynchronously and is not reflected in this response.<br/>
        /// Example: pending
        /// </summary>
        /// <example>pending</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CreateCreditTopupInvoicePendingResponsePaymentStatusJsonConverter))]
        public global::RetellAI.CreateCreditTopupInvoicePendingResponsePaymentStatus PaymentStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditTopupInvoicePendingResponse" /> class.
        /// </summary>
        /// <param name="paymentStatus">
        /// Returned instead of an invoice for organizations billed through Metronome. The top-up is submitted as a payment-gated commit; final outcome (credited or failed) arrives asynchronously and is not reflected in this response.<br/>
        /// Example: pending
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCreditTopupInvoicePendingResponse(
            global::RetellAI.CreateCreditTopupInvoicePendingResponsePaymentStatus paymentStatus)
        {
            this.PaymentStatus = paymentStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditTopupInvoicePendingResponse" /> class.
        /// </summary>
        public CreateCreditTopupInvoicePendingResponse()
        {
        }

    }
}