
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Routing for one mode (fast or accurate), resolved for the caller's org. `provider` is the provider that the org's calls attempt first.
    /// </summary>
    public sealed partial class AsrProviderModeRouting
    {
        /// <summary>
        /// ASR provider name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AsrProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AsrProvider Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointing_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndpointingMs { get; set; }

        /// <summary>
        /// STT model that the org's calls use for `provider` in this mode, such as nova-3. Deepgram falls back to nova-2 for languages that nova-3 lacks. A medical agent on Deepgram uses nova-3-medical instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsrProviderModeRouting" /> class.
        /// </summary>
        /// <param name="provider">
        /// ASR provider name.
        /// </param>
        /// <param name="endpointingMs"></param>
        /// <param name="model">
        /// STT model that the org's calls use for `provider` in this mode, such as nova-3. Deepgram falls back to nova-2 for languages that nova-3 lacks. A medical agent on Deepgram uses nova-3-medical instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsrProviderModeRouting(
            global::RetellAI.AsrProvider provider,
            int endpointingMs,
            string model)
        {
            this.Provider = provider;
            this.EndpointingMs = endpointingMs;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsrProviderModeRouting" /> class.
        /// </summary>
        public AsrProviderModeRouting()
        {
        }

    }
}