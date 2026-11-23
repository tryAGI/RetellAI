
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Conditions applied to the simulated caller's audio.
    /// </summary>
    public sealed partial class AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noise")]
        public global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoise? BackgroundNoise { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditions" /> class.
        /// </summary>
        /// <param name="backgroundNoise"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditions(
            global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditionsBackgroundNoise? backgroundNoise)
        {
            this.BackgroundNoise = backgroundNoise;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditions" /> class.
        /// </summary>
        public AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditions()
        {
        }

    }
}