
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Transcription error details for a single utterance.
    /// </summary>
    public sealed partial class UtteranceTranscriptionError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.Duration Duration { get; set; }

        /// <summary>
        /// Mistranscribed important entities found in the utterance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mie_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.UtteranceTranscriptionErrorMieDetail> MieDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.Wer Wer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceTranscriptionError" /> class.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="mieDetails">
        /// Mistranscribed important entities found in the utterance.
        /// </param>
        /// <param name="wer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UtteranceTranscriptionError(
            global::RetellAI.Duration duration,
            global::System.Collections.Generic.IList<global::RetellAI.UtteranceTranscriptionErrorMieDetail> mieDetails,
            global::RetellAI.Wer wer)
        {
            this.Duration = duration ?? throw new global::System.ArgumentNullException(nameof(duration));
            this.MieDetails = mieDetails ?? throw new global::System.ArgumentNullException(nameof(mieDetails));
            this.Wer = wer ?? throw new global::System.ArgumentNullException(nameof(wer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceTranscriptionError" /> class.
        /// </summary>
        public UtteranceTranscriptionError()
        {
        }

    }
}