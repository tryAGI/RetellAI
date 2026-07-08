
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Example: voice
    /// </summary>
    public enum AgentListItemResponseChannel
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
    public static class AgentListItemResponseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentListItemResponseChannel value)
        {
            return value switch
            {
                AgentListItemResponseChannel.Chat => "chat",
                AgentListItemResponseChannel.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentListItemResponseChannel? ToEnum(string value)
        {
            return value switch
            {
                "chat" => AgentListItemResponseChannel.Chat,
                "voice" => AgentListItemResponseChannel.Voice,
                _ => null,
            };
        }
    }
}