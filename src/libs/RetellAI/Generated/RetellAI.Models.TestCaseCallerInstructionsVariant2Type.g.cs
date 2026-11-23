
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The simulated caller follows the user turns of `transcript`. It adapts to the live agent's questions while preserving the caller's wording, facts, and intent.
    /// </summary>
    public enum TestCaseCallerInstructionsVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestCaseCallerInstructionsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestCaseCallerInstructionsVariant2Type value)
        {
            return value switch
            {
                TestCaseCallerInstructionsVariant2Type.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestCaseCallerInstructionsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "transcript" => TestCaseCallerInstructionsVariant2Type.Transcript,
                _ => null,
            };
        }
    }
}