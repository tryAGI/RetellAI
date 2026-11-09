
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum EscalateChatNodeVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        EscalateChat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EscalateChatNodeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EscalateChatNodeVariant2Type value)
        {
            return value switch
            {
                EscalateChatNodeVariant2Type.EscalateChat => "escalate_chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EscalateChatNodeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "escalate_chat" => EscalateChatNodeVariant2Type.EscalateChat,
                _ => null,
            };
        }
    }
}