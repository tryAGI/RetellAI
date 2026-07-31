
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Knowledge base retrieval accuracy and recall analysis.
    /// </summary>
    public sealed partial class RAGAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.RAGAccuracy> Details { get; set; }

        /// <summary>
        /// Number of responses with accurate retrieval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_accurate_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RagAccurateCount { get; set; }

        /// <summary>
        /// Number of responses with full chunk recall.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_full_recall_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RagFullRecallCount { get; set; }

        /// <summary>
        /// Total number of retrieval events evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RagTotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="ragAccurateCount">
        /// Number of responses with accurate retrieval.
        /// </param>
        /// <param name="ragFullRecallCount">
        /// Number of responses with full chunk recall.
        /// </param>
        /// <param name="ragTotalCount">
        /// Total number of retrieval events evaluated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RAGAnalysis(
            global::System.Collections.Generic.IList<global::RetellAI.RAGAccuracy> details,
            double ragAccurateCount,
            double ragFullRecallCount,
            double ragTotalCount)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.RagAccurateCount = ragAccurateCount;
            this.RagFullRecallCount = ragFullRecallCount;
            this.RagTotalCount = ragTotalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGAnalysis" /> class.
        /// </summary>
        public RAGAnalysis()
        {
        }

    }
}