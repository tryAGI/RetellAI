
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AsrTestCaseJobV3Variant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Asr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsrTestCaseJobV3Variant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsrTestCaseJobV3Variant2Type value)
        {
            return value switch
            {
                AsrTestCaseJobV3Variant2Type.Asr => "asr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsrTestCaseJobV3Variant2Type? ToEnum(string value)
        {
            return value switch
            {
                "asr" => AsrTestCaseJobV3Variant2Type.Asr,
                _ => null,
            };
        }
    }
}