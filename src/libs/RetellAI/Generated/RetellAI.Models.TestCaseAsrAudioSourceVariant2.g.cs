
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestCaseAsrAudioSourceVariant2
    {
        /// <summary>
        /// Audio from part of an existing call's multichannel recording. The source call must have PII scrubbing disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TestCaseAsrAudioSourceVariant2TypeJsonConverter))]
        public global::RetellAI.TestCaseAsrAudioSourceVariant2Type Type { get; set; }

        /// <summary>
        /// ID of the call to take the audio from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Where the clip starts, in milliseconds from the start of the call. Defaults to the start of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_ms")]
        public int? StartMs { get; set; }

        /// <summary>
        /// Where the clip ends, in milliseconds from the start of the call. Defaults to the end of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_ms")]
        public int? EndMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseAsrAudioSourceVariant2" /> class.
        /// </summary>
        /// <param name="callId">
        /// ID of the call to take the audio from.
        /// </param>
        /// <param name="type">
        /// Audio from part of an existing call's multichannel recording. The source call must have PII scrubbing disabled.
        /// </param>
        /// <param name="startMs">
        /// Where the clip starts, in milliseconds from the start of the call. Defaults to the start of the call.
        /// </param>
        /// <param name="endMs">
        /// Where the clip ends, in milliseconds from the start of the call. Defaults to the end of the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseAsrAudioSourceVariant2(
            string callId,
            global::RetellAI.TestCaseAsrAudioSourceVariant2Type type,
            int? startMs,
            int? endMs)
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.StartMs = startMs;
            this.EndMs = endMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseAsrAudioSourceVariant2" /> class.
        /// </summary>
        public TestCaseAsrAudioSourceVariant2()
        {
        }

    }
}