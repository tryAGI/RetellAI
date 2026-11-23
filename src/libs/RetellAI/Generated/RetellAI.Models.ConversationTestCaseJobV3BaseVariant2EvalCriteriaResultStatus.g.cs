
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus
    {
        /// <summary>
        ///
        /// </summary>
        Fail,
        /// <summary>
        ///
        /// </summary>
        Pass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus value)
        {
            return value switch
            {
                ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus.Fail => "fail",
                ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus.Pass => "pass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "fail" => ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus.Fail,
                "pass" => ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus.Pass,
                _ => null,
            };
        }
    }
}