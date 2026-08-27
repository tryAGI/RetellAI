
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentListFilterChannelOp
    {
        /// <summary>
        ///
        /// </summary>
        Eq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentListFilterChannelOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentListFilterChannelOp value)
        {
            return value switch
            {
                AgentListFilterChannelOp.Eq => "eq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentListFilterChannelOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AgentListFilterChannelOp.Eq,
                _ => null,
            };
        }
    }
}