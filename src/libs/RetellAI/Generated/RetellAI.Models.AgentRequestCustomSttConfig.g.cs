
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Custom STT configuration. Only used when stt_mode is set to custom.
    /// </summary>
    public sealed partial class AgentRequestCustomSttConfig
    {
        /// <summary>
        /// The STT provider to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AsrProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AsrProvider Provider { get; set; }

        /// <summary>
        /// Endpointing timeout in milliseconds. Minimum is 100 for Azure, 10 for Deepgram, 500 for Soniox, 100 for AssemblyAI, 100 for Muse. For AssemblyAI, this sets min_turn_silence (100-3000 ms). max_turn_silence adds half of this value, rounded to the nearest millisecond and bounded to 500-1000 ms, with a total cap of 3000 ms. Muse detects turn ends itself and ignores this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointing_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndpointingMs { get; set; }

        /// <summary>
        /// STT model to pin for the custom provider. Deepgram offers nova-3 (Nova 3); vocab_specialization medical still selects Deepgram's medical model for English. Soniox offers stt-rt-v6 (Soniox v6) and stt-rt-v5 (Soniox v5). AssemblyAI offers universal-3-6-pro (Universal 3.6 Pro) and assemblyai-stt-3-7-realtime-agent (AssemblyAI 3.7 Agent). Azure offers azure-speech (Azure AI Speech). Omit to use the provider's default model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AsrModelJsonConverter))]
        public global::RetellAI.AsrModel? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestCustomSttConfig" /> class.
        /// </summary>
        /// <param name="provider">
        /// The STT provider to use.
        /// </param>
        /// <param name="endpointingMs">
        /// Endpointing timeout in milliseconds. Minimum is 100 for Azure, 10 for Deepgram, 500 for Soniox, 100 for AssemblyAI, 100 for Muse. For AssemblyAI, this sets min_turn_silence (100-3000 ms). max_turn_silence adds half of this value, rounded to the nearest millisecond and bounded to 500-1000 ms, with a total cap of 3000 ms. Muse detects turn ends itself and ignores this value.
        /// </param>
        /// <param name="model">
        /// STT model to pin for the custom provider. Deepgram offers nova-3 (Nova 3); vocab_specialization medical still selects Deepgram's medical model for English. Soniox offers stt-rt-v6 (Soniox v6) and stt-rt-v5 (Soniox v5). AssemblyAI offers universal-3-6-pro (Universal 3.6 Pro) and assemblyai-stt-3-7-realtime-agent (AssemblyAI 3.7 Agent). Azure offers azure-speech (Azure AI Speech). Omit to use the provider's default model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRequestCustomSttConfig(
            global::RetellAI.AsrProvider provider,
            int endpointingMs,
            global::RetellAI.AsrModel? model)
        {
            this.Provider = provider;
            this.EndpointingMs = endpointingMs;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestCustomSttConfig" /> class.
        /// </summary>
        public AgentRequestCustomSttConfig()
        {
        }

    }
}