
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListContactConversationsResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListContactConversationsResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListContactConversationsResponseStatus3 value)
        {
            return value switch
            {
                ListContactConversationsResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListContactConversationsResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListContactConversationsResponseStatus3.Error,
                _ => null,
            };
        }
    }
}