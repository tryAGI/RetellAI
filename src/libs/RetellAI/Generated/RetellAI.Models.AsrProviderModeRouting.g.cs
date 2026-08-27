
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Routing for one mode (fast or accurate). `provider` is the dominant provider (what most calls hit). When traffic is split across a chance gate, `split` is present and lists every provider with its explicit traffic `fraction` (dominant first); otherwise all calls hit `provider`.
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
        /// Present only when traffic is split across a chance gate. Each entry is a provider and the `fraction` (0–1) of calls routed to it, stably bucketed by call id; fractions sum to 1. Sorted by `fraction` descending, so the first entry matches the top-level `provider`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split")]
        public global::System.Collections.Generic.IList<global::RetellAI.AsrProviderModeRoutingSplitItem>? Split { get; set; }

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
        /// <param name="split">
        /// Present only when traffic is split across a chance gate. Each entry is a provider and the `fraction` (0–1) of calls routed to it, stably bucketed by call id; fractions sum to 1. Sorted by `fraction` descending, so the first entry matches the top-level `provider`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsrProviderModeRouting(
            global::RetellAI.AsrProvider provider,
            int endpointingMs,
            global::System.Collections.Generic.IList<global::RetellAI.AsrProviderModeRoutingSplitItem>? split)
        {
            this.Provider = provider;
            this.EndpointingMs = endpointingMs;
            this.Split = split;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsrProviderModeRouting" /> class.
        /// </summary>
        public AsrProviderModeRouting()
        {
        }

    }
}