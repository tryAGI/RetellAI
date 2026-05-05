
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListRetellLLMV2SortOrder
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
    public static class ListRetellLLMV2SortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRetellLLMV2SortOrder value)
        {
            return value switch
            {
                ListRetellLLMV2SortOrder.Ascending => "ascending",
                ListRetellLLMV2SortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRetellLLMV2SortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListRetellLLMV2SortOrder.Ascending,
                "descending" => ListRetellLLMV2SortOrder.Descending,
                _ => null,
            };
        }
    }
}