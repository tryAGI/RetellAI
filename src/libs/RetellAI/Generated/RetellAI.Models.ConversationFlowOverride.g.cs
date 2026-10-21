
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Override properties for conversation flow configuration in agent override requests.
    /// </summary>
    public sealed partial class ConversationFlowOverride
    {
        /// <summary>
        /// Model settings for the response engine. type decides which models primary and backup accept. On update, each top-level key replaces the current one and omitted keys are kept; set backup to null to remove it. Changing type requires primary and clears backup, while temperature carries over. In agent_override, type is required whenever primary is set, and backup cannot be removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ModelConfigJsonConverter))]
        public global::RetellAI.ModelConfig? ModelConfig { get; set; }

        /// <summary>
        /// Deprecated, use model_config. Ignored when model_config is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ModelChoiceJsonConverter))]
        public global::RetellAI.ModelChoice? ModelChoice { get; set; }

        /// <summary>
        /// Deprecated, use model_config.temperature. Ignored when model_config is set.<br/>
        /// Example: 0.7
        /// </summary>
        /// <example>0.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_temperature")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? ModelTemperature { get; set; }

        /// <summary>
        /// Whether to use strict mode for tool calls. Only applicable when using certain supported models.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_strict_mode")]
        public bool? ToolCallStrictMode { get; set; }

        /// <summary>
        /// Knowledge base IDs for RAG (Retrieval-Augmented Generation).<br/>
        /// Example: [kb_001, kb_002]
        /// </summary>
        /// <example>[kb_001, kb_002]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_ids")]
        public global::System.Collections.Generic.IList<string>? KnowledgeBaseIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kb_config")]
        public global::RetellAI.KBConfig? KbConfig { get; set; }

        /// <summary>
        /// Who starts the conversation - user or agent.<br/>
        /// Example: agent
        /// </summary>
        /// <example>agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_speaker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConversationFlowOverrideStartSpeakerJsonConverter))]
        public global::RetellAI.ConversationFlowOverrideStartSpeaker? StartSpeaker { get; set; }

        /// <summary>
        /// If set, the AI will begin the conversation after waiting for the user for the duration (in milliseconds) specified by this attribute. This only applies if the agent is configured to wait for the user to speak first. If not set, the agent will wait indefinitely for the user to speak.<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("begin_after_user_silence_ms")]
        public int? BeginAfterUserSilenceMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowOverride" /> class.
        /// </summary>
        /// <param name="modelConfig">
        /// Model settings for the response engine. type decides which models primary and backup accept. On update, each top-level key replaces the current one and omitted keys are kept; set backup to null to remove it. Changing type requires primary and clears backup, while temperature carries over. In agent_override, type is required whenever primary is set, and backup cannot be removed.
        /// </param>
        /// <param name="toolCallStrictMode">
        /// Whether to use strict mode for tool calls. Only applicable when using certain supported models.<br/>
        /// Example: true
        /// </param>
        /// <param name="knowledgeBaseIds">
        /// Knowledge base IDs for RAG (Retrieval-Augmented Generation).<br/>
        /// Example: [kb_001, kb_002]
        /// </param>
        /// <param name="kbConfig"></param>
        /// <param name="startSpeaker">
        /// Who starts the conversation - user or agent.<br/>
        /// Example: agent
        /// </param>
        /// <param name="beginAfterUserSilenceMs">
        /// If set, the AI will begin the conversation after waiting for the user for the duration (in milliseconds) specified by this attribute. This only applies if the agent is configured to wait for the user to speak first. If not set, the agent will wait indefinitely for the user to speak.<br/>
        /// Example: 2000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationFlowOverride(
            global::RetellAI.ModelConfig? modelConfig,
            bool? toolCallStrictMode,
            global::System.Collections.Generic.IList<string>? knowledgeBaseIds,
            global::RetellAI.KBConfig? kbConfig,
            global::RetellAI.ConversationFlowOverrideStartSpeaker? startSpeaker,
            int? beginAfterUserSilenceMs)
        {
            this.ModelConfig = modelConfig;
            this.ToolCallStrictMode = toolCallStrictMode;
            this.KnowledgeBaseIds = knowledgeBaseIds;
            this.KbConfig = kbConfig;
            this.StartSpeaker = startSpeaker;
            this.BeginAfterUserSilenceMs = beginAfterUserSilenceMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowOverride" /> class.
        /// </summary>
        public ConversationFlowOverride()
        {
        }

    }
}