
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AsrTestCaseDefinitionV3InputVariant2
    {
        /// <summary>
        /// Transcribes audio with the agent's speech recognition settings and compares it to `ground_truth`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AsrTestCaseDefinitionV3InputVariant2TypeJsonConverter))]
        public global::RetellAI.AsrTestCaseDefinitionV3InputVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsrTestCaseDefinitionV3InputVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Transcribes audio with the agent's speech recognition settings and compares it to `ground_truth`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsrTestCaseDefinitionV3InputVariant2(
            global::RetellAI.AsrTestCaseDefinitionV3InputVariant2Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsrTestCaseDefinitionV3InputVariant2" /> class.
        /// </summary>
        public AsrTestCaseDefinitionV3InputVariant2()
        {
        }

    }
}