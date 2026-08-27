
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KnowledgeBaseAppUsage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.KnowledgeBaseAppUsageTypeJsonConverter))]
        public global::RetellAI.KnowledgeBaseAppUsageType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Current knowledge base name; omitted if it was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_name")]
        public string? KnowledgeBaseName { get; set; }

        /// <summary>
        /// When this reference was last recorded, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configured_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConfiguredTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseAppUsage" /> class.
        /// </summary>
        /// <param name="knowledgeBaseId"></param>
        /// <param name="configuredTimestamp">
        /// When this reference was last recorded, in milliseconds.
        /// </param>
        /// <param name="type"></param>
        /// <param name="knowledgeBaseName">
        /// Current knowledge base name; omitted if it was deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseAppUsage(
            string knowledgeBaseId,
            double configuredTimestamp,
            global::RetellAI.KnowledgeBaseAppUsageType type,
            string? knowledgeBaseName)
        {
            this.Type = type;
            this.KnowledgeBaseId = knowledgeBaseId ?? throw new global::System.ArgumentNullException(nameof(knowledgeBaseId));
            this.KnowledgeBaseName = knowledgeBaseName;
            this.ConfiguredTimestamp = configuredTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseAppUsage" /> class.
        /// </summary>
        public KnowledgeBaseAppUsage()
        {
        }

    }
}