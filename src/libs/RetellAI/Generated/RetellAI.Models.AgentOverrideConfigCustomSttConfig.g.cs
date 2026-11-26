
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Custom transcription settings. Required when stt_mode is custom.
    /// </summary>
    public sealed partial class AgentOverrideConfigCustomSttConfig
    {
        /// <summary>
        /// The STT provider to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AsrProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AsrProvider Provider { get; set; }

        /// <summary>
        /// Endpointing timeout in milliseconds. Minimum is 100 for Azure, 10 for Deepgram, 500 for Soniox, 100 for AssemblyAI, and 100 for Muse. Muse detects turn ends itself and ignores this value.
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
        /// Initializes a new instance of the <see cref="AgentOverrideConfigCustomSttConfig" /> class.
        /// </summary>
        /// <param name="provider">
        /// The STT provider to use.
        /// </param>
        /// <param name="endpointingMs">
        /// Endpointing timeout in milliseconds. Minimum is 100 for Azure, 10 for Deepgram, 500 for Soniox, 100 for AssemblyAI, and 100 for Muse. Muse detects turn ends itself and ignores this value.
        /// </param>
        /// <param name="model">
        /// STT model to pin for the custom provider. Deepgram offers nova-3 (Nova 3); vocab_specialization medical still selects Deepgram's medical model for English. Soniox offers stt-rt-v6 (Soniox v6) and stt-rt-v5 (Soniox v5). AssemblyAI offers universal-3-6-pro (Universal 3.6 Pro) and assemblyai-stt-3-7-realtime-agent (AssemblyAI 3.7 Agent). Azure offers azure-speech (Azure AI Speech). Omit to use the provider's default model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentOverrideConfigCustomSttConfig(
            global::RetellAI.AsrProvider provider,
            int endpointingMs,
            global::RetellAI.AsrModel? model)
        {
            this.Provider = provider;
            this.EndpointingMs = endpointingMs;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOverrideConfigCustomSttConfig" /> class.
        /// </summary>
        public AgentOverrideConfigCustomSttConfig()
        {
        }

    }
}