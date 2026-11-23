
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestCaseJobV3Base
    {
        /// <summary>
        /// Unique ID of the test run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestCaseJobId { get; set; }

        /// <summary>
        /// ID of the test case this run is for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_definition_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestCaseDefinitionId { get; set; }

        /// <summary>
        /// ID of the batch test this run belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_batch_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestCaseBatchJobId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition_snapshot")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TestCaseDefinitionV3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.TestCaseDefinitionV3 DefinitionSnapshot { get; set; }

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
        /// Status of the test run. `pending` means the run is queued but has not started yet; it becomes `in_progress` once it starts, then resolves to `pass`, `fail`, or `error`. `cancelled` means the batch test was cancelled before the run finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.TestCaseJobV3BaseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.TestCaseJobV3BaseStatus Status { get; set; }

        /// <summary>
        /// When the run was created, in milliseconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CreationTimestamp { get; set; }

        /// <summary>
        /// When the run was last modified, in milliseconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_modified_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserModifiedTimestamp { get; set; }

        /// <summary>
        /// When the run finished, in milliseconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_timestamp")]
        public long? CompletionTimestamp { get; set; }

        /// <summary>
        /// Cost of the run in cents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("combined_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CombinedCost { get; set; }

        /// <summary>
        /// Why the run failed to complete. Only set when `status` is `error`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseJobV3Base" /> class.
        /// </summary>
        /// <param name="testCaseJobId">
        /// Unique ID of the test run.
        /// </param>
        /// <param name="testCaseDefinitionId">
        /// ID of the test case this run is for.
        /// </param>
        /// <param name="testCaseBatchJobId">
        /// ID of the batch test this run belongs to.
        /// </param>
        /// <param name="definitionSnapshot"></param>
        /// <param name="agentId">
        /// ID of the agent tested.
        /// </param>
        /// <param name="agentVersion">
        /// Version of the agent tested.
        /// </param>
        /// <param name="status">
        /// Status of the test run. `pending` means the run is queued but has not started yet; it becomes `in_progress` once it starts, then resolves to `pass`, `fail`, or `error`. `cancelled` means the batch test was cancelled before the run finished.
        /// </param>
        /// <param name="creationTimestamp">
        /// When the run was created, in milliseconds since epoch.
        /// </param>
        /// <param name="userModifiedTimestamp">
        /// When the run was last modified, in milliseconds since epoch.
        /// </param>
        /// <param name="combinedCost">
        /// Cost of the run in cents.
        /// </param>
        /// <param name="completionTimestamp">
        /// When the run finished, in milliseconds since epoch.
        /// </param>
        /// <param name="errorMessage">
        /// Why the run failed to complete. Only set when `status` is `error`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseJobV3Base(
            string testCaseJobId,
            string testCaseDefinitionId,
            string testCaseBatchJobId,
            global::RetellAI.TestCaseDefinitionV3 definitionSnapshot,
            string agentId,
            int agentVersion,
            global::RetellAI.TestCaseJobV3BaseStatus status,
            long creationTimestamp,
            long userModifiedTimestamp,
            double combinedCost,
            long? completionTimestamp,
            string? errorMessage)
        {
            this.TestCaseJobId = testCaseJobId ?? throw new global::System.ArgumentNullException(nameof(testCaseJobId));
            this.TestCaseDefinitionId = testCaseDefinitionId ?? throw new global::System.ArgumentNullException(nameof(testCaseDefinitionId));
            this.TestCaseBatchJobId = testCaseBatchJobId ?? throw new global::System.ArgumentNullException(nameof(testCaseBatchJobId));
            this.DefinitionSnapshot = definitionSnapshot;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentVersion = agentVersion;
            this.Status = status;
            this.CreationTimestamp = creationTimestamp;
            this.UserModifiedTimestamp = userModifiedTimestamp;
            this.CompletionTimestamp = completionTimestamp;
            this.CombinedCost = combinedCost;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseJobV3Base" /> class.
        /// </summary>
        public TestCaseJobV3Base()
        {
        }

    }
}