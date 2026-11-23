
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Paid.
    /// </summary>
    public sealed partial class TextTestCasePerformanceMetricsAgentHallucination
    {
        /// <summary>
        /// Share of agent responses that contained a hallucination. Omitted when there were none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// Agent responses that contained a hallucination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTestCasePerformanceMetricsAgentHallucination" /> class.
        /// </summary>
        /// <param name="count">
        /// Agent responses that contained a hallucination.
        /// </param>
        /// <param name="rate">
        /// Share of agent responses that contained a hallucination. Omitted when there were none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextTestCasePerformanceMetricsAgentHallucination(
            int count,
            double? rate)
        {
            this.Rate = rate;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTestCasePerformanceMetricsAgentHallucination" /> class.
        /// </summary>
        public TextTestCasePerformanceMetricsAgentHallucination()
        {
        }

    }
}