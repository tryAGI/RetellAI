
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Sort chats by `start_timestamp` in ascending or descending order.<br/>
    /// Default Value: descending
    /// </summary>
    public enum V3ListChatsRequestSortOrder
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
    public static class V3ListChatsRequestSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V3ListChatsRequestSortOrder value)
        {
            return value switch
            {
                V3ListChatsRequestSortOrder.Ascending => "ascending",
                V3ListChatsRequestSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V3ListChatsRequestSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => V3ListChatsRequestSortOrder.Ascending,
                "descending" => V3ListChatsRequestSortOrder.Descending,
                _ => null,
            };
        }
    }
}