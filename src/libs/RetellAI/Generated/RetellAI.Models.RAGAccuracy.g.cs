
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Knowledge base retrieval accuracy for one agent response.
    /// </summary>
    public sealed partial class RAGAccuracy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public double? ResponseId { get; set; }

        /// <summary>
        /// Number of chunks retrieved during the call but deemed irrelevant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("false_positive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FalsePositive { get; set; }

        /// <summary>
        /// Number of relevant chunks that were not retrieved during the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("false_negative")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FalseNegative { get; set; }

        /// <summary>
        /// Number of chunks retrieved during the call and deemed relevant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("true_positive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TruePositive { get; set; }

        /// <summary>
        /// Relevant knowledge base chunks that were not retrieved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missed_chunks")]
        public global::System.Collections.Generic.IList<global::RetellAI.RAGAccuracyMissedChunk>? MissedChunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGAccuracy" /> class.
        /// </summary>
        /// <param name="falsePositive">
        /// Number of chunks retrieved during the call but deemed irrelevant.
        /// </param>
        /// <param name="falseNegative">
        /// Number of relevant chunks that were not retrieved during the call.
        /// </param>
        /// <param name="truePositive">
        /// Number of chunks retrieved during the call and deemed relevant.
        /// </param>
        /// <param name="responseId"></param>
        /// <param name="missedChunks">
        /// Relevant knowledge base chunks that were not retrieved.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RAGAccuracy(
            double falsePositive,
            double falseNegative,
            double truePositive,
            double? responseId,
            global::System.Collections.Generic.IList<global::RetellAI.RAGAccuracyMissedChunk>? missedChunks)
        {
            this.ResponseId = responseId;
            this.FalsePositive = falsePositive;
            this.FalseNegative = falseNegative;
            this.TruePositive = truePositive;
            this.MissedChunks = missedChunks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGAccuracy" /> class.
        /// </summary>
        public RAGAccuracy()
        {
        }

    }
}