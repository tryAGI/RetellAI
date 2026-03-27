
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseEngineConversationFlow
    {
        /// <summary>
        /// type of the Response Engine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ResponseEngineConversationFlowTypeJsonConverter))]
        public global::RetellAI.ResponseEngineConversationFlowType Type { get; set; }

        /// <summary>
        /// ID of the Conversation Flow Response Engine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_flow_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationFlowId { get; set; }

        /// <summary>
        /// Version of the Conversation Flow Response Engine.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public double? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEngineConversationFlow" /> class.
        /// </summary>
        /// <param name="type">
        /// type of the Response Engine.
        /// </param>
        /// <param name="conversationFlowId">
        /// ID of the Conversation Flow Response Engine.
        /// </param>
        /// <param name="version">
        /// Version of the Conversation Flow Response Engine.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseEngineConversationFlow(
            string conversationFlowId,
            global::RetellAI.ResponseEngineConversationFlowType type,
            double? version)
        {
            this.ConversationFlowId = conversationFlowId ?? throw new global::System.ArgumentNullException(nameof(conversationFlowId));
            this.Type = type;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEngineConversationFlow" /> class.
        /// </summary>
        public ResponseEngineConversationFlow()
        {
        }
    }
}