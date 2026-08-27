
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SentimentAnalysisDetailVariant2
    {
        /// <summary>
        /// Identifier of the response associated with the evaluated utterance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public double? ResponseId { get; set; }

        /// <summary>
        /// Sentiment detected for the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SentimentAnalysisDetailVariant2SentimentJsonConverter))]
        public global::RetellAI.SentimentAnalysisDetailVariant2Sentiment? Sentiment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisDetailVariant2" /> class.
        /// </summary>
        /// <param name="responseId">
        /// Identifier of the response associated with the evaluated utterance.
        /// </param>
        /// <param name="sentiment">
        /// Sentiment detected for the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentimentAnalysisDetailVariant2(
            double? responseId,
            global::RetellAI.SentimentAnalysisDetailVariant2Sentiment? sentiment)
        {
            this.ResponseId = responseId;
            this.Sentiment = sentiment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisDetailVariant2" /> class.
        /// </summary>
        public SentimentAnalysisDetailVariant2()
        {
        }

    }
}