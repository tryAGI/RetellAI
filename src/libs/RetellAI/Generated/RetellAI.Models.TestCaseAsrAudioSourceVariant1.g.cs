
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestCaseAsrAudioSourceVariant1
    {
        /// <summary>
        /// Audio from an uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TestCaseAsrAudioSourceVariant1TypeJsonConverter))]
        public global::RetellAI.TestCaseAsrAudioSourceVariant1Type Type { get; set; }

        /// <summary>
        /// URL of a test audio upload from the same organization. Each definition returns the URL of its own retained copy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseAsrAudioSourceVariant1" /> class.
        /// </summary>
        /// <param name="audioUrl">
        /// URL of a test audio upload from the same organization. Each definition returns the URL of its own retained copy.
        /// </param>
        /// <param name="type">
        /// Audio from an uploaded file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseAsrAudioSourceVariant1(
            string audioUrl,
            global::RetellAI.TestCaseAsrAudioSourceVariant1Type type)
        {
            this.Type = type;
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseAsrAudioSourceVariant1" /> class.
        /// </summary>
        public TestCaseAsrAudioSourceVariant1()
        {
        }

    }
}