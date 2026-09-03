
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Returned instead of an invoice for organizations billed through Metronome. The top-up is submitted as a payment-gated commit; final outcome (credited or failed) arrives asynchronously and is not reflected in this response.<br/>
    /// Example: pending
    /// </summary>
    public enum CreateCreditTopupInvoicePendingResponsePaymentStatus
    {
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCreditTopupInvoicePendingResponsePaymentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCreditTopupInvoicePendingResponsePaymentStatus value)
        {
            return value switch
            {
                CreateCreditTopupInvoicePendingResponsePaymentStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCreditTopupInvoicePendingResponsePaymentStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => CreateCreditTopupInvoicePendingResponsePaymentStatus.Pending,
                _ => null,
            };
        }
    }
}