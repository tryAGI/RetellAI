
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChartShowItemKeywordSourceSource
    {
        /// <summary>
        /// `call_id` is call-only; `chat_id` is chat-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartShowItemKeywordSourceSourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartShowItemKeywordSourceSourceType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ChartShowItemKeywordSourceSource" /> class.
        /// </summary>
        /// <param name="type">
        /// `call_id` is call-only; `chat_id` is chat-only.
        /// </param>
        /// <param name="group">
        /// Optional chart-wide breakdown shared by every metric. Do not set `time`; time grouping is automatic for `line`, `bar`, and `column`. Use `group_criteria` to name a custom field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartShowItemKeywordSourceSource(
            global::RetellAI.ChartShowItemKeywordSourceSourceType type,
            global::RetellAI.ChartGroupType? group)
        {
            this.Type = type;
            this.Group = group;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemKeywordSourceSource" /> class.
        /// </summary>
        public ChartShowItemKeywordSourceSource()
        {
        }

    }
}