
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StoredCallFilterVariant2
    {
        /// <summary>
        /// The subset of `agent` that was selected as transfer agents. Stored and returned verbatim; it is NOT applied when querying — the dashboard merges its transfer-agent selection into `agent`, which is what filtering resolves on. It exists only so that a saved filter, on being read back, can tell which entries of `agent` belong to the transfer-agent picker; without it they all come back as regular agent selections.
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
        /// The subset of `agent` that was selected as transfer agents. Stored and returned verbatim; it is NOT applied when querying — the dashboard merges its transfer-agent selection into `agent`, which is what filtering resolves on. It exists only so that a saved filter, on being read back, can tell which entries of `agent` belong to the transfer-agent picker; without it they all come back as regular agent selections.
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