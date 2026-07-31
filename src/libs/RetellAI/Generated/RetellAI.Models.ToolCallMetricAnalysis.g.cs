
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Per-invocation latency and success outcomes for a group of tool calls (e.g. custom tools or transfer calls).
    /// </summary>
    public sealed partial class ToolCallMetricAnalysis
    {
        /// <summary>
        /// Whether each tool call succeeded, in invocation order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<bool> Successful { get; set; }

        /// <summary>
        /// Latency of each tool call in milliseconds, in invocation order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Latency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallMetricAnalysis" /> class.
        /// </summary>
        /// <param name="successful">
        /// Whether each tool call succeeded, in invocation order.
        /// </param>
        /// <param name="latency">
        /// Latency of each tool call in milliseconds, in invocation order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallMetricAnalysis(
            global::System.Collections.Generic.IList<bool> successful,
            global::System.Collections.Generic.IList<double> latency)
        {
            this.Successful = successful ?? throw new global::System.ArgumentNullException(nameof(successful));
            this.Latency = latency ?? throw new global::System.ArgumentNullException(nameof(latency));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallMetricAnalysis" /> class.
        /// </summary>
        public ToolCallMetricAnalysis()
        {
        }

    }
}