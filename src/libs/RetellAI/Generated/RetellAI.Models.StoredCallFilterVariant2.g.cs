
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StoredCallFilterVariant2
    {
        /// <summary>
        /// Agents in `agent` configured to handle agentic warm transfers. Stored separately only so the dashboard can show that subset as transfer agents. They are queried through `agent`, not as a separate condition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_agent")]
        public global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>? TransferAgent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoredCallFilterVariant2" /> class.
        /// </summary>
        /// <param name="transferAgent">
        /// Agents in `agent` configured to handle agentic warm transfers. Stored separately only so the dashboard can show that subset as transfer agents. They are queried through `agent`, not as a separate condition.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoredCallFilterVariant2(
            global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>? transferAgent)
        {
            this.TransferAgent = transferAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoredCallFilterVariant2" /> class.
        /// </summary>
        public StoredCallFilterVariant2()
        {
        }

    }
}