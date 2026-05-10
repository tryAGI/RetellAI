
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentWeight
    {
        /// <summary>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version (or latest) is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AgentVersionReferenceJsonConverter))]
        public global::RetellAI.AgentVersionReference? AgentVersion { get; set; }

        /// <summary>
        /// The weight of the agent. When used in a list of agents, the total weights must add up to 1.<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWeight" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="weight">
        /// The weight of the agent. When used in a list of agents, the total weights must add up to 1.<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="agentVersion">
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version (or latest) is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentWeight(
            string agentId,
            double weight,
            global::RetellAI.AgentVersionReference? agentVersion)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentVersion = agentVersion;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWeight" /> class.
        /// </summary>
        public AgentWeight()
        {
        }

    }
}