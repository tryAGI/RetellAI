
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Sort chats by `start_timestamp` in ascending or descending order.<br/>
    /// Default Value: descending
    /// </summary>
    public enum ListChatsV3RequestSortOrder
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
    public static class ListChatsV3RequestSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListChatsV3RequestSortOrder value)
        {
            return value switch
            {
                ListChatsV3RequestSortOrder.Ascending => "ascending",
                ListChatsV3RequestSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListChatsV3RequestSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListChatsV3RequestSortOrder.Ascending,
                "descending" => ListChatsV3RequestSortOrder.Descending,
                _ => null,
            };
        }
    }
}