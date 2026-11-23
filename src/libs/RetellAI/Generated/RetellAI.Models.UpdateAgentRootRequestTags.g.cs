
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Environment tags to add, change, or delete, keyed by tag name. Set a tag to an object to add or change it, or to null to delete it. Tags you leave out stay as they are. The prod and staging tags cannot be deleted. An agent can have up to 10 tags. Tag names must be 1-20 characters, start with a lowercase letter, use only lowercase letters, digits, underscores, or hyphens, and cannot be "latest", "latest_published", or "v" followed only by digits, such as "v2".<br/>
    /// Example: {"prod":{"version":3}}
    /// </summary>
    public sealed partial class UpdateAgentRootRequestTags
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prod")]
        public global::RetellAI.AgentRootTagUpdate? Prod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("staging")]
        public global::RetellAI.AgentRootTagUpdate? Staging { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRootRequestTags" /> class.
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="staging"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentRootRequestTags(
            global::RetellAI.AgentRootTagUpdate? prod,
            global::RetellAI.AgentRootTagUpdate? staging)
        {
            this.Prod = prod;
            this.Staging = staging;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRootRequestTags" /> class.
        /// </summary>
        public UpdateAgentRootRequestTags()
        {
        }

    }
}