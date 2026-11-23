
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AsrGroundTruthUtteranceVariant2Role
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
    public static class AsrGroundTruthUtteranceVariant2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsrGroundTruthUtteranceVariant2Role value)
        {
            return value switch
            {
                AsrGroundTruthUtteranceVariant2Role.Agent => "agent",
                AsrGroundTruthUtteranceVariant2Role.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsrGroundTruthUtteranceVariant2Role? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AsrGroundTruthUtteranceVariant2Role.Agent,
                "user" => AsrGroundTruthUtteranceVariant2Role.User,
                _ => null,
            };
        }
    }
}