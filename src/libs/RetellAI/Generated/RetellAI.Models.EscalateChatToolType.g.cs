
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum EscalateChatToolType
    {
        /// <summary>
        ///
        /// </summary>
        EscalateChat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EscalateChatToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EscalateChatToolType value)
        {
            return value switch
            {
                EscalateChatToolType.EscalateChat => "escalate_chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EscalateChatToolType? ToEnum(string value)
        {
            return value switch
            {
                "escalate_chat" => EscalateChatToolType.EscalateChat,
                _ => null,
            };
        }
    }
}