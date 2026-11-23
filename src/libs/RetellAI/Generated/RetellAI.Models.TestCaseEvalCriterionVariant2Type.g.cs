
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Checks a value from the run. Refer to a dynamic variable as `{{variable_name}}`, including ones extracted during the conversation. Refer to a performance metric as `{{metrics.category.field}}`, for example `{{metrics.latency.p50}}`. Use the `exists` operator to check whether a metric was measured.
    /// </summary>
    public enum TestCaseEvalCriterionVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Equation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestCaseEvalCriterionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestCaseEvalCriterionVariant2Type value)
        {
            return value switch
            {
                TestCaseEvalCriterionVariant2Type.Equation => "equation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestCaseEvalCriterionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "equation" => TestCaseEvalCriterionVariant2Type.Equation,
                _ => null,
            };
        }
    }
}