
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchPhoneNumbersResponseStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchPhoneNumbersResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchPhoneNumbersResponseStatus2 value)
        {
            return value switch
            {
                SearchPhoneNumbersResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchPhoneNumbersResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => SearchPhoneNumbersResponseStatus2.Error,
                _ => null,
            };
        }
    }
}