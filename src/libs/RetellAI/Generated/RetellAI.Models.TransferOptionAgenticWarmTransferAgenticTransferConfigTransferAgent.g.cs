
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The agent that will mediate the transfer decision.
    /// </summary>
    public sealed partial class TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent
    {
        /// <summary>
        /// The agent ID of the transfer agent. This agent must have isTransferAgent set to true and should use bridge_transfer and cancel_transfer tools (for Retell LLM) or BridgeTransferNode and CancelTransferNode (for Conversation Flow).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version (or latest) is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AgentVersionReferenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.AgentVersionReference AgentVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The agent ID of the transfer agent. This agent must have isTransferAgent set to true and should use bridge_transfer and cancel_transfer tools (for Retell LLM) or BridgeTransferNode and CancelTransferNode (for Conversation Flow).
        /// </param>
        /// <param name="agentVersion">
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version (or latest) is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent(
            string agentId,
            global::RetellAI.AgentVersionReference agentVersion)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentVersion = agentVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent" /> class.
        /// </summary>
        public TransferOptionAgenticWarmTransferAgenticTransferConfigTransferAgent()
        {
        }
    }
}