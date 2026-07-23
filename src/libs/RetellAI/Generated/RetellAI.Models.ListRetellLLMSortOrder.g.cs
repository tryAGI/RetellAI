
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListRetellLLMSortOrder
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
    public static class ListRetellLLMSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRetellLLMSortOrder value)
        {
            return value switch
            {
                ListRetellLLMSortOrder.Ascending => "ascending",
                ListRetellLLMSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRetellLLMSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListRetellLLMSortOrder.Ascending,
                "descending" => ListRetellLLMSortOrder.Descending,
                _ => null,
            };
        }
    }
}