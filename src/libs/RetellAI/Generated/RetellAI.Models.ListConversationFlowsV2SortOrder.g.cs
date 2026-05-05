
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListConversationFlowsV2SortOrder
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
    public static class ListConversationFlowsV2SortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationFlowsV2SortOrder value)
        {
            return value switch
            {
                ListConversationFlowsV2SortOrder.Ascending => "ascending",
                ListConversationFlowsV2SortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationFlowsV2SortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListConversationFlowsV2SortOrder.Ascending,
                "descending" => ListConversationFlowsV2SortOrder.Descending,
                _ => null,
            };
        }
    }
}