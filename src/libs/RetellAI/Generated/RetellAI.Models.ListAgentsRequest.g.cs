
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAgentsRequest
    {
        /// <summary>
        /// Filters for listing agents. All provided filters are connected with AND.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_criteria")]
        public global::RetellAI.AgentListFilter? FilterCriteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentsRequest" /> class.
        /// </summary>
        /// <param name="filterCriteria">
        /// Filters for listing agents. All provided filters are connected with AND.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentsRequest(
            global::RetellAI.AgentListFilter? filterCriteria)
        {
            this.FilterCriteria = filterCriteria;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentsRequest" /> class.
        /// </summary>
        public ListAgentsRequest()
        {
        }

    }
}