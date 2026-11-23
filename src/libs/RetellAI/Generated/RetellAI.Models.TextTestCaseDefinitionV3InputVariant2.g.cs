
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextTestCaseDefinitionV3InputVariant2
    {
        /// <summary>
        /// The agent and the simulated caller talk in text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TextTestCaseDefinitionV3InputVariant2TypeJsonConverter))]
        public global::RetellAI.TextTestCaseDefinitionV3InputVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTestCaseDefinitionV3InputVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The agent and the simulated caller talk in text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextTestCaseDefinitionV3InputVariant2(
            global::RetellAI.TextTestCaseDefinitionV3InputVariant2Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTestCaseDefinitionV3InputVariant2" /> class.
        /// </summary>
        public TextTestCaseDefinitionV3InputVariant2()
        {
        }

    }
}