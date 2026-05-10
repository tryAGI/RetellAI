
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// If this option is set, the agent prompt will include call screen handling instructions for identity and call purpose questions. Set this to null to disable call screen prompt instructions.
    /// </summary>
    public sealed partial class CallScreeningOption
    {
        /// <summary>
        /// Identity the agent should provide when a call screen asks who is calling. Dynamic variables are supported.<br/>
        /// Example: Acme Health scheduling team
        /// </summary>
        /// <example>Acme Health scheduling team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_identity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentIdentity { get; set; }

        /// <summary>
        /// Purpose the agent should provide when a call screen asks why it is calling. Dynamic variables are supported.<br/>
        /// Example: confirming your appointment for tomorrow
        /// </summary>
        /// <example>confirming your appointment for tomorrow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_purpose")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallPurpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallScreeningOption" /> class.
        /// </summary>
        /// <param name="agentIdentity">
        /// Identity the agent should provide when a call screen asks who is calling. Dynamic variables are supported.<br/>
        /// Example: Acme Health scheduling team
        /// </param>
        /// <param name="callPurpose">
        /// Purpose the agent should provide when a call screen asks why it is calling. Dynamic variables are supported.<br/>
        /// Example: confirming your appointment for tomorrow
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallScreeningOption(
            string agentIdentity,
            string callPurpose)
        {
            this.AgentIdentity = agentIdentity ?? throw new global::System.ArgumentNullException(nameof(agentIdentity));
            this.CallPurpose = callPurpose ?? throw new global::System.ArgumentNullException(nameof(callPurpose));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallScreeningOption" /> class.
        /// </summary>
        public CallScreeningOption()
        {
        }

    }
}