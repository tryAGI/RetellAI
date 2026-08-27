
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListConversationFlowsSortOrder
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
    public static class ListConversationFlowsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationFlowsSortOrder value)
        {
            return value switch
            {
                ListConversationFlowsSortOrder.Ascending => "ascending",
                ListConversationFlowsSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationFlowsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListConversationFlowsSortOrder.Ascending,
                "descending" => ListConversationFlowsSortOrder.Descending,
                _ => null,
            };
        }
    }
}