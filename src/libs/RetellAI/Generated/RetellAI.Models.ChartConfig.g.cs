
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChartConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_id")]
        public string? ChartId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartConfigTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartConfigType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.ChartConfigSizeEnum?, global::RetellAI.ChartConfigSizeEnum2>))]
        public global::RetellAI.OneOf<global::RetellAI.ChartConfigSizeEnum?, global::RetellAI.ChartConfigSizeEnum2>? Size { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show")]
        public global::System.Collections.Generic.IList<global::RetellAI.ChartShowItem>? Show { get; set; }

        /// <summary>
        /// User-selected additional breakdowns saved on the chart.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_criteria")]
        public global::System.Collections.Generic.IList<global::RetellAI.ChartGroupItem>? GroupCriteria { get; set; }

        /// <summary>
        /// Filter criteria saved on the chart. Merged with the dashboard-level filter when fetching data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_criteria")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AnyOfJsonConverter<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>))]
        public global::RetellAI.AnyOf<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>? FilterCriteria { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartTimeRangeJsonConverter))]
        public global::RetellAI.ChartTimeRange? Time { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparison")]
        public bool? Comparison { get; set; }

        /// <summary>
        ///
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
        /// <param name="type"></param>
        /// <param name="chartId"></param>
        /// <param name="title"></param>
        /// <param name="size"></param>
        /// <param name="show"></param>
        /// <param name="groupCriteria">
        /// User-selected additional breakdowns saved on the chart.
        /// </param>
        /// <param name="filterCriteria">
        /// Filter criteria saved on the chart. Merged with the dashboard-level filter when fetching data.
        /// </param>
        /// <param name="time"></param>
        /// <param name="comparison"></param>
        /// <param name="unit"></param>
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