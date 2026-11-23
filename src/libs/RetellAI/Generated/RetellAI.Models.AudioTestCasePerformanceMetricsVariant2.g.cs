
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioTestCasePerformanceMetricsVariant2
    {
        /// <summary>
        /// Custom tool execution time percentiles, in milliseconds. Free. Omitted when no custom tool ran.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_latency")]
        public global::RetellAI.AudioTestCasePerformanceMetricsVariant2ToolLatency? ToolLatency { get; set; }

        /// <summary>
        /// End-to-end latency percentiles (from the caller stopping to the agent starting to talk), in milliseconds. Free.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public global::RetellAI.AudioTestCasePerformanceMetricsVariant2Latency? Latency { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AudioTestCasePerformanceMetricsVariant2Interruption Interruption { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("talk_ratio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AudioTestCasePerformanceMetricsVariant2TalkRatio TalkRatio { get; set; }

        /// <summary>
        /// Accuracy of the agent's transcription of the caller. Paid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::RetellAI.AudioTestCasePerformanceMetricsVariant2Transcription? Transcription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCasePerformanceMetricsVariant2" /> class.
        /// </summary>
        /// <param name="interruption"></param>
        /// <param name="talkRatio"></param>
        /// <param name="toolLatency">
        /// Custom tool execution time percentiles, in milliseconds. Free. Omitted when no custom tool ran.
        /// </param>
        /// <param name="latency">
        /// End-to-end latency percentiles (from the caller stopping to the agent starting to talk), in milliseconds. Free.
        /// </param>
        /// <param name="transcription">
        /// Accuracy of the agent's transcription of the caller. Paid.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTestCasePerformanceMetricsVariant2(
            global::RetellAI.AudioTestCasePerformanceMetricsVariant2Interruption interruption,
            global::RetellAI.AudioTestCasePerformanceMetricsVariant2TalkRatio talkRatio,
            global::RetellAI.AudioTestCasePerformanceMetricsVariant2ToolLatency? toolLatency,
            global::RetellAI.AudioTestCasePerformanceMetricsVariant2Latency? latency,
            global::RetellAI.AudioTestCasePerformanceMetricsVariant2Transcription? transcription)
        {
            this.ToolLatency = toolLatency;
            this.Latency = latency;
            this.Interruption = interruption ?? throw new global::System.ArgumentNullException(nameof(interruption));
            this.TalkRatio = talkRatio ?? throw new global::System.ArgumentNullException(nameof(talkRatio));
            this.Transcription = transcription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCasePerformanceMetricsVariant2" /> class.
        /// </summary>
        public AudioTestCasePerformanceMetricsVariant2()
        {
        }

    }
}