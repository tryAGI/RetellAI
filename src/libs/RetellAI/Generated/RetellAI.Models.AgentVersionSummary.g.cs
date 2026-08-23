
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentVersionSummary
    {
        /// <summary>
        /// Version number of the agent.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Whether the agent version is published.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_published")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPublished { get; set; }

        /// <summary>
        /// Optional title of the agent version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_title")]
        public string? VersionTitle { get; set; }

        /// <summary>
        /// Optional description of the agent version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// Version that this agent version was based on.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_version")]
        public int? BaseVersion { get; set; }

        /// <summary>
        /// Last modification timestamp in milliseconds since epoch.<br/>
        /// Example: 1703413636133
        /// </summary>
        /// <example>1703413636133</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modification_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long LastModificationTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVersionSummary" /> class.
        /// </summary>
        /// <param name="version">
        /// Version number of the agent.<br/>
        /// Example: 3
        /// </param>
        /// <param name="isPublished">
        /// Whether the agent version is published.<br/>
        /// Example: false
        /// </param>
        /// <param name="lastModificationTimestamp">
        /// Last modification timestamp in milliseconds since epoch.<br/>
        /// Example: 1703413636133
        /// </param>
        /// <param name="versionTitle">
        /// Optional title of the agent version.
        /// </param>
        /// <param name="versionDescription">
        /// Optional description of the agent version.
        /// </param>
        /// <param name="baseVersion">
        /// Version that this agent version was based on.<br/>
        /// Example: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVersionSummary(
            int version,
            bool isPublished,
            long lastModificationTimestamp,
            string? versionTitle,
            string? versionDescription,
            int? baseVersion)
        {
            this.Version = version;
            this.IsPublished = isPublished;
            this.VersionTitle = versionTitle;
            this.VersionDescription = versionDescription;
            this.BaseVersion = baseVersion;
            this.LastModificationTimestamp = lastModificationTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVersionSummary" /> class.
        /// </summary>
        public AgentVersionSummary()
        {
        }

    }
}