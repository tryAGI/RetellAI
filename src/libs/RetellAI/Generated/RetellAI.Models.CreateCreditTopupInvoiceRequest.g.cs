
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCreditTopupInvoiceRequest
    {
        /// <summary>
        /// Top-up amount in cents. Must be between 1000 ($10) and 1000000 ($10,000).<br/>
        /// Example: 5000
        /// </summary>
        /// <example>5000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_in_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AmountInCents { get; set; }

        /// <summary>
        /// Client-generated idempotency key for duplicate request protection.<br/>
        /// Example: c0f595c6-bb6a-4f82-bf7f-923f832af7b4
        /// </summary>
        /// <example>c0f595c6-bb6a-4f82-bf7f-923f832af7b4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("idempotency_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdempotencyKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditTopupInvoiceRequest" /> class.
        /// </summary>
        /// <param name="amountInCents">
        /// Top-up amount in cents. Must be between 1000 ($10) and 1000000 ($10,000).<br/>
        /// Example: 5000
        /// </param>
        /// <param name="idempotencyKey">
        /// Client-generated idempotency key for duplicate request protection.<br/>
        /// Example: c0f595c6-bb6a-4f82-bf7f-923f832af7b4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCreditTopupInvoiceRequest(
            int amountInCents,
            string idempotencyKey)
        {
            this.AmountInCents = amountInCents;
            this.IdempotencyKey = idempotencyKey ?? throw new global::System.ArgumentNullException(nameof(idempotencyKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditTopupInvoiceRequest" /> class.
        /// </summary>
        public CreateCreditTopupInvoiceRequest()
        {
        }

    }
}