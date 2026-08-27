
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Transcription error analysis for a call, covering mistranscribed important entities and the overall word error rate.
    /// </summary>
    public sealed partial class TranscriptionErrorAnalysis
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.UtteranceTranscriptionError> Details { get; set; }

        /// <summary>
        /// Number of utterances containing a mistranscribed important entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mie_utterance_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MieUtteranceCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_utterance_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalUtteranceCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_wer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.Wer OverallWer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionErrorAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="mieUtteranceCount">
        /// Number of utterances containing a mistranscribed important entity.
        /// </param>
        /// <param name="totalUtteranceCount"></param>
        /// <param name="overallWer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionErrorAnalysis(
            global::System.Collections.Generic.IList<global::RetellAI.UtteranceTranscriptionError> details,
            double mieUtteranceCount,
            double totalUtteranceCount,
            global::RetellAI.Wer overallWer)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.MieUtteranceCount = mieUtteranceCount;
            this.TotalUtteranceCount = totalUtteranceCount;
            this.OverallWer = overallWer ?? throw new global::System.ArgumentNullException(nameof(overallWer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionErrorAnalysis" /> class.
        /// </summary>
        public TranscriptionErrorAnalysis()
        {
        }

    }
}