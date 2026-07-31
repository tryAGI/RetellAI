
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// QA result for a single call within a cohort.
    /// </summary>
    public sealed partial class CallQA
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
        /// Cohort version this QA was created against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohort_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CohortVersion { get; set; }

        /// <summary>
        /// Sum of score weights for passed metrics, ranging from 0 to 100.
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
        /// Analysis of the agent interrupting the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruptions")]
        public global::RetellAI.InterruptionAnalysis? Interruptions { get; set; }

        /// <summary>
        /// Per-utterance sentiment analysis with aggregate counts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_sentiments")]
        public global::RetellAI.SentimentAnalysis? UserSentiments { get; set; }

        /// <summary>
        /// Per-utterance sentiment analysis with aggregate counts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_sentiments")]
        public global::RetellAI.SentimentAnalysis? AgentSentiments { get; set; }

        /// <summary>
        /// Analysis of how natural the agent's speech sounds per utterance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_naturalness_analysis")]
        public global::RetellAI.AgentNaturalnessAnalysis? AgentNaturalnessAnalysis { get; set; }

        /// <summary>
        /// Transcription error analysis for a call, covering mistranscribed important entities and the overall word error rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription_error_analysis")]
        public global::RetellAI.TranscriptionErrorAnalysis? TranscriptionErrorAnalysis { get; set; }

        /// <summary>
        /// Knowledge base retrieval accuracy and recall analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_analysis")]
        public global::RetellAI.RAGAnalysis? RagAnalysis { get; set; }

        /// <summary>
        /// Per-invocation latency and success outcomes for a group of tool calls (e.g. custom tools or transfer calls).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_tool_analysis")]
        public global::RetellAI.ToolCallMetricAnalysis? CustomToolAnalysis { get; set; }

        /// <summary>
        /// Analysis of whether tool calls were made accurately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_analysis")]
        public global::RetellAI.ToolCallAccuracyAnalysis? ToolCallAnalysis { get; set; }

        /// <summary>
        /// Conversation flow node transition accuracy analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_transition_analysis")]
        public global::RetellAI.NodeTransitionAnalysis? NodeTransitionAnalysis { get; set; }

        /// <summary>
        /// Analysis of agent hallucinations across utterances.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_hallucination_analysis")]
        public global::RetellAI.HallucinationAnalysis? LlmHallucinationAnalysis { get; set; }

        /// <summary>
        /// Per-invocation latency and success outcomes for a group of tool calls (e.g. custom tools or transfer calls).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_call_analysis")]
        public global::RetellAI.ToolCallMetricAnalysis? TransferCallAnalysis { get; set; }

        /// <summary>
        /// Summary of why the call did not pass the cohort's success criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.MetricResult> FailedMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.MetricResult> PassedMetrics { get; set; }

        /// <summary>
        /// Questions asked by the user during the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Questions { get; set; }

        /// <summary>
        /// Whether each corresponding question in `questions` was resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question_resolutions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<bool> QuestionResolutions { get; set; }

        /// <summary>
        /// Notes added by the user during calibration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Cluster IDs the call's questions were grouped into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question_clusters")]
        public global::System.Collections.Generic.IList<string>? QuestionClusters { get; set; }

        /// <summary>
        /// Start time of the call (epoch milliseconds).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_start_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CallStartTimeMs { get; set; }

        /// <summary>
        /// Whether QA analysis has completed for this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyzed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Analyzed { get; set; }

        /// <summary>
        /// True if a human reviewed or overrode the automatic scoring; false until a review occurs.
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
        /// Initializes a new instance of the <see cref="CallQA" /> class.
        /// </summary>
        /// <param name="callQaId"></param>
        /// <param name="callId"></param>
        /// <param name="cohortId"></param>
        /// <param name="cohortVersion">
        /// Cohort version this QA was created against.
        /// </param>
        /// <param name="score">
        /// Sum of score weights for passed metrics, ranging from 0 to 100.
        /// </param>
        /// <param name="passed">
        /// Whether the call met the cohort's success criteria.
        /// </param>
        /// <param name="failedMetrics"></param>
        /// <param name="passedMetrics"></param>
        /// <param name="questions">
        /// Questions asked by the user during the call.
        /// </param>
        /// <param name="questionResolutions">
        /// Whether each corresponding question in `questions` was resolved.
        /// </param>
        /// <param name="callStartTimeMs">
        /// Start time of the call (epoch milliseconds).
        /// </param>
        /// <param name="analyzed">
        /// Whether QA analysis has completed for this call.
        /// </param>
        /// <param name="calibrated">
        /// True if a human reviewed or overrode the automatic scoring; false until a review occurs.
        /// </param>
        /// <param name="interruptions">
        /// Analysis of the agent interrupting the user.
        /// </param>
        /// <param name="userSentiments">
        /// Per-utterance sentiment analysis with aggregate counts.
        /// </param>
        /// <param name="agentSentiments">
        /// Per-utterance sentiment analysis with aggregate counts.
        /// </param>
        /// <param name="agentNaturalnessAnalysis">
        /// Analysis of how natural the agent's speech sounds per utterance.
        /// </param>
        /// <param name="transcriptionErrorAnalysis">
        /// Transcription error analysis for a call, covering mistranscribed important entities and the overall word error rate.
        /// </param>
        /// <param name="ragAnalysis">
        /// Knowledge base retrieval accuracy and recall analysis.
        /// </param>
        /// <param name="customToolAnalysis">
        /// Per-invocation latency and success outcomes for a group of tool calls (e.g. custom tools or transfer calls).
        /// </param>
        /// <param name="toolCallAnalysis">
        /// Analysis of whether tool calls were made accurately.
        /// </param>
        /// <param name="nodeTransitionAnalysis">
        /// Conversation flow node transition accuracy analysis.
        /// </param>
        /// <param name="llmHallucinationAnalysis">
        /// Analysis of agent hallucinations across utterances.
        /// </param>
        /// <param name="transferCallAnalysis">
        /// Per-invocation latency and success outcomes for a group of tool calls (e.g. custom tools or transfer calls).
        /// </param>
        /// <param name="failureReason">
        /// Summary of why the call did not pass the cohort's success criteria.
        /// </param>
        /// <param name="notes">
        /// Notes added by the user during calibration.
        /// </param>
        /// <param name="questionClusters">
        /// Cluster IDs the call's questions were grouped into.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallQA(
            string callQaId,
            string callId,
            string cohortId,
            double cohortVersion,
            double score,
            bool passed,
            global::System.Collections.Generic.IList<global::RetellAI.MetricResult> failedMetrics,
            global::System.Collections.Generic.IList<global::RetellAI.MetricResult> passedMetrics,
            global::System.Collections.Generic.IList<string> questions,
            global::System.Collections.Generic.IList<bool> questionResolutions,
            double callStartTimeMs,
            bool analyzed,
            bool calibrated,
            global::RetellAI.InterruptionAnalysis? interruptions,
            global::RetellAI.SentimentAnalysis? userSentiments,
            global::RetellAI.SentimentAnalysis? agentSentiments,
            global::RetellAI.AgentNaturalnessAnalysis? agentNaturalnessAnalysis,
            global::RetellAI.TranscriptionErrorAnalysis? transcriptionErrorAnalysis,
            global::RetellAI.RAGAnalysis? ragAnalysis,
            global::RetellAI.ToolCallMetricAnalysis? customToolAnalysis,
            global::RetellAI.ToolCallAccuracyAnalysis? toolCallAnalysis,
            global::RetellAI.NodeTransitionAnalysis? nodeTransitionAnalysis,
            global::RetellAI.HallucinationAnalysis? llmHallucinationAnalysis,
            global::RetellAI.ToolCallMetricAnalysis? transferCallAnalysis,
            string? failureReason,
            string? notes,
            global::System.Collections.Generic.IList<string>? questionClusters)
        {
            this.CallQaId = callQaId ?? throw new global::System.ArgumentNullException(nameof(callQaId));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.CohortId = cohortId ?? throw new global::System.ArgumentNullException(nameof(cohortId));
            this.CohortVersion = cohortVersion;
            this.Score = score;
            this.Passed = passed;
            this.Interruptions = interruptions;
            this.UserSentiments = userSentiments;
            this.AgentSentiments = agentSentiments;
            this.AgentNaturalnessAnalysis = agentNaturalnessAnalysis;
            this.TranscriptionErrorAnalysis = transcriptionErrorAnalysis;
            this.RagAnalysis = ragAnalysis;
            this.CustomToolAnalysis = customToolAnalysis;
            this.ToolCallAnalysis = toolCallAnalysis;
            this.NodeTransitionAnalysis = nodeTransitionAnalysis;
            this.LlmHallucinationAnalysis = llmHallucinationAnalysis;
            this.TransferCallAnalysis = transferCallAnalysis;
            this.FailureReason = failureReason;
            this.FailedMetrics = failedMetrics ?? throw new global::System.ArgumentNullException(nameof(failedMetrics));
            this.PassedMetrics = passedMetrics ?? throw new global::System.ArgumentNullException(nameof(passedMetrics));
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
            this.QuestionResolutions = questionResolutions ?? throw new global::System.ArgumentNullException(nameof(questionResolutions));
            this.Notes = notes;
            this.QuestionClusters = questionClusters;
            this.CallStartTimeMs = callStartTimeMs;
            this.Analyzed = analyzed;
            this.Calibrated = calibrated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallQA" /> class.
        /// </summary>
        public CallQA()
        {
        }

    }
}