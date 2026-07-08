
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Filters for listing agents. All provided filters are connected with AND.
    /// </summary>
    public sealed partial class AgentListFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.StringFilter, global::RetellAI.AgentListFilterChannel>))]
        public global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.AgentListFilterChannel>? Channel { get; set; }

        /// <summary>
        /// Case-insensitive substring search over agent name, plus substring search over agent id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentListFilter" /> class.
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="query">
        /// Case-insensitive substring search over agent name, plus substring search over agent id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentListFilter(
            global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.AgentListFilterChannel>? channel,
            string? query)
        {
            this.Channel = channel;
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentListFilter" /> class.
        /// </summary>
        public AgentListFilter()
        {
        }

    }
}