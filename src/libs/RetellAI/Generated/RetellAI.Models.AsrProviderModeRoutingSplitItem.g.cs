
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsrProviderModeRoutingSplitItem
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fraction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Fraction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsrProviderModeRoutingSplitItem" /> class.
        /// </summary>
        /// <param name="provider">
        /// ASR provider name.
        /// </param>
        /// <param name="endpointingMs"></param>
        /// <param name="fraction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsrProviderModeRoutingSplitItem(
            global::RetellAI.AsrProvider provider,
            int endpointingMs,
            double fraction)
        {
            this.Provider = provider;
            this.EndpointingMs = endpointingMs;
            this.Fraction = fraction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsrProviderModeRoutingSplitItem" /> class.
        /// </summary>
        public AsrProviderModeRoutingSplitItem()
        {
        }

    }
}