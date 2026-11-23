
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AudioTestCaseJobV3Variant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioTestCaseJobV3Variant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTestCaseJobV3Variant2Type value)
        {
            return value switch
            {
                AudioTestCaseJobV3Variant2Type.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTestCaseJobV3Variant2Type? ToEnum(string value)
        {
            return value switch
            {
                "audio" => AudioTestCaseJobV3Variant2Type.Audio,
                _ => null,
            };
        }
    }
}