
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum SearchPhoneNumbersSortOrder
    {
        /// <summary>
        ///
        /// </summary>
        Ascending,
        /// <summary>
        ///
        /// </summary>
        Descending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchPhoneNumbersSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchPhoneNumbersSortOrder value)
        {
            return value switch
            {
                SearchPhoneNumbersSortOrder.Ascending => "ascending",
                SearchPhoneNumbersSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchPhoneNumbersSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => SearchPhoneNumbersSortOrder.Ascending,
                "descending" => SearchPhoneNumbersSortOrder.Descending,
                _ => null,
            };
        }
    }
}