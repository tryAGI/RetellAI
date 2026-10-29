
#pragma warning disable CS0618 // Type or member is obsolete

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backup_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.NullableBackupModelChoiceJsonConverter))]
        public global::RetellAI.NullableBackupModelChoice? BackupModel { get; set; }

        /// <summary>
        /// Deprecated, use model_config.primary. Ignored when model_config is set.<br/>
        /// Example: gpt-5.6-terra
        /// </summary>
        /// <example>gpt-5.6-terra</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.NullableLLMModelJsonConverter))]
        public global::RetellAI.NullableLLMModel? Model { get; set; }

        /// <summary>
        /// Deprecated, use model_config with type s2s. Ignored when model_config is set.<br/>
        /// Example: gpt-realtime-1.5
        /// </summary>
        /// <example>gpt-realtime-1.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("s2s_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.NullableS2SModelJsonConverter))]
        public global::RetellAI.NullableS2SModel? S2sModel { get; set; }

        /// <summary>
        /// Deprecated, use model_config.temperature. Ignored when model_config is set.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_temperature")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? ModelTemperature { get; set; }

        /// <summary>
        /// Deprecated, use model_config.primary.tier fast. Ignored when model_config is set.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_high_priority")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ModelHighPriority { get; set; }

        /// <summary>
        /// Deprecated, use model_config.primary.tier ultrafast. Ignored when model_config is set.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_ultrafast")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ModelUltrafast { get; set; }

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
        /// <param name="backupModel"></param>
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
            global::RetellAI.NullableBackupModelChoice? backupModel,
            global::System.Collections.Generic.IList<string>? knowledgeBaseIds,
            global::RetellAI.KBConfig? kbConfig,
            global::RetellAI.RetellLlmOverrideStartSpeaker? startSpeaker,
            int? beginAfterUserSilenceMs,
            string? beginMessage)
        {
            this.ModelConfig = modelConfig;
            this.BackupModel = backupModel;
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