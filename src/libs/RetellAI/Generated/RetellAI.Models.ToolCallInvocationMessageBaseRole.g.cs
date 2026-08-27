
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// This is a tool call invocation.
    /// </summary>
    public enum ToolCallInvocationMessageBaseRole
    {
        /// <summary>
        ///
        /// </summary>
        ToolCallInvocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallInvocationMessageBaseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallInvocationMessageBaseRole value)
        {
            return value switch
            {
                ToolCallInvocationMessageBaseRole.ToolCallInvocation => "tool_call_invocation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallInvocationMessageBaseRole? ToEnum(string value)
        {
            return value switch
            {
                "tool_call_invocation" => ToolCallInvocationMessageBaseRole.ToolCallInvocation,
                _ => null,
            };
        }
    }
}