
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentPlaygroundCompletionResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPlaygroundCompletionResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPlaygroundCompletionResponseStatus2 value)
        {
            return value switch
            {
                AgentPlaygroundCompletionResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPlaygroundCompletionResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => AgentPlaygroundCompletionResponseStatus2.Error,
                _ => null,
            };
        }
    }
}