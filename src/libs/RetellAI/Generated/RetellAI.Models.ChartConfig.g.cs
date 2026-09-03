
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Chart query and rendering settings. The call or chat dataset is supplied separately in `target.source`.
    /// </summary>
    public sealed partial class ChartConfig
    {
        /// <summary>
        /// Identifier of a chart stored in a dashboard. Omit from `target.chart`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_id")]
        public string? ChartId { get; set; }

        /// <summary>
        /// Label shown above the chart.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Visualization. Use `number` for aggregate values, `donut` for categorical distributions, `line` for trends, `column` for vertical bars, or `bar` for horizontal bars. `line`, `bar`, and `column` automatically group by time; `number` ignores configured groups; `donut` rejects configured time groups. Concurrency always returns time buckets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartConfigTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartConfigType Type { get; set; }

        /// <summary>
        /// Grid placement for a chart stored in a dashboard. Omit from `target.chart`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.ChartConfigSizeEnum?, global::RetellAI.ChartConfigSizeEnum2>))]
        public global::RetellAI.OneOf<global::RetellAI.ChartConfigSizeEnum?, global::RetellAI.ChartConfigSizeEnum2>? Size { get; set; }

        /// <summary>
        /// Metrics to calculate, in output order. Provide at least one. Use multiple metrics only when they should share the same breakdowns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show")]
        public global::System.Collections.Generic.IList<global::RetellAI.ChartShowItem>? Show { get; set; }

        /// <summary>
        /// Chart-wide breakdowns shared by every metric. For a custom-field breakdown, provide the exact custom field name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_criteria")]
        public global::System.Collections.Generic.IList<global::RetellAI.ChartGroupItem>? GroupCriteria { get; set; }

        /// <summary>
        /// Filters applied before metrics are calculated. Use fields supported by `target.source`. Records must match every populated filter field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_criteria")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AnyOfJsonConverter<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>))]
        public global::RetellAI.AnyOf<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>? FilterCriteria { get; set; }

        /// <summary>
        /// Records included by time. When omitted from `target.chart`, the last week is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartTimeRangeJsonConverter))]
        public global::RetellAI.ChartTimeRange? Time { get; set; }

        /// <summary>
        /// Also query the preceding comparison period. Requires `target.chart.time` with a type other than `all`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparison")]
        public bool? Comparison { get; set; }

        /// <summary>
        /// Time-bucket size for `line`, `bar`, `column`, and concurrency charts. Defaults to `week` when the calculated range exceeds 30 whole days, `month` for all time, and `day` otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartConfigUnitJsonConverter))]
        public global::RetellAI.ChartConfigUnit? Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Visualization. Use `number` for aggregate values, `donut` for categorical distributions, `line` for trends, `column` for vertical bars, or `bar` for horizontal bars. `line`, `bar`, and `column` automatically group by time; `number` ignores configured groups; `donut` rejects configured time groups. Concurrency always returns time buckets.
        /// </param>
        /// <param name="chartId">
        /// Identifier of a chart stored in a dashboard. Omit from `target.chart`.
        /// </param>
        /// <param name="title">
        /// Label shown above the chart.
        /// </param>
        /// <param name="size">
        /// Grid placement for a chart stored in a dashboard. Omit from `target.chart`.
        /// </param>
        /// <param name="show">
        /// Metrics to calculate, in output order. Provide at least one. Use multiple metrics only when they should share the same breakdowns.
        /// </param>
        /// <param name="groupCriteria">
        /// Chart-wide breakdowns shared by every metric. For a custom-field breakdown, provide the exact custom field name.
        /// </param>
        /// <param name="filterCriteria">
        /// Filters applied before metrics are calculated. Use fields supported by `target.source`. Records must match every populated filter field.
        /// </param>
        /// <param name="time">
        /// Records included by time. When omitted from `target.chart`, the last week is used.
        /// </param>
        /// <param name="comparison">
        /// Also query the preceding comparison period. Requires `target.chart.time` with a type other than `all`.
        /// </param>
        /// <param name="unit">
        /// Time-bucket size for `line`, `bar`, `column`, and concurrency charts. Defaults to `week` when the calculated range exceeds 30 whole days, `month` for all time, and `day` otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartConfig(
            global::RetellAI.ChartConfigType type,
            string? chartId,
            string? title,
            global::RetellAI.OneOf<global::RetellAI.ChartConfigSizeEnum?, global::RetellAI.ChartConfigSizeEnum2>? size,
            global::System.Collections.Generic.IList<global::RetellAI.ChartShowItem>? show,
            global::System.Collections.Generic.IList<global::RetellAI.ChartGroupItem>? groupCriteria,
            global::RetellAI.AnyOf<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>? filterCriteria,
            global::RetellAI.ChartTimeRange? time,
            bool? comparison,
            global::RetellAI.ChartConfigUnit? unit)
        {
            this.ChartId = chartId;
            this.Title = title;
            this.Type = type;
            this.Size = size;
            this.Show = show;
            this.GroupCriteria = groupCriteria;
            this.FilterCriteria = filterCriteria;
            this.Time = time;
            this.Comparison = comparison;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartConfig" /> class.
        /// </summary>
        public ChartConfig()
        {
        }

    }
}