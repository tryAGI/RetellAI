
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCreditTopupInvoiceResponse
    {
        /// <summary>
        /// Stripe invoice id.<br/>
        /// Example: in_1234567890
        /// </summary>
        /// <example>in_1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvoiceId { get; set; }

        /// <summary>
        /// Current Stripe invoice status.<br/>
        /// Example: open
        /// </summary>
        /// <example>open</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvoiceStatus { get; set; }

        /// <summary>
        /// Hosted Stripe invoice URL when available.<br/>
        /// Example: https://invoice.stripe.com/i/acct_123/invst_123
        /// </summary>
        /// <example>https://invoice.stripe.com/i/acct_123/invst_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_url")]
        public string? InvoiceUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditTopupInvoiceResponse" /> class.
        /// </summary>
        /// <param name="invoiceId">
        /// Stripe invoice id.<br/>
        /// Example: in_1234567890
        /// </param>
        /// <param name="invoiceStatus">
        /// Current Stripe invoice status.<br/>
        /// Example: open
        /// </param>
        /// <param name="invoiceUrl">
        /// Hosted Stripe invoice URL when available.<br/>
        /// Example: https://invoice.stripe.com/i/acct_123/invst_123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCreditTopupInvoiceResponse(
            string invoiceId,
            string invoiceStatus,
            string? invoiceUrl)
        {
            this.InvoiceId = invoiceId ?? throw new global::System.ArgumentNullException(nameof(invoiceId));
            this.InvoiceStatus = invoiceStatus ?? throw new global::System.ArgumentNullException(nameof(invoiceStatus));
            this.InvoiceUrl = invoiceUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditTopupInvoiceResponse" /> class.
        /// </summary>
        public CreateCreditTopupInvoiceResponse()
        {
        }

    }
}