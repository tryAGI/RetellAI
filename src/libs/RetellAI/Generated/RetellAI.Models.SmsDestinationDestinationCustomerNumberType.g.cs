
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SmsDestinationDestinationCustomerNumberType
    {
        /// <summary>
        ///
        /// </summary>
        CustomerNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsDestinationDestinationCustomerNumberTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsDestinationDestinationCustomerNumberType value)
        {
            return value switch
            {
                SmsDestinationDestinationCustomerNumberType.CustomerNumber => "customer_number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsDestinationDestinationCustomerNumberType? ToEnum(string value)
        {
            return value switch
            {
                "customer_number" => SmsDestinationDestinationCustomerNumberType.CustomerNumber,
                _ => null,
            };
        }
    }
}