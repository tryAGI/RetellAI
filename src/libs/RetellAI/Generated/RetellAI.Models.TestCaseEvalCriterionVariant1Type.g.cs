
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// An LLM judges the transcript against `prompt`.
    /// </summary>
    public enum TestCaseEvalCriterionVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestCaseEvalCriterionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestCaseEvalCriterionVariant1Type value)
        {
            return value switch
            {
                TestCaseEvalCriterionVariant1Type.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestCaseEvalCriterionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => TestCaseEvalCriterionVariant1Type.Prompt,
                _ => null,
            };
        }
    }
}