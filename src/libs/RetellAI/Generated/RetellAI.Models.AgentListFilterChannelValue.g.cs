
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentListFilterChannelValue
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentListFilterChannelValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentListFilterChannelValue value)
        {
            return value switch
            {
                AgentListFilterChannelValue.Chat => "chat",
                AgentListFilterChannelValue.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentListFilterChannelValue? ToEnum(string value)
        {
            return value switch
            {
                "chat" => AgentListFilterChannelValue.Chat,
                "voice" => AgentListFilterChannelValue.Voice,
                _ => null,
            };
        }
    }
}