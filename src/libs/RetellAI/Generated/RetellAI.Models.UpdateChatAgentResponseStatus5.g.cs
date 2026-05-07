
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateChatAgentResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateChatAgentResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateChatAgentResponseStatus5 value)
        {
            return value switch
            {
                UpdateChatAgentResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateChatAgentResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateChatAgentResponseStatus5.Error,
                _ => null,
            };
        }
    }
}