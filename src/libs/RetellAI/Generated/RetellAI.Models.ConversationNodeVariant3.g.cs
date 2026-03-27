
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationNodeVariant3
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConversationNodeVariant3TypeJsonConverter))]
        public global::RetellAI.ConversationNodeVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.NodeInstructionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.NodeInstruction Instruction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_response_edge")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SkipResponseEdgeJsonConverter))]
        public global::RetellAI.SkipResponseEdge? SkipResponseEdge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("always_edge")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AlwaysEdgeJsonConverter))]
        public global::RetellAI.AlwaysEdge? AlwaysEdge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::RetellAI.NodeEdge>? Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_conversation_examples")]
        public global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneConversationExample>? FinetuneConversationExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_transition_examples")]
        public global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneTransitionExample>? FinetuneTransitionExamples { get; set; }

        /// <summary>
        /// Knowledge base IDs for RAG (Retrieval-Augmented Generation).<br/>
        /// Example: [kb_001, kb_002]
        /// </summary>
        /// <example>[kb_001, kb_002]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_ids")]
        public global::System.Collections.Generic.IList<string>? KnowledgeBaseIds { get; set; }

        /// <summary>
        /// The tool ids of the tools defined in main conversation flow or component that can be used in this conversation node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_ids")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// The tools owned by this conversation node. This includes other tool types like transfer_call, agent_swap, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::RetellAI.Tool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNodeVariant3" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="instruction"></param>
        /// <param name="skipResponseEdge"></param>
        /// <param name="alwaysEdge"></param>
        /// <param name="edges"></param>
        /// <param name="finetuneConversationExamples"></param>
        /// <param name="finetuneTransitionExamples"></param>
        /// <param name="knowledgeBaseIds">
        /// Knowledge base IDs for RAG (Retrieval-Augmented Generation).<br/>
        /// Example: [kb_001, kb_002]
        /// </param>
        /// <param name="toolIds">
        /// The tool ids of the tools defined in main conversation flow or component that can be used in this conversation node.
        /// </param>
        /// <param name="tools">
        /// The tools owned by this conversation node. This includes other tool types like transfer_call, agent_swap, etc.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationNodeVariant3(
            global::RetellAI.NodeInstruction instruction,
            global::RetellAI.ConversationNodeVariant3Type type,
            global::RetellAI.SkipResponseEdge? skipResponseEdge,
            global::RetellAI.AlwaysEdge? alwaysEdge,
            global::System.Collections.Generic.IList<global::RetellAI.NodeEdge>? edges,
            global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneConversationExample>? finetuneConversationExamples,
            global::System.Collections.Generic.IList<global::RetellAI.NodeFinetuneTransitionExample>? finetuneTransitionExamples,
            global::System.Collections.Generic.IList<string>? knowledgeBaseIds,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::System.Collections.Generic.IList<global::RetellAI.Tool>? tools)
        {
            this.Instruction = instruction;
            this.Type = type;
            this.SkipResponseEdge = skipResponseEdge;
            this.AlwaysEdge = alwaysEdge;
            this.Edges = edges;
            this.FinetuneConversationExamples = finetuneConversationExamples;
            this.FinetuneTransitionExamples = finetuneTransitionExamples;
            this.KnowledgeBaseIds = knowledgeBaseIds;
            this.ToolIds = toolIds;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNodeVariant3" /> class.
        /// </summary>
        public ConversationNodeVariant3()
        {
        }
    }
}