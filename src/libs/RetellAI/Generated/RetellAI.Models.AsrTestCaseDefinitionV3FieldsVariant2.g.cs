
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AsrTestCaseDefinitionV3FieldsVariant2
    {
        /// <summary>
        /// The audio to transcribe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TestCaseAsrAudioSourceJsonConverter))]
        public global::RetellAI.TestCaseAsrAudioSource? AudioSource { get; set; }

        /// <summary>
        /// The correct transcript of the audio, as utterances in time order. The transcription is compared against the user utterances only. In user utterances, put square brackets around words that must appear in the transcription, for example `my dog [Biscuit]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_truth")]
        public global::System.Collections.Generic.IList<global::RetellAI.AsrGroundTruthUtterance>? GroundTruth { get; set; }

        /// <summary>
        /// Highest word error rate that still passes, for example 0.1 for 10%. Required unless a user utterance in `ground_truth` has a word in square brackets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_wer")]
        public double? MaxWer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsrTestCaseDefinitionV3FieldsVariant2" /> class.
        /// </summary>
        /// <param name="audioSource">
        /// The audio to transcribe.
        /// </param>
        /// <param name="groundTruth">
        /// The correct transcript of the audio, as utterances in time order. The transcription is compared against the user utterances only. In user utterances, put square brackets around words that must appear in the transcription, for example `my dog [Biscuit]`.
        /// </param>
        /// <param name="maxWer">
        /// Highest word error rate that still passes, for example 0.1 for 10%. Required unless a user utterance in `ground_truth` has a word in square brackets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsrTestCaseDefinitionV3FieldsVariant2(
            global::RetellAI.TestCaseAsrAudioSource? audioSource,
            global::System.Collections.Generic.IList<global::RetellAI.AsrGroundTruthUtterance>? groundTruth,
            double? maxWer)
        {
            this.AudioSource = audioSource;
            this.GroundTruth = groundTruth;
            this.MaxWer = maxWer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsrTestCaseDefinitionV3FieldsVariant2" /> class.
        /// </summary>
        public AsrTestCaseDefinitionV3FieldsVariant2()
        {
        }

    }
}