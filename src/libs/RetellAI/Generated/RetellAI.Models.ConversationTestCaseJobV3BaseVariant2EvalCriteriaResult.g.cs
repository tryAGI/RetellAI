
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationTestCaseJobV3BaseVariant2EvalCriteriaResult
    {
        /// <summary>
        /// Position of the criterion in `definition_snapshot.eval_criteria`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MetricIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus Status { get; set; }

        /// <summary>
        /// Why the criterion passed or failed. Only set for prompt-based criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTestCaseJobV3BaseVariant2EvalCriteriaResult" /> class.
        /// </summary>
        /// <param name="metricIndex">
        /// Position of the criterion in `definition_snapshot.eval_criteria`.
        /// </param>
        /// <param name="status"></param>
        /// <param name="reason">
        /// Why the criterion passed or failed. Only set for prompt-based criteria.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationTestCaseJobV3BaseVariant2EvalCriteriaResult(
            int metricIndex,
            global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResultStatus status,
            string? reason)
        {
            this.MetricIndex = metricIndex;
            this.Status = status;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTestCaseJobV3BaseVariant2EvalCriteriaResult" /> class.
        /// </summary>
        public ConversationTestCaseJobV3BaseVariant2EvalCriteriaResult()
        {
        }

    }
}