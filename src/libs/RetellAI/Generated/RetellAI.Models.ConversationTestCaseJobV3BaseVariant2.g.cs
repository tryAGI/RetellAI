
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationTestCaseJobV3BaseVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_criteria_results")]
        public global::System.Collections.Generic.IList<global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResult>? EvalCriteriaResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTestCaseJobV3BaseVariant2" /> class.
        /// </summary>
        /// <param name="evalCriteriaResults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationTestCaseJobV3BaseVariant2(
            global::System.Collections.Generic.IList<global::RetellAI.ConversationTestCaseJobV3BaseVariant2EvalCriteriaResult>? evalCriteriaResults)
        {
            this.EvalCriteriaResults = evalCriteriaResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTestCaseJobV3BaseVariant2" /> class.
        /// </summary>
        public ConversationTestCaseJobV3BaseVariant2()
        {
        }

    }
}