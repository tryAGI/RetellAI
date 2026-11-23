
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The agent and the simulated caller talk over audio.
    /// </summary>
    public enum AudioTestCaseDefinitionV3InputVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioTestCaseDefinitionV3InputVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTestCaseDefinitionV3InputVariant2Type value)
        {
            return value switch
            {
                AudioTestCaseDefinitionV3InputVariant2Type.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTestCaseDefinitionV3InputVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "audio" => AudioTestCaseDefinitionV3InputVariant2Type.Audio,
                _ => null,
            };
        }
    }
}