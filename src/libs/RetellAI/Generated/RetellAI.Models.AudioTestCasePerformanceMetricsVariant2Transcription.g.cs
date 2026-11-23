
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Accuracy of the agent's transcription of the caller. Paid.
    /// </summary>
    public sealed partial class AudioTestCasePerformanceMetricsVariant2Transcription
    {
        /// <summary>
        /// Word error rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Wer { get; set; }

        /// <summary>
        /// Caller utterances with at least one mistranscription that changes meaning, such as a wrong name, number, or key fact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("critical_errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CriticalErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCasePerformanceMetricsVariant2Transcription" /> class.
        /// </summary>
        /// <param name="wer">
        /// Word error rate.
        /// </param>
        /// <param name="criticalErrors">
        /// Caller utterances with at least one mistranscription that changes meaning, such as a wrong name, number, or key fact.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTestCasePerformanceMetricsVariant2Transcription(
            double wer,
            int criticalErrors)
        {
            this.Wer = wer;
            this.CriticalErrors = criticalErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCasePerformanceMetricsVariant2Transcription" /> class.
        /// </summary>
        public AudioTestCasePerformanceMetricsVariant2Transcription()
        {
        }

    }
}