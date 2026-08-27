
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Sort contacts by `last_conversation_timestamp` in ascending or descending order. Contacts that have never been contacted sort as if their timestamp were 0.<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListContactsRequestSortOrder
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListContactsRequestSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListContactsRequestSortOrder value)
        {
            return value switch
            {
                ListContactsRequestSortOrder.Asc => "asc",
                ListContactsRequestSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListContactsRequestSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListContactsRequestSortOrder.Asc,
                "desc" => ListContactsRequestSortOrder.Desc,
                _ => null,
            };
        }
    }
}