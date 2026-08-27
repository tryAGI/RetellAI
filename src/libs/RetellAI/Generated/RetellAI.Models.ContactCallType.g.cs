
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ContactCallType
    {
        /// <summary>
        ///
        /// </summary>
        Call,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContactCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContactCallType value)
        {
            return value switch
            {
                ContactCallType.Call => "call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContactCallType? ToEnum(string value)
        {
            return value switch
            {
                "call" => ContactCallType.Call,
                _ => null,
            };
        }
    }
}