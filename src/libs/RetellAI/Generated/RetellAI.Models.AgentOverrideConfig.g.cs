
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentOverrideConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption_sensitivity")]
        public double? InterruptionSensitivity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responsiveness")]
        public double? Responsiveness { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_speed")]
        public double? VoiceSpeed { get; set; }

        /// <summary>
        /// If set, overrides the agent-level allow_dtmf_interruption for this node only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_dtmf_interruption")]
        public bool? AllowDtmfInterruption { get; set; }

        /// <summary>
        /// If set (in milliseconds), overrides the agent-level reminder_trigger_ms for this node only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reminder_trigger_ms")]
        public double? ReminderTriggerMs { get; set; }

        /// <summary>
        /// If set, overrides the agent-level reminder_max_count for this node only. Set to 0 to disable reminders for this node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reminder_max_count")]
        public int? ReminderMaxCount { get; set; }

        /// <summary>
        /// Balance between speed and accuracy. Fast optimizes for speed using the provider configuration, accurate optimizes for accuracy using the provider configuration, and custom uses custom_stt_config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AgentOverrideConfigSttModeJsonConverter))]
        public global::RetellAI.AgentOverrideConfigSttMode? SttMode { get; set; }

        /// <summary>
        /// Custom transcription settings. Required when stt_mode is custom.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_stt_config")]
        public global::RetellAI.AgentOverrideConfigCustomSttConfig? CustomSttConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOverrideConfig" /> class.
        /// </summary>
        /// <param name="interruptionSensitivity"></param>
        /// <param name="responsiveness"></param>
        /// <param name="voiceSpeed"></param>
        /// <param name="allowDtmfInterruption">
        /// If set, overrides the agent-level allow_dtmf_interruption for this node only.
        /// </param>
        /// <param name="reminderTriggerMs">
        /// If set (in milliseconds), overrides the agent-level reminder_trigger_ms for this node only.
        /// </param>
        /// <param name="reminderMaxCount">
        /// If set, overrides the agent-level reminder_max_count for this node only. Set to 0 to disable reminders for this node.
        /// </param>
        /// <param name="sttMode">
        /// Balance between speed and accuracy. Fast optimizes for speed using the provider configuration, accurate optimizes for accuracy using the provider configuration, and custom uses custom_stt_config.
        /// </param>
        /// <param name="customSttConfig">
        /// Custom transcription settings. Required when stt_mode is custom.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentOverrideConfig(
            double? interruptionSensitivity,
            double? responsiveness,
            double? voiceSpeed,
            bool? allowDtmfInterruption,
            double? reminderTriggerMs,
            int? reminderMaxCount,
            global::RetellAI.AgentOverrideConfigSttMode? sttMode,
            global::RetellAI.AgentOverrideConfigCustomSttConfig? customSttConfig)
        {
            this.InterruptionSensitivity = interruptionSensitivity;
            this.Responsiveness = responsiveness;
            this.VoiceSpeed = voiceSpeed;
            this.AllowDtmfInterruption = allowDtmfInterruption;
            this.ReminderTriggerMs = reminderTriggerMs;
            this.ReminderMaxCount = reminderMaxCount;
            this.SttMode = sttMode;
            this.CustomSttConfig = customSttConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOverrideConfig" /> class.
        /// </summary>
        public AgentOverrideConfig()
        {
        }

    }
}