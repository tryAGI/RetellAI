
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSwapNodeVariant2
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AgentSwapNodeVariant2TypeJsonConverter))]
        public global::RetellAI.AgentSwapNodeVariant2Type Type { get; set; }

        /// <summary>
        /// The ID of the agent to swap to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). The string "latest" resolves to the most recently created version (the largest version number), and "latest_published" resolves to the most recently published version. When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version, latest, or latest_published is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AgentVersionReferenceJsonConverter))]
        public global::RetellAI.AgentVersionReference? AgentVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_call_analysis_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.PostCallAnalysisSettingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.PostCallAnalysisSetting PostCallAnalysisSetting { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AgentSwapWebhookSettingJsonConverter))]
        public global::RetellAI.AgentSwapWebhookSetting? WebhookSetting { get; set; }

        /// <summary>
        /// If true, keep the current voice and ambient sound settings when swapping agents. Otherwise, use the destination agent's voice and ambient sound settings. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_current_voice")]
        public bool? KeepCurrentVoice { get; set; }

        /// <summary>
        /// If true, keep the current language when swapping agents. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_current_language")]
        public bool? KeepCurrentLanguage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TransferFailedEdgeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.TransferFailedEdge Edge { get; set; }

        /// <summary>
        /// If true, will speak during execution
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSwapNodeVariant2" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent to swap to
        /// </param>
        /// <param name="postCallAnalysisSetting"></param>
        /// <param name="edge"></param>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="agentVersion">
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). The string "latest" resolves to the most recently created version (the largest version number), and "latest_published" resolves to the most recently published version. When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version, latest, or latest_published is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </param>
        /// <param name="webhookSetting"></param>
        /// <param name="keepCurrentVoice">
        /// If true, keep the current voice and ambient sound settings when swapping agents. Otherwise, use the destination agent's voice and ambient sound settings. Defaults to false.
        /// </param>
        /// <param name="keepCurrentLanguage">
        /// If true, keep the current language when swapping agents. Defaults to false.
        /// </param>
        /// <param name="speakDuringExecution">
        /// If true, will speak during execution
        /// </param>
        /// <param name="instruction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSwapNodeVariant2(
            string agentId,
            global::RetellAI.PostCallAnalysisSetting postCallAnalysisSetting,
            global::RetellAI.TransferFailedEdge edge,
            global::RetellAI.AgentSwapNodeVariant2Type type,
            global::RetellAI.AgentVersionReference? agentVersion,
            global::RetellAI.AgentSwapWebhookSetting? webhookSetting,
            bool? keepCurrentVoice,
            bool? keepCurrentLanguage,
            bool? speakDuringExecution,
            global::RetellAI.NodeInstruction? instruction)
        {
            this.Type = type;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentVersion = agentVersion;
            this.PostCallAnalysisSetting = postCallAnalysisSetting;
            this.WebhookSetting = webhookSetting;
            this.KeepCurrentVoice = keepCurrentVoice;
            this.KeepCurrentLanguage = keepCurrentLanguage;
            this.Edge = edge;
            this.SpeakDuringExecution = speakDuringExecution;
            this.Instruction = instruction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSwapNodeVariant2" /> class.
        /// </summary>
        public AgentSwapNodeVariant2()
        {
        }

    }
}