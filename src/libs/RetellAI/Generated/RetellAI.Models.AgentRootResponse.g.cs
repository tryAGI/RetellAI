
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentRootResponse
    {
        /// <summary>
        /// Unique id of the agent.<br/>
        /// Example: agent_xxx
        /// </summary>
        /// <example>agent_xxx</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Whether the agent is currently suspended.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_suspended")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSuspended { get; set; }

        /// <summary>
        /// Environment tags for this agent, keyed by tag name. Every agent has prod and staging tags.<br/>
        /// Example: {"prod":{"version":3},"staging":{}}
        /// </summary>
        /// <example>{"prod":{"version":3},"staging":{}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::RetellAI.AgentRootTagState> Tags { get; set; }

        /// <summary>
        /// User modification timestamp (milliseconds since epoch). Either the time of last update or creation if no updates available.<br/>
        /// Example: 1746105600000
        /// </summary>
        /// <example>1746105600000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_modified_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserModifiedTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRootResponse" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Unique id of the agent.<br/>
        /// Example: agent_xxx
        /// </param>
        /// <param name="isSuspended">
        /// Whether the agent is currently suspended.<br/>
        /// Example: false
        /// </param>
        /// <param name="tags">
        /// Environment tags for this agent, keyed by tag name. Every agent has prod and staging tags.<br/>
        /// Example: {"prod":{"version":3},"staging":{}}
        /// </param>
        /// <param name="userModifiedTimestamp">
        /// User modification timestamp (milliseconds since epoch). Either the time of last update or creation if no updates available.<br/>
        /// Example: 1746105600000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRootResponse(
            string agentId,
            bool isSuspended,
            global::System.Collections.Generic.Dictionary<string, global::RetellAI.AgentRootTagState> tags,
            long userModifiedTimestamp)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.IsSuspended = isSuspended;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.UserModifiedTimestamp = userModifiedTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRootResponse" /> class.
        /// </summary>
        public AgentRootResponse()
        {
        }

    }
}