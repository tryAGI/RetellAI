
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Type of the node
    /// </summary>
    public enum SubagentNodeVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Subagent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubagentNodeVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubagentNodeVariant3Type value)
        {
            return value switch
            {
                SubagentNodeVariant3Type.Subagent => "subagent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubagentNodeVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "subagent" => SubagentNodeVariant3Type.Subagent,
                _ => null,
            };
        }
    }
}