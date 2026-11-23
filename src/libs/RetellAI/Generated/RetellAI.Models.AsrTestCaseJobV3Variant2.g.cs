
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AsrTestCaseJobV3Variant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AsrTestCaseJobV3Variant2TypeJsonConverter))]
        public global::RetellAI.AsrTestCaseJobV3Variant2Type Type { get; set; }

        /// <summary>
        /// URL of the replay's transcript, as JSON. User utterances come from speech recognition and include only committed turns. Agent utterances come from the source call or the upload's ground truth.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_url")]
        public string? TranscriptUrl { get; set; }

        /// <summary>
        /// Word error rate of committed user turns against the user utterances in the ground truth.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wer")]
        public double? Wer { get; set; }

        /// <summary>
        /// Words in square brackets in the ground truth that did not appear in committed user turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing_words")]
        public global::System.Collections.Generic.IList<string>? MissingWords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsrTestCaseJobV3Variant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="transcriptUrl">
        /// URL of the replay's transcript, as JSON. User utterances come from speech recognition and include only committed turns. Agent utterances come from the source call or the upload's ground truth.
        /// </param>
        /// <param name="wer">
        /// Word error rate of committed user turns against the user utterances in the ground truth.
        /// </param>
        /// <param name="missingWords">
        /// Words in square brackets in the ground truth that did not appear in committed user turns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsrTestCaseJobV3Variant2(
            global::RetellAI.AsrTestCaseJobV3Variant2Type type,
            string? transcriptUrl,
            double? wer,
            global::System.Collections.Generic.IList<string>? missingWords)
        {
            this.Type = type;
            this.TranscriptUrl = transcriptUrl;
            this.Wer = wer;
            this.MissingWords = missingWords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsrTestCaseJobV3Variant2" /> class.
        /// </summary>
        public AsrTestCaseJobV3Variant2()
        {
        }

    }
}