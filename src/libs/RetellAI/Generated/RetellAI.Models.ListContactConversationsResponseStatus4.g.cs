
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListContactConversationsResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListContactConversationsResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListContactConversationsResponseStatus4 value)
        {
            return value switch
            {
                ListContactConversationsResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListContactConversationsResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListContactConversationsResponseStatus4.Error,
                _ => null,
            };
        }
    }
}