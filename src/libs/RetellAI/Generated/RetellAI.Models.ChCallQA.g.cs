
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Condensed QA summary returned when listing a cohort's calls.
    /// </summary>
    public sealed partial class ChCallQA
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_qa_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallQaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohort_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CohortId { get; set; }

        /// <summary>
        /// Call start time in epoch milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_start_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CallStartTimeMs { get; set; }

        /// <summary>
        /// Weighted QA score from 0 to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Whether the call met the cohort's success criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// Number of times the agent interrupted the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption_count")]
        public double? InterruptionCount { get; set; }

        /// <summary>
        /// Fraction of evaluated agent utterances with hallucinations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_hallucination_rate")]
        public double? LlmHallucinationRate { get; set; }

        /// <summary>
        /// Fraction of evaluated retrievals with full chunk recall.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kb_recall")]
        public double? KbRecall { get; set; }

        /// <summary>
        /// Fraction of evaluated node transitions that were correct.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_accuracy")]
        public double? TransitionAccuracy { get; set; }

        /// <summary>
        /// Fraction of evaluated user utterances with positive sentiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_positive_sentiment_rate")]
        public double? UserPositiveSentimentRate { get; set; }

        /// <summary>
        /// Fraction of evaluated user utterances with negative sentiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_negative_sentiment_rate")]
        public double? UserNegativeSentimentRate { get; set; }

        /// <summary>
        /// Word error rate of the call transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wer")]
        public double? Wer { get; set; }

        /// <summary>
        /// Fraction of evaluated tool-call utterances that were accurate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_accuracy")]
        public double? ToolCallAccuracy { get; set; }

        /// <summary>
        /// Fraction of evaluated agent utterances judged natural.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("natural_tonality_rate")]
        public double? NaturalTonalityRate { get; set; }

        /// <summary>
        /// Whether the QA was reviewed by a human.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calibrated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Calibrated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChCallQA" /> class.
        /// </summary>
        /// <param name="callQaId"></param>
        /// <param name="callId"></param>
        /// <param name="cohortId"></param>
        /// <param name="callStartTimeMs">
        /// Call start time in epoch milliseconds.
        /// </param>
        /// <param name="score">
        /// Weighted QA score from 0 to 100.
        /// </param>
        /// <param name="passed">
        /// Whether the call met the cohort's success criteria.
        /// </param>
        /// <param name="calibrated">
        /// Whether the QA was reviewed by a human.
        /// </param>
        /// <param name="interruptionCount">
        /// Number of times the agent interrupted the user.
        /// </param>
        /// <param name="llmHallucinationRate">
        /// Fraction of evaluated agent utterances with hallucinations.
        /// </param>
        /// <param name="kbRecall">
        /// Fraction of evaluated retrievals with full chunk recall.
        /// </param>
        /// <param name="transitionAccuracy">
        /// Fraction of evaluated node transitions that were correct.
        /// </param>
        /// <param name="userPositiveSentimentRate">
        /// Fraction of evaluated user utterances with positive sentiment.
        /// </param>
        /// <param name="userNegativeSentimentRate">
        /// Fraction of evaluated user utterances with negative sentiment.
        /// </param>
        /// <param name="wer">
        /// Word error rate of the call transcript.
        /// </param>
        /// <param name="toolCallAccuracy">
        /// Fraction of evaluated tool-call utterances that were accurate.
        /// </param>
        /// <param name="naturalTonalityRate">
        /// Fraction of evaluated agent utterances judged natural.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChCallQA(
            string callQaId,
            string callId,
            string cohortId,
            double callStartTimeMs,
            double score,
            bool passed,
            bool calibrated,
            double? interruptionCount,
            double? llmHallucinationRate,
            double? kbRecall,
            double? transitionAccuracy,
            double? userPositiveSentimentRate,
            double? userNegativeSentimentRate,
            double? wer,
            double? toolCallAccuracy,
            double? naturalTonalityRate)
        {
            this.CallQaId = callQaId ?? throw new global::System.ArgumentNullException(nameof(callQaId));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.CohortId = cohortId ?? throw new global::System.ArgumentNullException(nameof(cohortId));
            this.CallStartTimeMs = callStartTimeMs;
            this.Score = score;
            this.Passed = passed;
            this.InterruptionCount = interruptionCount;
            this.LlmHallucinationRate = llmHallucinationRate;
            this.KbRecall = kbRecall;
            this.TransitionAccuracy = transitionAccuracy;
            this.UserPositiveSentimentRate = userPositiveSentimentRate;
            this.UserNegativeSentimentRate = userNegativeSentimentRate;
            this.Wer = wer;
            this.ToolCallAccuracy = toolCallAccuracy;
            this.NaturalTonalityRate = naturalTonalityRate;
            this.Calibrated = calibrated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChCallQA" /> class.
        /// </summary>
        public ChCallQA()
        {
        }

    }
}