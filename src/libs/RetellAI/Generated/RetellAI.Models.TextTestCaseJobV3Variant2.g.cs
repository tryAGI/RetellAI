
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextTestCaseJobV3Variant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TextTestCaseJobV3Variant2TypeJsonConverter))]
        public global::RetellAI.TextTestCaseJobV3Variant2Type Type { get; set; }

        /// <summary>
        /// URL of the run's transcript, as JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_url")]
        public string? TranscriptUrl { get; set; }

        /// <summary>
        /// Performance metrics measured during the run. Paid metrics are only present when listed in the test case's `enabled_performance_metrics`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performance_metrics")]
        public global::RetellAI.TextTestCasePerformanceMetrics? PerformanceMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTestCaseJobV3Variant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="transcriptUrl">
        /// URL of the run's transcript, as JSON.
        /// </param>
        /// <param name="performanceMetrics">
        /// Performance metrics measured during the run. Paid metrics are only present when listed in the test case's `enabled_performance_metrics`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextTestCaseJobV3Variant2(
            global::RetellAI.TextTestCaseJobV3Variant2Type type,
            string? transcriptUrl,
            global::RetellAI.TextTestCasePerformanceMetrics? performanceMetrics)
        {
            this.Type = type;
            this.TranscriptUrl = transcriptUrl;
            this.PerformanceMetrics = performanceMetrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTestCaseJobV3Variant2" /> class.
        /// </summary>
        public TextTestCaseJobV3Variant2()
        {
        }

    }
}