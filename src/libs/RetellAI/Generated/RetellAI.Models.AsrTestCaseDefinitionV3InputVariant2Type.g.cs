
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Transcribes audio with the agent's speech recognition settings and compares it to `ground_truth`.
    /// </summary>
    public enum AsrTestCaseDefinitionV3InputVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Asr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsrTestCaseDefinitionV3InputVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsrTestCaseDefinitionV3InputVariant2Type value)
        {
            return value switch
            {
                AsrTestCaseDefinitionV3InputVariant2Type.Asr => "asr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsrTestCaseDefinitionV3InputVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "asr" => AsrTestCaseDefinitionV3InputVariant2Type.Asr,
                _ => null,
            };
        }
    }
}