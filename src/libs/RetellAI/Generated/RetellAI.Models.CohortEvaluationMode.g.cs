
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// "default" requires every condition and metric to pass; "weighted" allows a lower `successful_criteria` threshold, so a call can pass without meeting every one.
    /// </summary>
    public enum CohortEvaluationMode
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Weighted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CohortEvaluationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CohortEvaluationMode value)
        {
            return value switch
            {
                CohortEvaluationMode.Default => "default",
                CohortEvaluationMode.Weighted => "weighted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CohortEvaluationMode? ToEnum(string value)
        {
            return value switch
            {
                "default" => CohortEvaluationMode.Default,
                "weighted" => CohortEvaluationMode.Weighted,
                _ => null,
            };
        }
    }
}