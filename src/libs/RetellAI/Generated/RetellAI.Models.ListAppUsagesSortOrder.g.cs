
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListAppUsagesSortOrder
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
    public static class ListAppUsagesSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAppUsagesSortOrder value)
        {
            return value switch
            {
                ListAppUsagesSortOrder.Ascending => "ascending",
                ListAppUsagesSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAppUsagesSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListAppUsagesSortOrder.Ascending,
                "descending" => ListAppUsagesSortOrder.Descending,
                _ => null,
            };
        }
    }
}