
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestCaseEvalCriterionVariant1
    {
        /// <summary>
        /// An LLM judges the transcript against `prompt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TestCaseEvalCriterionVariant1TypeJsonConverter))]
        public global::RetellAI.TestCaseEvalCriterionVariant1Type Type { get; set; }

        /// <summary>
        /// What a passing conversation looks like, for example "The agent books an appointment for Tuesday."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseEvalCriterionVariant1" /> class.
        /// </summary>
        /// <param name="prompt">
        /// What a passing conversation looks like, for example "The agent books an appointment for Tuesday."
        /// </param>
        /// <param name="type">
        /// An LLM judges the transcript against `prompt`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseEvalCriterionVariant1(
            string prompt,
            global::RetellAI.TestCaseEvalCriterionVariant1Type type)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseEvalCriterionVariant1" /> class.
        /// </summary>
        public TestCaseEvalCriterionVariant1()
        {
        }

    }
}