
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentPlaygroundCompletionResponseStatus6
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPlaygroundCompletionResponseStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPlaygroundCompletionResponseStatus6 value)
        {
            return value switch
            {
                AgentPlaygroundCompletionResponseStatus6.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPlaygroundCompletionResponseStatus6? ToEnum(string value)
        {
            return value switch
            {
                "error" => AgentPlaygroundCompletionResponseStatus6.Error,
                _ => null,
            };
        }
    }
}