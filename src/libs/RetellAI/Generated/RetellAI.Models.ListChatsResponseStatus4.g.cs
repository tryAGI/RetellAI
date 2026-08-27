
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListChatsResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListChatsResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListChatsResponseStatus4 value)
        {
            return value switch
            {
                ListChatsResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListChatsResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListChatsResponseStatus4.Error,
                _ => null,
            };
        }
    }
}