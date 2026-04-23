
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentPlaygroundCompletionResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPlaygroundCompletionResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPlaygroundCompletionResponseStatus3 value)
        {
            return value switch
            {
                AgentPlaygroundCompletionResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPlaygroundCompletionResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => AgentPlaygroundCompletionResponseStatus3.Error,
                _ => null,
            };
        }
    }
}