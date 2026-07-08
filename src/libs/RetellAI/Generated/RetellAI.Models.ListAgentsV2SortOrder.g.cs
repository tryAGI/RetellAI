
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListAgentsV2SortOrder
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
    public static class ListAgentsV2SortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentsV2SortOrder value)
        {
            return value switch
            {
                ListAgentsV2SortOrder.Ascending => "ascending",
                ListAgentsV2SortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentsV2SortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListAgentsV2SortOrder.Ascending,
                "descending" => ListAgentsV2SortOrder.Descending,
                _ => null,
            };
        }
    }
}