
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseEngineCustomLm
    {
        /// <summary>
        /// type of the Response Engine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ResponseEngineCustomLmTypeJsonConverter))]
        public global::RetellAI.ResponseEngineCustomLmType Type { get; set; }

        /// <summary>
        /// LLM websocket url of the custom LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_websocket_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LlmWebsocketUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEngineCustomLm" /> class.
        /// </summary>
        /// <param name="type">
        /// type of the Response Engine.
        /// </param>
        /// <param name="llmWebsocketUrl">
        /// LLM websocket url of the custom LLM.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseEngineCustomLm(
            string llmWebsocketUrl,
            global::RetellAI.ResponseEngineCustomLmType type)
        {
            this.LlmWebsocketUrl = llmWebsocketUrl ?? throw new global::System.ArgumentNullException(nameof(llmWebsocketUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEngineCustomLm" /> class.
        /// </summary>
        public ResponseEngineCustomLm()
        {
        }
    }
}