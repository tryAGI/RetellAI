
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestCaseCallerInstructionsVariant2
    {
        /// <summary>
        /// The simulated caller follows the user turns of `transcript`. It adapts to the live agent's questions while preserving the caller's wording, facts, and intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TestCaseCallerInstructionsVariant2TypeJsonConverter))]
        public global::RetellAI.TestCaseCallerInstructionsVariant2Type Type { get; set; }

        /// <summary>
        /// Conversation turns, in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.TextUtterance, global::RetellAI.TestCaseInputTranscriptItem2>> Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseCallerInstructionsVariant2" /> class.
        /// </summary>
        /// <param name="transcript">
        /// Conversation turns, in order.
        /// </param>
        /// <param name="type">
        /// The simulated caller follows the user turns of `transcript`. It adapts to the live agent's questions while preserving the caller's wording, facts, and intent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseCallerInstructionsVariant2(
            global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.TextUtterance, global::RetellAI.TestCaseInputTranscriptItem2>> transcript,
            global::RetellAI.TestCaseCallerInstructionsVariant2Type type)
        {
            this.Type = type;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseCallerInstructionsVariant2" /> class.
        /// </summary>
        public TestCaseCallerInstructionsVariant2()
        {
        }

    }
}