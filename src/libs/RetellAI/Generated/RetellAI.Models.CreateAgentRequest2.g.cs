
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentRequest2
    {
        /// <summary>
        /// Whether to create the agent as a transfer agent for agentic warm transfer. You can only set this field when creating the agent. The response engine must also be configured for transfer use with is_transfer_llm or is_transfer_cf. Custom LLM agents cannot be transfer agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_transfer_agent")]
        public bool? IsTransferAgent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest2" /> class.
        /// </summary>
        /// <param name="isTransferAgent">
        /// Whether to create the agent as a transfer agent for agentic warm transfer. You can only set this field when creating the agent. The response engine must also be configured for transfer use with is_transfer_llm or is_transfer_cf. Custom LLM agents cannot be transfer agents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRequest2(
            bool? isTransferAgent)
        {
            this.IsTransferAgent = isTransferAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest2" /> class.
        /// </summary>
        public CreateAgentRequest2()
        {
        }

    }
}