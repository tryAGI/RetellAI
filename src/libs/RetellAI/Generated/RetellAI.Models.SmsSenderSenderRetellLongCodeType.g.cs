
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SmsSenderSenderRetellLongCodeType
    {
        /// <summary>
        ///
        /// </summary>
        RetellLongCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsSenderSenderRetellLongCodeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsSenderSenderRetellLongCodeType value)
        {
            return value switch
            {
                SmsSenderSenderRetellLongCodeType.RetellLongCode => "retell_long_code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsSenderSenderRetellLongCodeType? ToEnum(string value)
        {
            return value switch
            {
                "retell_long_code" => SmsSenderSenderRetellLongCodeType.RetellLongCode,
                _ => null,
            };
        }
    }
}