
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Override properties for Retell LLM configuration in agent override requests.
    /// </summary>
    public sealed partial class RetellLlmOverride
    {
        /// <summary>
        /// Model settings for the response engine. type decides which models primary and backup accept. On update, each top-level key replaces the current one and omitted keys are kept; set backup to null to remove it. Changing type requires primary and clears backup, while temperature carries over. In agent_override, type is required whenever primary is set; setting backup to null disables it for that call only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ModelConfigJsonConverter))]
        public global::RetellAI.ModelConfig? ModelConfig { get; set; }

        /// <summary>
        /// A list of knowledge base ids to use for this resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_ids")]
        public global::System.Collections.Generic.IList<string>? KnowledgeBaseIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kb_config")]
        public global::RetellAI.KBConfig? KbConfig { get; set; }

        /// <summary>
        /// The speaker who starts the conversation. Required. Must be either 'user' or 'agent'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_speaker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.RetellLlmOverrideStartSpeakerJsonConverter))]
        public global::RetellAI.RetellLlmOverrideStartSpeaker? StartSpeaker { get; set; }

        /// <summary>
        /// If set, the AI will begin the conversation after waiting for the user for the duration (in milliseconds) specified by this attribute. This only applies if the agent is configured to wait for the user to speak first. If not set, the agent will wait indefinitely for the user to speak.<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("begin_after_user_silence_ms")]
        public int? BeginAfterUserSilenceMs { get; set; }

        /// <summary>
        /// First utterance said by the agent in the call. If not set, LLM will dynamically generate a message. If set to "", agent will wait for user to speak first.<br/>
        /// Example: Hey I am a virtual assistant calling from Retell Hospital.
        /// </summary>
        /// <example>Hey I am a virtual assistant calling from Retell Hospital.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("begin_message")]
        public string? BeginMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetellLlmOverride" /> class.
        /// </summary>
        /// <param name="modelConfig">
        /// Model settings for the response engine. type decides which models primary and backup accept. On update, each top-level key replaces the current one and omitted keys are kept; set backup to null to remove it. Changing type requires primary and clears backup, while temperature carries over. In agent_override, type is required whenever primary is set; setting backup to null disables it for that call only.
        /// </param>
        /// <param name="knowledgeBaseIds">
        /// A list of knowledge base ids to use for this resource.
        /// </param>
        /// <param name="kbConfig"></param>
        /// <param name="startSpeaker">
        /// The speaker who starts the conversation. Required. Must be either 'user' or 'agent'.
        /// </param>
        /// <param name="beginAfterUserSilenceMs">
        /// If set, the AI will begin the conversation after waiting for the user for the duration (in milliseconds) specified by this attribute. This only applies if the agent is configured to wait for the user to speak first. If not set, the agent will wait indefinitely for the user to speak.<br/>
        /// Example: 2000
        /// </param>
        /// <param name="beginMessage">
        /// First utterance said by the agent in the call. If not set, LLM will dynamically generate a message. If set to "", agent will wait for user to speak first.<br/>
        /// Example: Hey I am a virtual assistant calling from Retell Hospital.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetellLlmOverride(
            global::RetellAI.ModelConfig? modelConfig,
            global::System.Collections.Generic.IList<string>? knowledgeBaseIds,
            global::RetellAI.KBConfig? kbConfig,
            global::RetellAI.RetellLlmOverrideStartSpeaker? startSpeaker,
            int? beginAfterUserSilenceMs,
            string? beginMessage)
        {
            this.ModelConfig = modelConfig;
            this.KnowledgeBaseIds = knowledgeBaseIds;
            this.KbConfig = kbConfig;
            this.StartSpeaker = startSpeaker;
            this.BeginAfterUserSilenceMs = beginAfterUserSilenceMs;
            this.BeginMessage = beginMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetellLlmOverride" /> class.
        /// </summary>
        public RetellLlmOverride()
        {
        }

    }
}