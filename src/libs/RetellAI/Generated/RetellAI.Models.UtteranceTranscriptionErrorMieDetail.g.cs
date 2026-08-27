
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UtteranceTranscriptionErrorMieDetail
    {
        /// <summary>
        /// The original (mistranscribed) transcript segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalTranscript { get; set; }

        /// <summary>
        /// The corrected transcript segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corrected_transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CorrectedTranscript { get; set; }

        /// <summary>
        /// Start time of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartSec { get; set; }

        /// <summary>
        /// End time of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceTranscriptionErrorMieDetail" /> class.
        /// </summary>
        /// <param name="originalTranscript">
        /// The original (mistranscribed) transcript segment.
        /// </param>
        /// <param name="correctedTranscript">
        /// The corrected transcript segment.
        /// </param>
        /// <param name="startSec">
        /// Start time of the segment in seconds.
        /// </param>
        /// <param name="endSec">
        /// End time of the segment in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UtteranceTranscriptionErrorMieDetail(
            string originalTranscript,
            string correctedTranscript,
            double startSec,
            double endSec)
        {
            this.OriginalTranscript = originalTranscript ?? throw new global::System.ArgumentNullException(nameof(originalTranscript));
            this.CorrectedTranscript = correctedTranscript ?? throw new global::System.ArgumentNullException(nameof(correctedTranscript));
            this.StartSec = startSec;
            this.EndSec = endSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceTranscriptionErrorMieDetail" /> class.
        /// </summary>
        public UtteranceTranscriptionErrorMieDetail()
        {
        }

    }
}