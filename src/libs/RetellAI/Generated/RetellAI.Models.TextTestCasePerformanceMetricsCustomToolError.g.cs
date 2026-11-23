
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Free.
    /// </summary>
    public sealed partial class TextTestCasePerformanceMetricsCustomToolError
    {
        /// <summary>
        /// Share of custom tool executions that failed. Omitted when there were none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// Custom tool executions that failed.
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
        /// Initializes a new instance of the <see cref="TextTestCasePerformanceMetricsCustomToolError" /> class.
        /// </summary>
        /// <param name="count">
        /// Custom tool executions that failed.
        /// </param>
        /// <param name="rate">
        /// Share of custom tool executions that failed. Omitted when there were none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextTestCasePerformanceMetricsCustomToolError(
            int count,
            double? rate)
        {
            this.Rate = rate;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTestCasePerformanceMetricsCustomToolError" /> class.
        /// </summary>
        public TextTestCasePerformanceMetricsCustomToolError()
        {
        }

    }
}