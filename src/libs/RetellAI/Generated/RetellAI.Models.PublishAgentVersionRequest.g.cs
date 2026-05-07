
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublishAgentVersionRequest
    {
        /// <summary>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Example: Hotfix for transfer timeout
        /// </summary>
        /// <example>Hotfix for transfer timeout</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishAgentVersionRequest" /> class.
        /// </summary>
        /// <param name="version">
        /// Example: 15
        /// </param>
        /// <param name="versionDescription">
        /// Example: Hotfix for transfer timeout
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishAgentVersionRequest(
            int version,
            string? versionDescription)
        {
            this.Version = version;
            this.VersionDescription = versionDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishAgentVersionRequest" /> class.
        /// </summary>
        public PublishAgentVersionRequest()
        {
        }
    }
}