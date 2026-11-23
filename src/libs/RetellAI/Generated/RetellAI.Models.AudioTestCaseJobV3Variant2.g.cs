
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioTestCaseJobV3Variant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AudioTestCaseJobV3Variant2TypeJsonConverter))]
        public global::RetellAI.AudioTestCaseJobV3Variant2Type Type { get; set; }

        /// <summary>
        /// URL of the run's transcript, as JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_url")]
        public string? TranscriptUrl { get; set; }

        /// <summary>
        /// URL of the run's audio recording.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_url")]
        public string? RecordingUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performance_metrics")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AudioTestCasePerformanceMetricsJsonConverter))]
        public global::RetellAI.AudioTestCasePerformanceMetrics? PerformanceMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCaseJobV3Variant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="transcriptUrl">
        /// URL of the run's transcript, as JSON.
        /// </param>
        /// <param name="recordingUrl">
        /// URL of the run's audio recording.
        /// </param>
        /// <param name="performanceMetrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTestCaseJobV3Variant2(
            global::RetellAI.AudioTestCaseJobV3Variant2Type type,
            string? transcriptUrl,
            string? recordingUrl,
            global::RetellAI.AudioTestCasePerformanceMetrics? performanceMetrics)
        {
            this.Type = type;
            this.TranscriptUrl = transcriptUrl;
            this.RecordingUrl = recordingUrl;
            this.PerformanceMetrics = performanceMetrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCaseJobV3Variant2" /> class.
        /// </summary>
        public AudioTestCaseJobV3Variant2()
        {
        }

    }
}