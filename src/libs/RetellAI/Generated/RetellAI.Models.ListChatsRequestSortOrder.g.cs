
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Sort chats by `start_timestamp` in ascending or descending order.<br/>
    /// Default Value: descending
    /// </summary>
    public enum ListChatsRequestSortOrder
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
    public static class ListChatsRequestSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListChatsRequestSortOrder value)
        {
            return value switch
            {
                ListChatsRequestSortOrder.Ascending => "ascending",
                ListChatsRequestSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListChatsRequestSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListChatsRequestSortOrder.Ascending,
                "descending" => ListChatsRequestSortOrder.Descending,
                _ => null,
            };
        }
    }
}