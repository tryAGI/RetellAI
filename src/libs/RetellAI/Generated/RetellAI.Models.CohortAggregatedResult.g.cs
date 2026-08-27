
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Aggregated QA metrics across all scored calls in a cohort, bucketed into a time series.
    /// </summary>
    public sealed partial class CohortAggregatedResult
    {
        /// <summary>
        /// Total calls sampled into the cohort over the time series, including those not yet analyzed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCalls { get; set; }

        /// <summary>
        /// Number of calls that have completed QA analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls_analysed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CallsAnalysed { get; set; }

        /// <summary>
        /// Start timestamp of each time bucket in the series, in the requested timezone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timepoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Timepoints { get; set; }

        /// <summary>
        /// Granularity used to bucket the time series.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CohortAggregatedResultGroupByJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.CohortAggregatedResultGroupBy GroupBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AverageMetric AvgScore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_resolution_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AverageMetric CallResolutionRate { get; set; }

        /// <summary>
        /// Most common question clusters and their resolution counts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.CohortAggregatedResultTopQuestion> TopQuestions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AverageMetric Latency { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_hallucination_analysis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AverageMetric LlmHallucinationAnalysis { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_analysis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AverageMetric RagAnalysis { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_sentiment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.BreakdownMetric UserSentiment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_sentiment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.BreakdownMetric AgentSentiment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_success_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AverageMetric TransferSuccessRate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_wait_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AverageMetric TransferWaitTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AverageMetric Wer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_interruption")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AverageMetric AvgInterruption { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_accuracy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AverageMetric ToolCallAccuracy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_accuracy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AverageMetric TransitionAccuracy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("natural_tonality_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AverageMetric NaturalTonalityRate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_tool_call_latency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AverageMetric CustomToolCallLatency { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_tool_call_success_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AverageMetric CustomToolCallSuccessRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortAggregatedResult" /> class.
        /// </summary>
        /// <param name="totalCalls">
        /// Total calls sampled into the cohort over the time series, including those not yet analyzed.
        /// </param>
        /// <param name="callsAnalysed">
        /// Number of calls that have completed QA analysis.
        /// </param>
        /// <param name="timepoints">
        /// Start timestamp of each time bucket in the series, in the requested timezone.
        /// </param>
        /// <param name="groupBy">
        /// Granularity used to bucket the time series.
        /// </param>
        /// <param name="avgScore"></param>
        /// <param name="callResolutionRate"></param>
        /// <param name="topQuestions">
        /// Most common question clusters and their resolution counts.
        /// </param>
        /// <param name="latency"></param>
        /// <param name="llmHallucinationAnalysis"></param>
        /// <param name="ragAnalysis"></param>
        /// <param name="userSentiment"></param>
        /// <param name="agentSentiment"></param>
        /// <param name="transferSuccessRate"></param>
        /// <param name="transferWaitTime"></param>
        /// <param name="wer"></param>
        /// <param name="avgInterruption"></param>
        /// <param name="toolCallAccuracy"></param>
        /// <param name="transitionAccuracy"></param>
        /// <param name="naturalTonalityRate"></param>
        /// <param name="customToolCallLatency"></param>
        /// <param name="customToolCallSuccessRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CohortAggregatedResult(
            double totalCalls,
            double callsAnalysed,
            global::System.Collections.Generic.IList<double> timepoints,
            global::RetellAI.CohortAggregatedResultGroupBy groupBy,
            global::RetellAI.AverageMetric avgScore,
            global::RetellAI.AverageMetric callResolutionRate,
            global::System.Collections.Generic.IList<global::RetellAI.CohortAggregatedResultTopQuestion> topQuestions,
            global::RetellAI.AverageMetric latency,
            global::RetellAI.AverageMetric llmHallucinationAnalysis,
            global::RetellAI.AverageMetric ragAnalysis,
            global::RetellAI.BreakdownMetric userSentiment,
            global::RetellAI.BreakdownMetric agentSentiment,
            global::RetellAI.AverageMetric transferSuccessRate,
            global::RetellAI.AverageMetric transferWaitTime,
            global::RetellAI.AverageMetric wer,
            global::RetellAI.AverageMetric avgInterruption,
            global::RetellAI.AverageMetric toolCallAccuracy,
            global::RetellAI.AverageMetric transitionAccuracy,
            global::RetellAI.AverageMetric naturalTonalityRate,
            global::RetellAI.AverageMetric customToolCallLatency,
            global::RetellAI.AverageMetric customToolCallSuccessRate)
        {
            this.TotalCalls = totalCalls;
            this.CallsAnalysed = callsAnalysed;
            this.Timepoints = timepoints ?? throw new global::System.ArgumentNullException(nameof(timepoints));
            this.GroupBy = groupBy;
            this.AvgScore = avgScore ?? throw new global::System.ArgumentNullException(nameof(avgScore));
            this.CallResolutionRate = callResolutionRate ?? throw new global::System.ArgumentNullException(nameof(callResolutionRate));
            this.TopQuestions = topQuestions ?? throw new global::System.ArgumentNullException(nameof(topQuestions));
            this.Latency = latency ?? throw new global::System.ArgumentNullException(nameof(latency));
            this.LlmHallucinationAnalysis = llmHallucinationAnalysis ?? throw new global::System.ArgumentNullException(nameof(llmHallucinationAnalysis));
            this.RagAnalysis = ragAnalysis ?? throw new global::System.ArgumentNullException(nameof(ragAnalysis));
            this.UserSentiment = userSentiment ?? throw new global::System.ArgumentNullException(nameof(userSentiment));
            this.AgentSentiment = agentSentiment ?? throw new global::System.ArgumentNullException(nameof(agentSentiment));
            this.TransferSuccessRate = transferSuccessRate ?? throw new global::System.ArgumentNullException(nameof(transferSuccessRate));
            this.TransferWaitTime = transferWaitTime ?? throw new global::System.ArgumentNullException(nameof(transferWaitTime));
            this.Wer = wer ?? throw new global::System.ArgumentNullException(nameof(wer));
            this.AvgInterruption = avgInterruption ?? throw new global::System.ArgumentNullException(nameof(avgInterruption));
            this.ToolCallAccuracy = toolCallAccuracy ?? throw new global::System.ArgumentNullException(nameof(toolCallAccuracy));
            this.TransitionAccuracy = transitionAccuracy ?? throw new global::System.ArgumentNullException(nameof(transitionAccuracy));
            this.NaturalTonalityRate = naturalTonalityRate ?? throw new global::System.ArgumentNullException(nameof(naturalTonalityRate));
            this.CustomToolCallLatency = customToolCallLatency ?? throw new global::System.ArgumentNullException(nameof(customToolCallLatency));
            this.CustomToolCallSuccessRate = customToolCallSuccessRate ?? throw new global::System.ArgumentNullException(nameof(customToolCallSuccessRate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortAggregatedResult" /> class.
        /// </summary>
        public CohortAggregatedResult()
        {
        }

    }
}