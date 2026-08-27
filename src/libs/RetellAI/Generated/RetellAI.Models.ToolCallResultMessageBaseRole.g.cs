
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// This is the result of a tool call.
    /// </summary>
    public enum ToolCallResultMessageBaseRole
    {
        /// <summary>
        ///
        /// </summary>
        ToolCallResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallResultMessageBaseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallResultMessageBaseRole value)
        {
            return value switch
            {
                ToolCallResultMessageBaseRole.ToolCallResult => "tool_call_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallResultMessageBaseRole? ToEnum(string value)
        {
            return value switch
            {
                "tool_call_result" => ToolCallResultMessageBaseRole.ToolCallResult,
                _ => null,
            };
        }
    }
}