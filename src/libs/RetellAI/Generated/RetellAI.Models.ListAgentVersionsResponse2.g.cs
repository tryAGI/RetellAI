
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListAgentVersionsResponse2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.AgentVersionSummary> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentVersionsResponse2" /> class.
        /// </summary>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentVersionsResponse2(
            global::System.Collections.Generic.IList<global::RetellAI.AgentVersionSummary> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentVersionsResponse2" /> class.
        /// </summary>
        public ListAgentVersionsResponse2()
        {
        }

    }
}