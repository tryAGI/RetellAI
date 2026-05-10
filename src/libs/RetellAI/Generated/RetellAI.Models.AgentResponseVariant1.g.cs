
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentResponseVariant1
    {
        /// <summary>
        /// Unique id of agent.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Version of the agent.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Version that this draft was based on. Null for initial versions.<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_version")]
        public int? BaseVersion { get; set; }

        /// <summary>
        /// Tags assigned to this agent version. Preferred tag is listed first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_tags")]
        public global::System.Collections.Generic.IList<string>? AssignedTags { get; set; }

        /// <summary>
        /// Whether the agent is published.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_published")]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseVariant1" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Unique id of agent.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="version">
        /// Version of the agent.<br/>
        /// Example: 0
        /// </param>
        /// <param name="baseVersion">
        /// Version that this draft was based on. Null for initial versions.<br/>
        /// Example: 12
        /// </param>
        /// <param name="assignedTags">
        /// Tags assigned to this agent version. Preferred tag is listed first.
        /// </param>
        /// <param name="isPublished">
        /// Whether the agent is published.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentResponseVariant1(
            string agentId,
            int version,
            int? baseVersion,
            global::System.Collections.Generic.IList<string>? assignedTags,
            bool? isPublished)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Version = version;
            this.BaseVersion = baseVersion;
            this.AssignedTags = assignedTags;
            this.IsPublished = isPublished;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseVariant1" /> class.
        /// </summary>
        public AgentResponseVariant1()
        {
        }

    }
}