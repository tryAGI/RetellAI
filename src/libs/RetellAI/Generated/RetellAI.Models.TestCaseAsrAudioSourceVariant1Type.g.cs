
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Audio from an uploaded file.
    /// </summary>
    public enum TestCaseAsrAudioSourceVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Upload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestCaseAsrAudioSourceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestCaseAsrAudioSourceVariant1Type value)
        {
            return value switch
            {
                TestCaseAsrAudioSourceVariant1Type.Upload => "upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestCaseAsrAudioSourceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "upload" => TestCaseAsrAudioSourceVariant1Type.Upload,
                _ => null,
            };
        }
    }
}