
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChartShowItemCustomToolSourceSource
    {
        /// <summary>
        /// Latency is milliseconds; success rate is a ratio from 0 to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartShowItemCustomToolSourceSourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartShowItemCustomToolSourceSourceType Type { get; set; }

        /// <summary>
        /// Optional chart-wide breakdown shared by every metric. Do not set `time`; time grouping is automatic for `line`, `bar`, and `column`. Use `group_criteria` to name a custom field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartGroupTypeJsonConverter))]
        public global::RetellAI.ChartGroupType? Group { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemCustomToolSourceSource" /> class.
        /// </summary>
        /// <param name="type">
        /// Latency is milliseconds; success rate is a ratio from 0 to 1.
        /// </param>
        /// <param name="group">
        /// Optional chart-wide breakdown shared by every metric. Do not set `time`; time grouping is automatic for `line`, `bar`, and `column`. Use `group_criteria` to name a custom field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartShowItemCustomToolSourceSource(
            global::RetellAI.ChartShowItemCustomToolSourceSourceType type,
            global::RetellAI.ChartGroupType? group)
        {
            this.Type = type;
            this.Group = group;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemCustomToolSourceSource" /> class.
        /// </summary>
        public ChartShowItemCustomToolSourceSource()
        {
        }

    }
}