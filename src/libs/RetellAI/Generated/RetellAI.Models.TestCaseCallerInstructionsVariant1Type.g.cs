
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The simulated caller is an LLM that follows `user_prompt`.
    /// </summary>
    public enum TestCaseCallerInstructionsVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        UserPrompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestCaseCallerInstructionsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestCaseCallerInstructionsVariant1Type value)
        {
            return value switch
            {
                TestCaseCallerInstructionsVariant1Type.UserPrompt => "user_prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestCaseCallerInstructionsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "user_prompt" => TestCaseCallerInstructionsVariant1Type.UserPrompt,
                _ => null,
            };
        }
    }
}