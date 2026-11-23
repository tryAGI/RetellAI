
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestCaseDefinitionV3Metadata
    {
        /// <summary>
        /// Unique ID of the test case.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_definition_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestCaseDefinitionId { get; set; }

        /// <summary>
        /// When the test case was created, in milliseconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CreationTimestamp { get; set; }

        /// <summary>
        /// When the test case was last modified, in milliseconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_modified_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserModifiedTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseDefinitionV3Metadata" /> class.
        /// </summary>
        /// <param name="testCaseDefinitionId">
        /// Unique ID of the test case.
        /// </param>
        /// <param name="creationTimestamp">
        /// When the test case was created, in milliseconds since epoch.
        /// </param>
        /// <param name="userModifiedTimestamp">
        /// When the test case was last modified, in milliseconds since epoch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseDefinitionV3Metadata(
            string testCaseDefinitionId,
            long creationTimestamp,
            long userModifiedTimestamp)
        {
            this.TestCaseDefinitionId = testCaseDefinitionId ?? throw new global::System.ArgumentNullException(nameof(testCaseDefinitionId));
            this.CreationTimestamp = creationTimestamp;
            this.UserModifiedTimestamp = userModifiedTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseDefinitionV3Metadata" /> class.
        /// </summary>
        public TestCaseDefinitionV3Metadata()
        {
        }

    }
}