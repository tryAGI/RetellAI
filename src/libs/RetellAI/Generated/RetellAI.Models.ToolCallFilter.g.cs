
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallFilter
    {
        /// <summary>
        /// The tool call name to filter on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Filter by tool call latency in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_ms")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? LatencyMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public global::RetellAI.BooleanFilter? Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallFilter" /> class.
        /// </summary>
        /// <param name="name">
        /// The tool call name to filter on.
        /// </param>
        /// <param name="latencyMs">
        /// Filter by tool call latency in milliseconds.
        /// </param>
        /// <param name="success"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallFilter(
            string name,
            global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? latencyMs,
            global::RetellAI.BooleanFilter? success)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.LatencyMs = latencyMs;
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallFilter" /> class.
        /// </summary>
        public ToolCallFilter()
        {
        }
    }
}