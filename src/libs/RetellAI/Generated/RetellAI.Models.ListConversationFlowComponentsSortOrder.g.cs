
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListConversationFlowComponentsSortOrder
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
    public static class ListConversationFlowComponentsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationFlowComponentsSortOrder value)
        {
            return value switch
            {
                ListConversationFlowComponentsSortOrder.Ascending => "ascending",
                ListConversationFlowComponentsSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationFlowComponentsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListConversationFlowComponentsSortOrder.Ascending,
                "descending" => ListConversationFlowComponentsSortOrder.Descending,
                _ => null,
            };
        }
    }
}