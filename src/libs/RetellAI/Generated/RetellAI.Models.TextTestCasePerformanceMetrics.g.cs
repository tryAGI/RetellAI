
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Performance metrics measured during the run. Paid metrics are only present when listed in the test case's `enabled_performance_metrics`.
    /// </summary>
    public sealed partial class TextTestCasePerformanceMetrics
    {
        /// <summary>
        /// Free.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_tool_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.TextTestCasePerformanceMetricsCustomToolError CustomToolError { get; set; }

        /// <summary>
        /// Paid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_hallucination")]
        public global::RetellAI.TextTestCasePerformanceMetricsAgentHallucination? AgentHallucination { get; set; }

        /// <summary>
        /// Paid. Only for conversation flow agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_transition_inaccuracy")]
        public global::RetellAI.TextTestCasePerformanceMetricsNodeTransitionInaccuracy? NodeTransitionInaccuracy { get; set; }

        /// <summary>
        /// Knowledge base retrievals. Paid. Omitted when nothing was retrieved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_accuracy")]
        public global::RetellAI.TextTestCasePerformanceMetricsRagAccuracy? RagAccuracy { get; set; }

        /// <summary>
        /// Paid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_inaccuracy")]
        public global::RetellAI.TextTestCasePerformanceMetricsToolCallInaccuracy? ToolCallInaccuracy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTestCasePerformanceMetrics" /> class.
        /// </summary>
        /// <param name="customToolError">
        /// Free.
        /// </param>
        /// <param name="agentHallucination">
        /// Paid.
        /// </param>
        /// <param name="nodeTransitionInaccuracy">
        /// Paid. Only for conversation flow agents.
        /// </param>
        /// <param name="ragAccuracy">
        /// Knowledge base retrievals. Paid. Omitted when nothing was retrieved.
        /// </param>
        /// <param name="toolCallInaccuracy">
        /// Paid.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextTestCasePerformanceMetrics(
            global::RetellAI.TextTestCasePerformanceMetricsCustomToolError customToolError,
            global::RetellAI.TextTestCasePerformanceMetricsAgentHallucination? agentHallucination,
            global::RetellAI.TextTestCasePerformanceMetricsNodeTransitionInaccuracy? nodeTransitionInaccuracy,
            global::RetellAI.TextTestCasePerformanceMetricsRagAccuracy? ragAccuracy,
            global::RetellAI.TextTestCasePerformanceMetricsToolCallInaccuracy? toolCallInaccuracy)
        {
            this.CustomToolError = customToolError ?? throw new global::System.ArgumentNullException(nameof(customToolError));
            this.AgentHallucination = agentHallucination;
            this.NodeTransitionInaccuracy = nodeTransitionInaccuracy;
            this.RagAccuracy = ragAccuracy;
            this.ToolCallInaccuracy = toolCallInaccuracy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTestCasePerformanceMetrics" /> class.
        /// </summary>
        public TextTestCasePerformanceMetrics()
        {
        }

    }
}