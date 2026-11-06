
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Ingestion quota available to this knowledge base at response time.<br/>
    /// Includes unused lifetime fill allowance plus remaining rolling<br/>
    /// 30-day per-KB capacity. Pending reservations already consume<br/>
    /// capacity. Default per-KB rolling limits are 25 files, 50 texts,<br/>
    /// and 200 URLs; organization-specific increases are reflected in<br/>
    /// these counts.<br/>
    /// Legacy knowledge bases without fill allowance receive rolling<br/>
    /// capacity only. Deleting sources does not restore ingestion quota.<br/>
    /// These counts do not include the separate limits on how many sources<br/>
    /// a KB can hold, and do not guarantee a concurrent request will succeed.<br/>
    /// Create and add-source responses include reservations for accepted<br/>
    /// sources; background discovery and processing may change the counts.<br/>
    /// Returns null if current usage cannot be read. Null means unavailable,<br/>
    /// not zero remaining capacity. Configured ingestion_limits are still<br/>
    /// returned. Quota enforcement remains required for ingestion requests.<br/>
    /// Example: {"files":25,"texts":50,"urls":200}
    /// </summary>
    public sealed partial class KnowledgeBaseResponseRemainingIngestionQuota
    {
        /// <summary>
        /// Remaining additions in the shared uploaded-file and connector bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Files { get; set; }

        /// <summary>
        /// Remaining pasted-text additions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Texts { get; set; }

        /// <summary>
        /// Remaining URL additions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Urls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseResponseRemainingIngestionQuota" /> class.
        /// </summary>
        /// <param name="files">
        /// Remaining additions in the shared uploaded-file and connector bucket.
        /// </param>
        /// <param name="texts">
        /// Remaining pasted-text additions.
        /// </param>
        /// <param name="urls">
        /// Remaining URL additions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseResponseRemainingIngestionQuota(
            int files,
            int texts,
            int urls)
        {
            this.Files = files;
            this.Texts = texts;
            this.Urls = urls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseResponseRemainingIngestionQuota" /> class.
        /// </summary>
        public KnowledgeBaseResponseRemainingIngestionQuota()
        {
        }

    }
}