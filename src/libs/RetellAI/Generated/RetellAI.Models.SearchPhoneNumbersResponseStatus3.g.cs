
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchPhoneNumbersResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchPhoneNumbersResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchPhoneNumbersResponseStatus3 value)
        {
            return value switch
            {
                SearchPhoneNumbersResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchPhoneNumbersResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => SearchPhoneNumbersResponseStatus3.Error,
                _ => null,
            };
        }
    }
}