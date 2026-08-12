
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContactChat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ContactChatTypeJsonConverter))]
        public global::RetellAI.ContactChatType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChatId { get; set; }

        /// <summary>
        /// Epoch milliseconds when the chat started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        public double? StartTimestamp { get; set; }

        /// <summary>
        /// Duration of the chat in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public double? DurationMs { get; set; }

        /// <summary>
        /// Direction of the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ContactChatDirectionJsonConverter))]
        public global::RetellAI.ContactChatDirection? Direction { get; set; }

        /// <summary>
        /// Reason the chat ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnection_reason")]
        public string? DisconnectionReason { get; set; }

        /// <summary>
        /// Post-chat analysis summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// User sentiment from post-chat analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ContactChatSentimentJsonConverter))]
        public global::RetellAI.ContactChatSentiment? Sentiment { get; set; }

        /// <summary>
        /// Whether the chat was deemed successful by post-chat analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        public bool? Successful { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactChat" /> class.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="type"></param>
        /// <param name="startTimestamp">
        /// Epoch milliseconds when the chat started.
        /// </param>
        /// <param name="durationMs">
        /// Duration of the chat in milliseconds.
        /// </param>
        /// <param name="direction">
        /// Direction of the chat.
        /// </param>
        /// <param name="disconnectionReason">
        /// Reason the chat ended.
        /// </param>
        /// <param name="summary">
        /// Post-chat analysis summary.
        /// </param>
        /// <param name="sentiment">
        /// User sentiment from post-chat analysis.
        /// </param>
        /// <param name="successful">
        /// Whether the chat was deemed successful by post-chat analysis.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactChat(
            string chatId,
            global::RetellAI.ContactChatType type,
            double? startTimestamp,
            double? durationMs,
            global::RetellAI.ContactChatDirection? direction,
            string? disconnectionReason,
            string? summary,
            global::RetellAI.ContactChatSentiment? sentiment,
            bool? successful)
        {
            this.Type = type;
            this.ChatId = chatId ?? throw new global::System.ArgumentNullException(nameof(chatId));
            this.StartTimestamp = startTimestamp;
            this.DurationMs = durationMs;
            this.Direction = direction;
            this.DisconnectionReason = disconnectionReason;
            this.Summary = summary;
            this.Sentiment = sentiment;
            this.Successful = successful;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactChat" /> class.
        /// </summary>
        public ContactChat()
        {
        }

    }
}