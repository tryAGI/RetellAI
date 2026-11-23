
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestCaseEvalCriterionVariant2
    {
        /// <summary>
        /// Checks a value from the run. Refer to a dynamic variable as `{{variable_name}}`, including ones extracted during the conversation. Refer to a performance metric as `{{metrics.category.field}}`, for example `{{metrics.latency.p50}}`. Use the `exists` operator to check whether a metric was measured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TestCaseEvalCriterionVariant2TypeJsonConverter))]
        public global::RetellAI.TestCaseEvalCriterionVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.Equation Equation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseEvalCriterionVariant2" /> class.
        /// </summary>
        /// <param name="equation"></param>
        /// <param name="type">
        /// Checks a value from the run. Refer to a dynamic variable as `{{variable_name}}`, including ones extracted during the conversation. Refer to a performance metric as `{{metrics.category.field}}`, for example `{{metrics.latency.p50}}`. Use the `exists` operator to check whether a metric was measured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseEvalCriterionVariant2(
            global::RetellAI.Equation equation,
            global::RetellAI.TestCaseEvalCriterionVariant2Type type)
        {
            this.Type = type;
            this.Equation = equation ?? throw new global::System.ArgumentNullException(nameof(equation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseEvalCriterionVariant2" /> class.
        /// </summary>
        public TestCaseEvalCriterionVariant2()
        {
        }

    }
}