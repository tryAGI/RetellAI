
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchPhoneNumbersResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchPhoneNumbersResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchPhoneNumbersResponseStatus4 value)
        {
            return value switch
            {
                SearchPhoneNumbersResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchPhoneNumbersResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => SearchPhoneNumbersResponseStatus4.Error,
                _ => null,
            };
        }
    }
}