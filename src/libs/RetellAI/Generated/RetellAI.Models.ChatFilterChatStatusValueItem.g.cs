
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatFilterChatStatusValueItem
    {
        /// <summary>
        ///
        /// </summary>
        Ended,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Ongoing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFilterChatStatusValueItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFilterChatStatusValueItem value)
        {
            return value switch
            {
                ChatFilterChatStatusValueItem.Ended => "ended",
                ChatFilterChatStatusValueItem.Error => "error",
                ChatFilterChatStatusValueItem.Ongoing => "ongoing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFilterChatStatusValueItem? ToEnum(string value)
        {
            return value switch
            {
                "ended" => ChatFilterChatStatusValueItem.Ended,
                "error" => ChatFilterChatStatusValueItem.Error,
                "ongoing" => ChatFilterChatStatusValueItem.Ongoing,
                _ => null,
            };
        }
    }
}