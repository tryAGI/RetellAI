
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationTestCaseDefinitionV3BaseVariant2
    {
        /// <summary>
        /// How the simulated caller behaves during the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TestCaseCallerInstructionsJsonConverter))]
        public global::RetellAI.TestCaseCallerInstructions? CallerInstructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_model_config")]
        public global::RetellAI.CascadingModelConfig? UserModelConfig { get; set; }

        /// <summary>
        /// Checks the conversation must pass. All must pass for the test to pass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_criteria")]
        public global::System.Collections.Generic.IList<global::RetellAI.TestCaseEvalCriterion>? EvalCriteria { get; set; }

        /// <summary>
        /// Available LLM models for agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_criteria_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.LLMModelJsonConverter))]
        public global::RetellAI.LLMModel? EvalCriteriaModel { get; set; }

        /// <summary>
        /// Dynamic variables to inject into the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? DynamicVariables { get; set; }

        /// <summary>
        /// Fake tool responses used instead of calling the real tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_mocks")]
        public global::System.Collections.Generic.IList<global::RetellAI.ToolMock>? ToolMocks { get; set; }

        /// <summary>
        /// Paid performance metrics to measure during the run. Free performance metrics are always measured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_performance_metrics")]
        public global::System.Collections.Generic.IList<global::RetellAI.TestCasePaidPerformanceMetric>? EnabledPerformanceMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTestCaseDefinitionV3BaseVariant2" /> class.
        /// </summary>
        /// <param name="callerInstructions">
        /// How the simulated caller behaves during the test.
        /// </param>
        /// <param name="userModelConfig"></param>
        /// <param name="evalCriteria">
        /// Checks the conversation must pass. All must pass for the test to pass.
        /// </param>
        /// <param name="evalCriteriaModel">
        /// Available LLM models for agents.
        /// </param>
        /// <param name="dynamicVariables">
        /// Dynamic variables to inject into the agent.
        /// </param>
        /// <param name="toolMocks">
        /// Fake tool responses used instead of calling the real tools.
        /// </param>
        /// <param name="enabledPerformanceMetrics">
        /// Paid performance metrics to measure during the run. Free performance metrics are always measured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationTestCaseDefinitionV3BaseVariant2(
            global::RetellAI.TestCaseCallerInstructions? callerInstructions,
            global::RetellAI.CascadingModelConfig? userModelConfig,
            global::System.Collections.Generic.IList<global::RetellAI.TestCaseEvalCriterion>? evalCriteria,
            global::RetellAI.LLMModel? evalCriteriaModel,
            global::System.Collections.Generic.Dictionary<string, string>? dynamicVariables,
            global::System.Collections.Generic.IList<global::RetellAI.ToolMock>? toolMocks,
            global::System.Collections.Generic.IList<global::RetellAI.TestCasePaidPerformanceMetric>? enabledPerformanceMetrics)
        {
            this.CallerInstructions = callerInstructions;
            this.UserModelConfig = userModelConfig;
            this.EvalCriteria = evalCriteria;
            this.EvalCriteriaModel = evalCriteriaModel;
            this.DynamicVariables = dynamicVariables;
            this.ToolMocks = toolMocks;
            this.EnabledPerformanceMetrics = enabledPerformanceMetrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTestCaseDefinitionV3BaseVariant2" /> class.
        /// </summary>
        public ConversationTestCaseDefinitionV3BaseVariant2()
        {
        }

    }
}