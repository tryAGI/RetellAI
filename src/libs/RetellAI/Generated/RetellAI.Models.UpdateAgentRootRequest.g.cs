
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateAgentRootRequest
    {
        /// <summary>
        /// Environment tags to add, change, or delete, keyed by tag name. Set a tag to an object to add or change it, or to null to delete it. Tags you leave out stay as they are. The prod and staging tags cannot be deleted. An agent can have up to 10 tags. Tag names must be 1-20 characters, start with a lowercase letter, use only lowercase letters, digits, underscores, or hyphens, and cannot be "latest", "latest_published", or "v" followed only by digits, such as "v2".<br/>
        /// Example: {"prod":{"version":3}}
        /// </summary>
        /// <example>{"prod":{"version":3}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::RetellAI.UpdateAgentRootRequestTags? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRootRequest" /> class.
        /// </summary>
        /// <param name="tags">
        /// Environment tags to add, change, or delete, keyed by tag name. Set a tag to an object to add or change it, or to null to delete it. Tags you leave out stay as they are. The prod and staging tags cannot be deleted. An agent can have up to 10 tags. Tag names must be 1-20 characters, start with a lowercase letter, use only lowercase letters, digits, underscores, or hyphens, and cannot be "latest", "latest_published", or "v" followed only by digits, such as "v2".<br/>
        /// Example: {"prod":{"version":3}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentRootRequest(
            global::RetellAI.UpdateAgentRootRequestTags? tags)
        {
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRootRequest" /> class.
        /// </summary>
        public UpdateAgentRootRequest()
        {
        }

    }
}