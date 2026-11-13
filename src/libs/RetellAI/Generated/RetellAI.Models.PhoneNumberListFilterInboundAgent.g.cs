
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PhoneNumberListFilterInboundAgent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public global::System.Collections.Generic.IList<double>? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberListFilterInboundAgent" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberListFilterInboundAgent(
            string? agentId,
            global::System.Collections.Generic.IList<double>? version)
        {
            this.AgentId = agentId;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberListFilterInboundAgent" /> class.
        /// </summary>
        public PhoneNumberListFilterInboundAgent()
        {
        }

    }
}