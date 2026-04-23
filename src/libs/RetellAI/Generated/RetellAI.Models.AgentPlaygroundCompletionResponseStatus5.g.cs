
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentPlaygroundCompletionResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPlaygroundCompletionResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPlaygroundCompletionResponseStatus5 value)
        {
            return value switch
            {
                AgentPlaygroundCompletionResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPlaygroundCompletionResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => AgentPlaygroundCompletionResponseStatus5.Error,
                _ => null,
            };
        }
    }
}