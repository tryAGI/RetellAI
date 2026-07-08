
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentListItemResponse
    {
        /// <summary>
        /// Unique id of agent.<br/>
        /// Example: agent_1ffdb9717444d0e77346838911
        /// </summary>
        /// <example>agent_1ffdb9717444d0e77346838911</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The name of the agent. Only used for your own reference.<br/>
        /// Example: Jarvis
        /// </summary>
        /// <example>Jarvis</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// Example: voice
        /// </summary>
        /// <example>voice</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AgentListItemResponseChannelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AgentListItemResponseChannel Channel { get; set; }

        /// <summary>
        /// User modification timestamp (milliseconds since epoch). Either the time of last update or creation if no updates available.<br/>
        /// Example: 1703413636133
        /// </summary>
        /// <example>1703413636133</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_modified_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserModifiedTimestamp { get; set; }

        /// <summary>
        /// Authoritative root tags for this agent, keyed by tag name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::RetellAI.AgentRootTagState> Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentListItemResponse" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Unique id of agent.<br/>
        /// Example: agent_1ffdb9717444d0e77346838911
        /// </param>
        /// <param name="agentName">
        /// The name of the agent. Only used for your own reference.<br/>
        /// Example: Jarvis
        /// </param>
        /// <param name="channel">
        /// Example: voice
        /// </param>
        /// <param name="userModifiedTimestamp">
        /// User modification timestamp (milliseconds since epoch). Either the time of last update or creation if no updates available.<br/>
        /// Example: 1703413636133
        /// </param>
        /// <param name="tags">
        /// Authoritative root tags for this agent, keyed by tag name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentListItemResponse(
            string agentId,
            string agentName,
            global::RetellAI.AgentListItemResponseChannel channel,
            long userModifiedTimestamp,
            global::System.Collections.Generic.Dictionary<string, global::RetellAI.AgentRootTagState> tags)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.Channel = channel;
            this.UserModifiedTimestamp = userModifiedTimestamp;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentListItemResponse" /> class.
        /// </summary>
        public AgentListItemResponse()
        {
        }

    }
}