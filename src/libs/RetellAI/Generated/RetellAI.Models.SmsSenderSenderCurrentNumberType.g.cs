
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SmsSenderSenderCurrentNumberType
    {
        /// <summary>
        ///
        /// </summary>
        CurrentNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsSenderSenderCurrentNumberTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsSenderSenderCurrentNumberType value)
        {
            return value switch
            {
                SmsSenderSenderCurrentNumberType.CurrentNumber => "current_number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsSenderSenderCurrentNumberType? ToEnum(string value)
        {
            return value switch
            {
                "current_number" => SmsSenderSenderCurrentNumberType.CurrentNumber,
                _ => null,
            };
        }
    }
}