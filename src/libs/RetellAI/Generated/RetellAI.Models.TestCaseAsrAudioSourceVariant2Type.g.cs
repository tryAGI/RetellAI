
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Audio from part of an existing call's multichannel recording. The source call must have PII scrubbing disabled.
    /// </summary>
    public enum TestCaseAsrAudioSourceVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        CallClip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestCaseAsrAudioSourceVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestCaseAsrAudioSourceVariant2Type value)
        {
            return value switch
            {
                TestCaseAsrAudioSourceVariant2Type.CallClip => "call_clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestCaseAsrAudioSourceVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "call_clip" => TestCaseAsrAudioSourceVariant2Type.CallClip,
                _ => null,
            };
        }
    }
}