
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentAppUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AgentAppUsageTypeJsonConverter))]
        public global::RetellAI.AgentAppUsageType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Current agent name; omitted if the agent was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// Agent versions referencing this app, largest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> AgentVersions { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentAppUsage" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="agentVersions">
        /// Agent versions referencing this app, largest first.
        /// </param>
        /// <param name="configuredTimestamp">
        /// When this reference was last recorded, in milliseconds.
        /// </param>
        /// <param name="type"></param>
        /// <param name="agentName">
        /// Current agent name; omitted if the agent was deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAppUsage(
            string agentId,
            global::System.Collections.Generic.IList<double> agentVersions,
            double configuredTimestamp,
            global::RetellAI.AgentAppUsageType type,
            string? agentName)
        {
            this.Type = type;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentName = agentName;
            this.AgentVersions = agentVersions ?? throw new global::System.ArgumentNullException(nameof(agentVersions));
            this.ConfiguredTimestamp = configuredTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAppUsage" /> class.
        /// </summary>
        public AgentAppUsage()
        {
        }

    }
}