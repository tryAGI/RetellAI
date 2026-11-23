
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AsrGroundTruthUtteranceVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AsrGroundTruthUtteranceVariant2RoleJsonConverter))]
        public global::RetellAI.AsrGroundTruthUtteranceVariant2Role? Role { get; set; }

        /// <summary>
        /// When the utterance starts, in seconds from the start of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// When the utterance ends, in seconds from the start of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsrGroundTruthUtteranceVariant2" /> class.
        /// </summary>
        /// <param name="start">
        /// When the utterance starts, in seconds from the start of the audio.
        /// </param>
        /// <param name="end">
        /// When the utterance ends, in seconds from the start of the audio.
        /// </param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsrGroundTruthUtteranceVariant2(
            double start,
            double end,
            global::RetellAI.AsrGroundTruthUtteranceVariant2Role? role)
        {
            this.Role = role;
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsrGroundTruthUtteranceVariant2" /> class.
        /// </summary>
        public AsrGroundTruthUtteranceVariant2()
        {
        }

    }
}