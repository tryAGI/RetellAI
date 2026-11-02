
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Documents whether this utterance is spoken by agent or user.<br/>
    /// Example: agent
    /// </summary>
    public enum TextUtteranceRole
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        TransferTarget,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextUtteranceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextUtteranceRole value)
        {
            return value switch
            {
                TextUtteranceRole.Agent => "agent",
                TextUtteranceRole.TransferTarget => "transfer_target",
                TextUtteranceRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextUtteranceRole? ToEnum(string value)
        {
            return value switch
            {
                "agent" => TextUtteranceRole.Agent,
                "transfer_target" => TextUtteranceRole.TransferTarget,
                "user" => TextUtteranceRole.User,
                _ => null,
            };
        }
    }
}