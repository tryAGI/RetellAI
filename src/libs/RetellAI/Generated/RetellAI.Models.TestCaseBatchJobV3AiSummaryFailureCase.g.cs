
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestCaseBatchJobV3AiSummaryFailureCase
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// IDs of the test runs where the failure was seen.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_job_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TestCaseJobIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseBatchJobV3AiSummaryFailureCase" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="testCaseJobIds">
        /// IDs of the test runs where the failure was seen.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseBatchJobV3AiSummaryFailureCase(
            string title,
            string description,
            global::System.Collections.Generic.IList<string> testCaseJobIds)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.TestCaseJobIds = testCaseJobIds ?? throw new global::System.ArgumentNullException(nameof(testCaseJobIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseBatchJobV3AiSummaryFailureCase" /> class.
        /// </summary>
        public TestCaseBatchJobV3AiSummaryFailureCase()
        {
        }

    }
}