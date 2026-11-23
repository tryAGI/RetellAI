
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioTestCaseDefinitionV3FieldsVariant2
    {
        /// <summary>
        /// Voice of the simulated caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Conditions applied to the simulated caller's audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_audio_conditions")]
        public global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditions? CallerAudioConditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCaseDefinitionV3FieldsVariant2" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Voice of the simulated caller.
        /// </param>
        /// <param name="callerAudioConditions">
        /// Conditions applied to the simulated caller's audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTestCaseDefinitionV3FieldsVariant2(
            string? voiceId,
            global::RetellAI.AudioTestCaseDefinitionV3FieldsVariant2CallerAudioConditions? callerAudioConditions)
        {
            this.VoiceId = voiceId;
            this.CallerAudioConditions = callerAudioConditions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTestCaseDefinitionV3FieldsVariant2" /> class.
        /// </summary>
        public AudioTestCaseDefinitionV3FieldsVariant2()
        {
        }

    }
}