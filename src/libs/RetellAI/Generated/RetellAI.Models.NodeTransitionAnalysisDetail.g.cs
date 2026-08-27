
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NodeTransitionAnalysisDetail
    {
        /// <summary>
        /// Time of the transition relative to the call start.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TimeSec { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accurate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Accurate { get; set; }

        /// <summary>
        /// ID of the node that should have been selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("correct_node_id")]
        public double? CorrectNodeId { get; set; }

        /// <summary>
        /// Explanation of why the transition was inaccurate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTransitionAnalysisDetail" /> class.
        /// </summary>
        /// <param name="timeSec">
        /// Time of the transition relative to the call start.
        /// </param>
        /// <param name="accurate"></param>
        /// <param name="correctNodeId">
        /// ID of the node that should have been selected.
        /// </param>
        /// <param name="reasoning">
        /// Explanation of why the transition was inaccurate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeTransitionAnalysisDetail(
            double timeSec,
            bool accurate,
            double? correctNodeId,
            string? reasoning)
        {
            this.TimeSec = timeSec;
            this.Accurate = accurate;
            this.CorrectNodeId = correctNodeId;
            this.Reasoning = reasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTransitionAnalysisDetail" /> class.
        /// </summary>
        public NodeTransitionAnalysisDetail()
        {
        }

    }
}