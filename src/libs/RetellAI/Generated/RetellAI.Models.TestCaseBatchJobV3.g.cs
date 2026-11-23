
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestCaseBatchJobV3
    {
        /// <summary>
        /// Unique ID of the batch test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_batch_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestCaseBatchJobId { get; set; }

        /// <summary>
        /// ID of the agent tested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Version of the agent tested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AgentVersion { get; set; }

        /// <summary>
        /// Test cases in the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_cases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJobV3TestCase> TestCases { get; set; }

        /// <summary>
        /// Status of the batch test. `cancelling` means cancellation was requested and runs are still stopping; it becomes `cancelled` once they have stopped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TestCaseBatchJobV3StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.TestCaseBatchJobV3Status Status { get; set; }

        /// <summary>
        /// Number of runs that passed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PassCount { get; set; }

        /// <summary>
        /// Number of runs that failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailCount { get; set; }

        /// <summary>
        /// Number of runs that encountered errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ErrorCount { get; set; }

        /// <summary>
        /// Number of runs that were cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CancelledCount { get; set; }

        /// <summary>
        /// Total number of runs in the batch, counting each run of a test case separately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// When the batch test was created, in milliseconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CreationTimestamp { get; set; }

        /// <summary>
        /// When the batch test was last modified, in milliseconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_modified_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserModifiedTimestamp { get; set; }

        /// <summary>
        /// When the batch test finished, in milliseconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_timestamp")]
        public long? CompletionTimestamp { get; set; }

        /// <summary>
        /// Cost of all runs in cents. Only set when the batch test is `complete` or `cancelled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// Summary of the failures in the batch test. Only set when the batch test is `complete`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_summary")]
        public global::RetellAI.TestCaseBatchJobV3AiSummary? AiSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseBatchJobV3" /> class.
        /// </summary>
        /// <param name="testCaseBatchJobId">
        /// Unique ID of the batch test.
        /// </param>
        /// <param name="agentId">
        /// ID of the agent tested.
        /// </param>
        /// <param name="agentVersion">
        /// Version of the agent tested.
        /// </param>
        /// <param name="testCases">
        /// Test cases in the batch.
        /// </param>
        /// <param name="status">
        /// Status of the batch test. `cancelling` means cancellation was requested and runs are still stopping; it becomes `cancelled` once they have stopped.
        /// </param>
        /// <param name="passCount">
        /// Number of runs that passed.
        /// </param>
        /// <param name="failCount">
        /// Number of runs that failed.
        /// </param>
        /// <param name="errorCount">
        /// Number of runs that encountered errors.
        /// </param>
        /// <param name="cancelledCount">
        /// Number of runs that were cancelled.
        /// </param>
        /// <param name="totalCount">
        /// Total number of runs in the batch, counting each run of a test case separately.
        /// </param>
        /// <param name="creationTimestamp">
        /// When the batch test was created, in milliseconds since epoch.
        /// </param>
        /// <param name="userModifiedTimestamp">
        /// When the batch test was last modified, in milliseconds since epoch.
        /// </param>
        /// <param name="completionTimestamp">
        /// When the batch test finished, in milliseconds since epoch.
        /// </param>
        /// <param name="totalCost">
        /// Cost of all runs in cents. Only set when the batch test is `complete` or `cancelled`.
        /// </param>
        /// <param name="aiSummary">
        /// Summary of the failures in the batch test. Only set when the batch test is `complete`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseBatchJobV3(
            string testCaseBatchJobId,
            string agentId,
            int agentVersion,
            global::System.Collections.Generic.IList<global::RetellAI.TestCaseBatchJobV3TestCase> testCases,
            global::RetellAI.TestCaseBatchJobV3Status status,
            int passCount,
            int failCount,
            int errorCount,
            int cancelledCount,
            int totalCount,
            long creationTimestamp,
            long userModifiedTimestamp,
            long? completionTimestamp,
            double? totalCost,
            global::RetellAI.TestCaseBatchJobV3AiSummary? aiSummary)
        {
            this.TestCaseBatchJobId = testCaseBatchJobId ?? throw new global::System.ArgumentNullException(nameof(testCaseBatchJobId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentVersion = agentVersion;
            this.TestCases = testCases ?? throw new global::System.ArgumentNullException(nameof(testCases));
            this.Status = status;
            this.PassCount = passCount;
            this.FailCount = failCount;
            this.ErrorCount = errorCount;
            this.CancelledCount = cancelledCount;
            this.TotalCount = totalCount;
            this.CreationTimestamp = creationTimestamp;
            this.UserModifiedTimestamp = userModifiedTimestamp;
            this.CompletionTimestamp = completionTimestamp;
            this.TotalCost = totalCost;
            this.AiSummary = aiSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseBatchJobV3" /> class.
        /// </summary>
        public TestCaseBatchJobV3()
        {
        }

    }
}