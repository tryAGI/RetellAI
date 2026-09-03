
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChartShowItemCustomFieldSourceSource
    {
        /// <summary>
        /// `custom_analysis_data` reads an analysis output; `custom_attribute` reads a custom attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartShowItemCustomFieldSourceSourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartShowItemCustomFieldSourceSourceType Type { get; set; }

        /// <summary>
        /// Exact custom field name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Convert values before aggregation: `float` to numbers or `bool` to booleans. With `bool`, `avg` returns the fraction of converted values that are true. Omit for `count`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cast")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartShowItemCustomFieldSourceSourceCastJsonConverter))]
        public global::RetellAI.ChartShowItemCustomFieldSourceSourceCast? Cast { get; set; }

        /// <summary>
        /// Optional chart-wide breakdown. A custom group uses this source's `field`; use `group_criteria` to group by a different custom field.
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
        /// Initializes a new instance of the <see cref="ChartShowItemCustomFieldSourceSource" /> class.
        /// </summary>
        /// <param name="type">
        /// `custom_analysis_data` reads an analysis output; `custom_attribute` reads a custom attribute.
        /// </param>
        /// <param name="field">
        /// Exact custom field name.
        /// </param>
        /// <param name="cast">
        /// Convert values before aggregation: `float` to numbers or `bool` to booleans. With `bool`, `avg` returns the fraction of converted values that are true. Omit for `count`.
        /// </param>
        /// <param name="group">
        /// Optional chart-wide breakdown. A custom group uses this source's `field`; use `group_criteria` to group by a different custom field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartShowItemCustomFieldSourceSource(
            global::RetellAI.ChartShowItemCustomFieldSourceSourceType type,
            string field,
            global::RetellAI.ChartShowItemCustomFieldSourceSourceCast? cast,
            global::RetellAI.ChartGroupType? group)
        {
            this.Type = type;
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Cast = cast;
            this.Group = group;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartShowItemCustomFieldSourceSource" /> class.
        /// </summary>
        public ChartShowItemCustomFieldSourceSource()
        {
        }

    }
}