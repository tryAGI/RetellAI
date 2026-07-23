
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListPhoneNumbersSortOrder
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
    public static class ListPhoneNumbersSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPhoneNumbersSortOrder value)
        {
            return value switch
            {
                ListPhoneNumbersSortOrder.Ascending => "ascending",
                ListPhoneNumbersSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPhoneNumbersSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListPhoneNumbersSortOrder.Ascending,
                "descending" => ListPhoneNumbersSortOrder.Descending,
                _ => null,
            };
        }
    }
}