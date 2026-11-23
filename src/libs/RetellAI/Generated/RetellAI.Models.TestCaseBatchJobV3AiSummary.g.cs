
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Summary of the failures in the batch test. Only set when the batch test is `complete`.
    /// </summary>
    public sealed partial class TestCaseBatchJobV3AiSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_cases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJobV3AiSummaryFailureCase> FailureCases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseBatchJobV3AiSummary" /> class.
        /// </summary>
        /// <param name="failureCases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseBatchJobV3AiSummary(
            global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJobV3AiSummaryFailureCase> failureCases)
        {
            this.FailureCases = failureCases ?? throw new global::System.ArgumentNullException(nameof(failureCases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseBatchJobV3AiSummary" /> class.
        /// </summary>
        public TestCaseBatchJobV3AiSummary()
        {
        }

    }
}