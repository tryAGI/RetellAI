
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Direction of the chat.
    /// </summary>
    public enum ContactChatDirection
    {
        /// <summary>
        ///
        /// </summary>
        Inbound,
        /// <summary>
        ///
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContactChatDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContactChatDirection value)
        {
            return value switch
            {
                ContactChatDirection.Inbound => "inbound",
                ContactChatDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContactChatDirection? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => ContactChatDirection.Inbound,
                "outbound" => ContactChatDirection.Outbound,
                _ => null,
            };
        }
    }
}