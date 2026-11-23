
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Paid. Only for conversation flow agents.
    /// </summary>
    public sealed partial class TextTestCasePerformanceMetricsNodeTransitionInaccuracy
    {
        /// <summary>
        /// Share of node transitions that went to the wrong node. Omitted when there were none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// Node transitions that went to the wrong node.
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
        /// Initializes a new instance of the <see cref="TextTestCasePerformanceMetricsNodeTransitionInaccuracy" /> class.
        /// </summary>
        /// <param name="count">
        /// Node transitions that went to the wrong node.
        /// </param>
        /// <param name="rate">
        /// Share of node transitions that went to the wrong node. Omitted when there were none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextTestCasePerformanceMetricsNodeTransitionInaccuracy(
            int count,
            double? rate)
        {
            this.Rate = rate;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTestCasePerformanceMetricsNodeTransitionInaccuracy" /> class.
        /// </summary>
        public TextTestCasePerformanceMetricsNodeTransitionInaccuracy()
        {
        }

    }
}