
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// If this option is set, the call will try to detect voicemail in the first 3 minutes of the call. Actions defined (hangup, or leave a message) will be applied when the voicemail is detected. Set this to null to disable voicemail detection.<br/>
    /// Example: {"action":{"type":"static_text","text":"Please give us a callback tomorrow at 10am."}}
    /// </summary>
    public sealed partial class AgentRequestVoicemailOption
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.VoicemailActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.VoicemailAction Action { get; set; }

        /// <summary>
        /// Optionally describe what should be treated as voicemail. Leave as null to use the default definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detection_prompt")]
        public string? DetectionPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestVoicemailOption" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="detectionPrompt">
        /// Optionally describe what should be treated as voicemail. Leave as null to use the default definition.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRequestVoicemailOption(
            global::RetellAI.VoicemailAction action,
            string? detectionPrompt)
        {
            this.Action = action;
            this.DetectionPrompt = detectionPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestVoicemailOption" /> class.
        /// </summary>
        public AgentRequestVoicemailOption()
        {
        }

    }
}