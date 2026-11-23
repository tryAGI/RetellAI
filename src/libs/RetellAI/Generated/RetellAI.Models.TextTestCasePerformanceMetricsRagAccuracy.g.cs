
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Knowledge base retrievals. Paid. Omitted when nothing was retrieved.
    /// </summary>
    public sealed partial class TextTestCasePerformanceMetricsRagAccuracy
    {
        /// <summary>
        /// Share of retrievals that returned every relevant chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTestCasePerformanceMetricsRagAccuracy" /> class.
        /// </summary>
        /// <param name="rate">
        /// Share of retrievals that returned every relevant chunk.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextTestCasePerformanceMetricsRagAccuracy(
            double rate)
        {
            this.Rate = rate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTestCasePerformanceMetricsRagAccuracy" /> class.
        /// </summary>
        public TextTestCasePerformanceMetricsRagAccuracy()
        {
        }

    }
}