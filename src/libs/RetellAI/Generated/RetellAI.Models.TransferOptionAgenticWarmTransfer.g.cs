
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferOptionAgenticWarmTransfer
    {
        /// <summary>
        /// The type of the transfer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferTypeJsonConverter))]
        public global::RetellAI.TransferOptionAgenticWarmTransferType Type { get; set; }

        /// <summary>
        /// If set to true, will show transferee (the user, not the AI agent) as caller when transferring, requires the telephony side to support caller id override. Retell Twilio numbers support this option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_transferee_as_caller")]
        public bool? ShowTransfereeAsCaller { get; set; }

        /// <summary>
        /// The music to play while the caller is being transferred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_hold_music")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TransferOptionAgenticWarmTransferOnHoldMusicJsonConverter))]
        public global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic? OnHoldMusic { get; set; }

        /// <summary>
        /// Override the ring duration for this specific transfer, in milliseconds. If not set, falls back to the agent-level `ring_duration_ms`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_ring_duration_ms")]
        public int? TransferRingDurationMs { get; set; }

        /// <summary>
        /// If set, when transfer is successful, will say the handoff message to both the transferee and the agent receiving the transfer. Can leave either a static message or a dynamic one based on prompt. Set to null to disable warm handoff.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_handoff_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>))]
        public global::RetellAI.OneOf<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>? PublicHandoffOption { get; set; }

        /// <summary>
        /// Configuration for agentic warm transfer. Required for agentic warm transfer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentic_transfer_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfig AgenticTransferConfig { get; set; }

        /// <summary>
        /// Whether to play an audio cue when bridging the call. Defaults to true.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_bridge_audio_cue")]
        public bool? EnableBridgeAudioCue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOptionAgenticWarmTransfer" /> class.
        /// </summary>
        /// <param name="agenticTransferConfig">
        /// Configuration for agentic warm transfer. Required for agentic warm transfer.
        /// </param>
        /// <param name="type">
        /// The type of the transfer.
        /// </param>
        /// <param name="showTransfereeAsCaller">
        /// If set to true, will show transferee (the user, not the AI agent) as caller when transferring, requires the telephony side to support caller id override. Retell Twilio numbers support this option.
        /// </param>
        /// <param name="onHoldMusic">
        /// The music to play while the caller is being transferred.
        /// </param>
        /// <param name="transferRingDurationMs">
        /// Override the ring duration for this specific transfer, in milliseconds. If not set, falls back to the agent-level `ring_duration_ms`.
        /// </param>
        /// <param name="publicHandoffOption">
        /// If set, when transfer is successful, will say the handoff message to both the transferee and the agent receiving the transfer. Can leave either a static message or a dynamic one based on prompt. Set to null to disable warm handoff.
        /// </param>
        /// <param name="enableBridgeAudioCue">
        /// Whether to play an audio cue when bridging the call. Defaults to true.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferOptionAgenticWarmTransfer(
            global::RetellAI.TransferOptionAgenticWarmTransferAgenticTransferConfig agenticTransferConfig,
            global::RetellAI.TransferOptionAgenticWarmTransferType type,
            bool? showTransfereeAsCaller,
            global::RetellAI.TransferOptionAgenticWarmTransferOnHoldMusic? onHoldMusic,
            int? transferRingDurationMs,
            global::RetellAI.OneOf<global::RetellAI.WarmTransferPrompt, global::RetellAI.WarmTransferStaticMessage>? publicHandoffOption,
            bool? enableBridgeAudioCue)
        {
            this.Type = type;
            this.ShowTransfereeAsCaller = showTransfereeAsCaller;
            this.OnHoldMusic = onHoldMusic;
            this.TransferRingDurationMs = transferRingDurationMs;
            this.PublicHandoffOption = publicHandoffOption;
            this.AgenticTransferConfig = agenticTransferConfig ?? throw new global::System.ArgumentNullException(nameof(agenticTransferConfig));
            this.EnableBridgeAudioCue = enableBridgeAudioCue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOptionAgenticWarmTransfer" /> class.
        /// </summary>
        public TransferOptionAgenticWarmTransfer()
        {
        }
    }
}