
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Field to sort by. Defaults to "score".
    /// </summary>
    public enum CohortQaListArgsSortKey
    {
        /// <summary>
        ///
        /// </summary>
        CallId,
        /// <summary>
        ///
        /// </summary>
        DurationMs,
        /// <summary>
        ///
        /// </summary>
        E2eLatencyP50,
        /// <summary>
        ///
        /// </summary>
        InterruptionCount,
        /// <summary>
        ///
        /// </summary>
        KbRecall,
        /// <summary>
        ///
        /// </summary>
        LlmHallucinationRate,
        /// <summary>
        ///
        /// </summary>
        NaturalTonalityRate,
        /// <summary>
        ///
        /// </summary>
        Score,
        /// <summary>
        ///
        /// </summary>
        ToolCallAccuracy,
        /// <summary>
        ///
        /// </summary>
        TransitionAccuracy,
        /// <summary>
        ///
        /// </summary>
        UserNegativeSentimentRate,
        /// <summary>
        ///
        /// </summary>
        UserPositiveSentimentRate,
        /// <summary>
        ///
        /// </summary>
        Wer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CohortQaListArgsSortKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CohortQaListArgsSortKey value)
        {
            return value switch
            {
                CohortQaListArgsSortKey.CallId => "call_id",
                CohortQaListArgsSortKey.DurationMs => "duration_ms",
                CohortQaListArgsSortKey.E2eLatencyP50 => "e2e_latency_p50",
                CohortQaListArgsSortKey.InterruptionCount => "interruption_count",
                CohortQaListArgsSortKey.KbRecall => "kb_recall",
                CohortQaListArgsSortKey.LlmHallucinationRate => "llm_hallucination_rate",
                CohortQaListArgsSortKey.NaturalTonalityRate => "natural_tonality_rate",
                CohortQaListArgsSortKey.Score => "score",
                CohortQaListArgsSortKey.ToolCallAccuracy => "tool_call_accuracy",
                CohortQaListArgsSortKey.TransitionAccuracy => "transition_accuracy",
                CohortQaListArgsSortKey.UserNegativeSentimentRate => "user_negative_sentiment_rate",
                CohortQaListArgsSortKey.UserPositiveSentimentRate => "user_positive_sentiment_rate",
                CohortQaListArgsSortKey.Wer => "wer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CohortQaListArgsSortKey? ToEnum(string value)
        {
            return value switch
            {
                "call_id" => CohortQaListArgsSortKey.CallId,
                "duration_ms" => CohortQaListArgsSortKey.DurationMs,
                "e2e_latency_p50" => CohortQaListArgsSortKey.E2eLatencyP50,
                "interruption_count" => CohortQaListArgsSortKey.InterruptionCount,
                "kb_recall" => CohortQaListArgsSortKey.KbRecall,
                "llm_hallucination_rate" => CohortQaListArgsSortKey.LlmHallucinationRate,
                "natural_tonality_rate" => CohortQaListArgsSortKey.NaturalTonalityRate,
                "score" => CohortQaListArgsSortKey.Score,
                "tool_call_accuracy" => CohortQaListArgsSortKey.ToolCallAccuracy,
                "transition_accuracy" => CohortQaListArgsSortKey.TransitionAccuracy,
                "user_negative_sentiment_rate" => CohortQaListArgsSortKey.UserNegativeSentimentRate,
                "user_positive_sentiment_rate" => CohortQaListArgsSortKey.UserPositiveSentimentRate,
                "wer" => CohortQaListArgsSortKey.Wer,
                _ => null,
            };
        }
    }
}