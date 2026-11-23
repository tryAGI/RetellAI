
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// End-to-end latency percentiles (from the caller stopping to the agent starting to talk), in milliseconds. Free.
    /// </summary>
    public sealed partial class AudioTestCasePerformanceMetricsVariant2Latency
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P50 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P90 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P95 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P99 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCasePerformanceMetricsVariant2Latency" /> class.
        /// </summary>
        /// <param name="p50"></param>
        /// <param name="p90"></param>
        /// <param name="p95"></param>
        /// <param name="p99"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTestCasePerformanceMetricsVariant2Latency(
            double p50,
            double p90,
            double p95,
            double p99)
        {
            this.P50 = p50;
            this.P90 = p90;
            this.P95 = p95;
            this.P99 = p99;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCasePerformanceMetricsVariant2Latency" /> class.
        /// </summary>
        public AudioTestCasePerformanceMetricsVariant2Latency()
        {
        }

    }
}