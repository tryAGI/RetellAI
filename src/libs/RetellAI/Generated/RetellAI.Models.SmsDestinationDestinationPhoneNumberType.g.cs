
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SmsDestinationDestinationPhoneNumberType
    {
        /// <summary>
        ///
        /// </summary>
        PhoneNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsDestinationDestinationPhoneNumberTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsDestinationDestinationPhoneNumberType value)
        {
            return value switch
            {
                SmsDestinationDestinationPhoneNumberType.PhoneNumber => "phone_number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsDestinationDestinationPhoneNumberType? ToEnum(string value)
        {
            return value switch
            {
                "phone_number" => SmsDestinationDestinationPhoneNumberType.PhoneNumber,
                _ => null,
            };
        }
    }
}