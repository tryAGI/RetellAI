
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContactCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ContactCallTypeJsonConverter))]
        public global::RetellAI.ContactCallType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Epoch milliseconds when the call started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        public double? StartTimestamp { get; set; }

        /// <summary>
        /// Duration of the call in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public double? DurationMs { get; set; }

        /// <summary>
        /// Direction of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ContactCallDirectionJsonConverter))]
        public global::RetellAI.ContactCallDirection? Direction { get; set; }

        /// <summary>
        /// Reason the call ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnection_reason")]
        public string? DisconnectionReason { get; set; }

        /// <summary>
        /// Post-call analysis summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// User sentiment from post-call analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ContactCallSentimentJsonConverter))]
        public global::RetellAI.ContactCallSentiment? Sentiment { get; set; }

        /// <summary>
        /// Whether the call was deemed successful by post-call analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        public bool? Successful { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactCall" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="type"></param>
        /// <param name="startTimestamp">
        /// Epoch milliseconds when the call started.
        /// </param>
        /// <param name="durationMs">
        /// Duration of the call in milliseconds.
        /// </param>
        /// <param name="direction">
        /// Direction of the call.
        /// </param>
        /// <param name="disconnectionReason">
        /// Reason the call ended.
        /// </param>
        /// <param name="summary">
        /// Post-call analysis summary.
        /// </param>
        /// <param name="sentiment">
        /// User sentiment from post-call analysis.
        /// </param>
        /// <param name="successful">
        /// Whether the call was deemed successful by post-call analysis.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactCall(
            string callId,
            global::RetellAI.ContactCallType type,
            double? startTimestamp,
            double? durationMs,
            global::RetellAI.ContactCallDirection? direction,
            string? disconnectionReason,
            string? summary,
            global::RetellAI.ContactCallSentiment? sentiment,
            bool? successful)
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.StartTimestamp = startTimestamp;
            this.DurationMs = durationMs;
            this.Direction = direction;
            this.DisconnectionReason = disconnectionReason;
            this.Summary = summary;
            this.Sentiment = sentiment;
            this.Successful = successful;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactCall" /> class.
        /// </summary>
        public ContactCall()
        {
        }

    }
}