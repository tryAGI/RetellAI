
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestCaseBatchJobV3TestCase
    {
        /// <summary>
        /// ID of the test case to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_definition_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestCaseDefinitionId { get; set; }

        /// <summary>
        /// Number of times to run the test case. Must be 1 for ASR test cases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseBatchJobV3TestCase" /> class.
        /// </summary>
        /// <param name="testCaseDefinitionId">
        /// ID of the test case to run.
        /// </param>
        /// <param name="runCount">
        /// Number of times to run the test case. Must be 1 for ASR test cases.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseBatchJobV3TestCase(
            string testCaseDefinitionId,
            int runCount)
        {
            this.TestCaseDefinitionId = testCaseDefinitionId ?? throw new global::System.ArgumentNullException(nameof(testCaseDefinitionId));
            this.RunCount = runCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseBatchJobV3TestCase" /> class.
        /// </summary>
        public TestCaseBatchJobV3TestCase()
        {
        }

    }
}