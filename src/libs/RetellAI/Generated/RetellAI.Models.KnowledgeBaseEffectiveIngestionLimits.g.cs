
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Effective rolling 30-day ingestion limits. Each KB has an independent budget. Lifetime fill allowance<br/>
    /// and structural source-count caps are separate.<br/>
    /// Example: {"files":25,"texts":50,"urls":200}
    /// </summary>
    public sealed partial class KnowledgeBaseEffectiveIngestionLimits
    {
        /// <summary>
        /// Shared limit for uploaded documents and all connected-file sources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Files { get; set; }

        /// <summary>
        /// Limit for pasted-text sources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Texts { get; set; }

        /// <summary>
        /// Limit for URL sources.
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
        /// Initializes a new instance of the <see cref="KnowledgeBaseEffectiveIngestionLimits" /> class.
        /// </summary>
        /// <param name="files">
        /// Shared limit for uploaded documents and all connected-file sources.
        /// </param>
        /// <param name="texts">
        /// Limit for pasted-text sources.
        /// </param>
        /// <param name="urls">
        /// Limit for URL sources.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseEffectiveIngestionLimits(
            int files,
            int texts,
            int urls)
        {
            this.Files = files;
            this.Texts = texts;
            this.Urls = urls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseEffectiveIngestionLimits" /> class.
        /// </summary>
        public KnowledgeBaseEffectiveIngestionLimits()
        {
        }

    }
}