
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Conversation flow node transition accuracy analysis.
    /// </summary>
    public sealed partial class NodeTransitionAnalysis
    {
        /// <summary>
        /// Per-transition audit results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.NodeTransitionAnalysisDetail> Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("correct_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CorrectCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTransitionAnalysis" /> class.
        /// </summary>
        /// <param name="details">
        /// Per-transition audit results.
        /// </param>
        /// <param name="correctCount"></param>
        /// <param name="totalCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeTransitionAnalysis(
            global::System.Collections.Generic.IList<global::RetellAI.NodeTransitionAnalysisDetail> details,
            double correctCount,
            double totalCount)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.CorrectCount = correctCount;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTransitionAnalysis" /> class.
        /// </summary>
        public NodeTransitionAnalysis()
        {
        }

    }
}