
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
        /// Endpointing timeout in milliseconds. Minimum is 100 for Azure, 10 for Deepgram, 500 for Soniox, and 100 for AssemblyAI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointing_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndpointingMs { get; set; }

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
        /// Endpointing timeout in milliseconds. Minimum is 100 for Azure, 10 for Deepgram, 500 for Soniox, and 100 for AssemblyAI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentOverrideConfigCustomSttConfig(
            global::RetellAI.AsrProvider provider,
            int endpointingMs)
        {
            this.Provider = provider;
            this.EndpointingMs = endpointingMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOverrideConfigCustomSttConfig" /> class.
        /// </summary>
        public AgentOverrideConfigCustomSttConfig()
        {
        }

    }
}