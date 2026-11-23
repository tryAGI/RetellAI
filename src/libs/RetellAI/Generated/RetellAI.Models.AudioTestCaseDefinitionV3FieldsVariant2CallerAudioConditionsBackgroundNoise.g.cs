
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoise
    {
        /// <summary>
        /// Background sound mixed into the caller's audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sound")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSoundJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound Sound { get; set; }

        /// <summary>
        /// Volume of the background sound, from 0 to 2. Defaults to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoise" /> class.
        /// </summary>
        /// <param name="sound">
        /// Background sound mixed into the caller's audio.
        /// </param>
        /// <param name="volume">
        /// Volume of the background sound, from 0 to 2. Defaults to 1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoise(
            global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoiseSound sound,
            double? volume)
        {
            this.Sound = sound;
            this.Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoise" /> class.
        /// </summary>
        public AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoise()
        {
        }

    }
}