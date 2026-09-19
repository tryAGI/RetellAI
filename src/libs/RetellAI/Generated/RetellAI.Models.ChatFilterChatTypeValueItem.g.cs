
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatFilterChatTypeValueItem
    {
        /// <summary>
        ///
        /// </summary>
        ApiChat,
        /// <summary>
        ///
        /// </summary>
        SmsChat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFilterChatTypeValueItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFilterChatTypeValueItem value)
        {
            return value switch
            {
                ChatFilterChatTypeValueItem.ApiChat => "api_chat",
                ChatFilterChatTypeValueItem.SmsChat => "sms_chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFilterChatTypeValueItem? ToEnum(string value)
        {
            return value switch
            {
                "api_chat" => ChatFilterChatTypeValueItem.ApiChat,
                "sms_chat" => ChatFilterChatTypeValueItem.SmsChat,
                _ => null,
            };
        }
    }
}