
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Optional call filter to scope which calls are processed. Supports agent and start_timestamp from the standard call filter.
    /// </summary>
    public sealed partial class BackfillContactAnalysisDataRequestBackfillCallFilter
    {
        /// <summary>
        /// Filter calls by agent. Agents are OR-connected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>? Agent { get; set; }

        /// <summary>
        /// Filter calls by start timestamp (epoch ms).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? StartTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackfillContactAnalysisDataRequestBackfillCallFilter" /> class.
        /// </summary>
        /// <param name="agent">
        /// Filter calls by agent. Agents are OR-connected.
        /// </param>
        /// <param name="startTimestamp">
        /// Filter calls by start timestamp (epoch ms).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackfillContactAnalysisDataRequestBackfillCallFilter(
            global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>? agent,
            global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? startTimestamp)
        {
            this.Agent = agent;
            this.StartTimestamp = startTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackfillContactAnalysisDataRequestBackfillCallFilter" /> class.
        /// </summary>
        public BackfillContactAnalysisDataRequestBackfillCallFilter()
        {
        }

    }
}