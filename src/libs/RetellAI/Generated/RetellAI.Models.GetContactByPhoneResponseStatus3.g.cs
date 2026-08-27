
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum GetContactByPhoneResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetContactByPhoneResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContactByPhoneResponseStatus3 value)
        {
            return value switch
            {
                GetContactByPhoneResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContactByPhoneResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetContactByPhoneResponseStatus3.Error,
                _ => null,
            };
        }
    }
}