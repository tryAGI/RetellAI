
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Documents whether this message is sent by agent or user.<br/>
    /// Example: agent
    /// </summary>
    public enum MessageBaseRole
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageBaseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageBaseRole value)
        {
            return value switch
            {
                MessageBaseRole.Agent => "agent",
                MessageBaseRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageBaseRole? ToEnum(string value)
        {
            return value switch
            {
                "agent" => MessageBaseRole.Agent,
                "user" => MessageBaseRole.User,
                _ => null,
            };
        }
    }
}