
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionNodeVariant2
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.FunctionNodeVariant2TypeJsonConverter))]
        public global::RetellAI.FunctionNodeVariant2Type Type { get; set; }

        /// <summary>
        /// Tool ID for function nodes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        /// Tool type for function nodes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.FunctionNodeVariant2ToolTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.FunctionNodeVariant2ToolType ToolType { get; set; }

        /// <summary>
        /// Whether to speak during tool execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.NodeInstructionJsonConverter))]
        public global::RetellAI.NodeInstruction? Instruction { get; set; }

        /// <summary>
        /// Whether to wait for tool result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_for_result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WaitForResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::RetellAI.NodeEdge>? Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("else_edge")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ElseEdgeJsonConverter))]
        public global::RetellAI.ElseEdge? ElseEdge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_transition_examples")]
        public global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneTransitionExample>? FinetuneTransitionExamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionNodeVariant2" /> class.
        /// </summary>
        /// <param name="toolId">
        /// Tool ID for function nodes
        /// </param>
        /// <param name="toolType">
        /// Tool type for function nodes
        /// </param>
        /// <param name="waitForResult">
        /// Whether to wait for tool result
        /// </param>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="speakDuringExecution">
        /// Whether to speak during tool execution
        /// </param>
        /// <param name="instruction"></param>
        /// <param name="edges"></param>
        /// <param name="elseEdge"></param>
        /// <param name="finetuneTransitionExamples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionNodeVariant2(
            string toolId,
            global::RetellAI.FunctionNodeVariant2ToolType toolType,
            bool waitForResult,
            global::RetellAI.FunctionNodeVariant2Type type,
            bool? speakDuringExecution,
            global::RetellAI.NodeInstruction? instruction,
            global::System.Collections.Generic.IList<global::RetellAI.NodeEdge>? edges,
            global::RetellAI.ElseEdge? elseEdge,
            global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneTransitionExample>? finetuneTransitionExamples)
        {
            this.Type = type;
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.ToolType = toolType;
            this.SpeakDuringExecution = speakDuringExecution;
            this.Instruction = instruction;
            this.WaitForResult = waitForResult;
            this.Edges = edges;
            this.ElseEdge = elseEdge;
            this.FinetuneTransitionExamples = finetuneTransitionExamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionNodeVariant2" /> class.
        /// </summary>
        public FunctionNodeVariant2()
        {
        }
    }
}