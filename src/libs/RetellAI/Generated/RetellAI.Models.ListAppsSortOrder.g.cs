
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListAppsSortOrder
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
    public static class ListAppsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAppsSortOrder value)
        {
            return value switch
            {
                ListAppsSortOrder.Ascending => "ascending",
                ListAppsSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAppsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListAppsSortOrder.Ascending,
                "descending" => ListAppsSortOrder.Descending,
                _ => null,
            };
        }
    }
}