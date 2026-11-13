
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchPhoneNumbersResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchPhoneNumbersResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchPhoneNumbersResponseStatus value)
        {
            return value switch
            {
                SearchPhoneNumbersResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchPhoneNumbersResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => SearchPhoneNumbersResponseStatus.Error,
                _ => null,
            };
        }
    }
}