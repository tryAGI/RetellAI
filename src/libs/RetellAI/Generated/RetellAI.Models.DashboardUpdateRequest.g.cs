
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Partial dashboard update. Omitted fields remain unchanged.
    /// </summary>
    public sealed partial class DashboardUpdateRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Map of chart_id to chart. Each entry's chart_id must equal its key. Sent in full on update, not merged per key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charts_map")]
        public global::RetellAI.ChartsMap? ChartsMap { get; set; }

        /// <summary>
        /// Per-chart updates merged into the stored charts, instead of the full replacement charts_map does. Each chart is written on its own key, so concurrent edits to different charts do not conflict. Cannot be combined with charts_map.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_updates")]
        public global::RetellAI.ChartUpdatesMap? ChartUpdates { get; set; }

        /// <summary>
        /// Dashboard-level filter criteria applied to all charts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_criteria")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AnyOfJsonConverter<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>))]
        public global::RetellAI.AnyOf<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>? FilterCriteria { get; set; }

        /// <summary>
        /// Dashboard-level group/breakdown criteria applied to all charts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_criteria")]
        public global::System.Collections.Generic.IList<global::RetellAI.ChartGroupItem>? GroupCriteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardUpdateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="chartsMap">
        /// Map of chart_id to chart. Each entry's chart_id must equal its key. Sent in full on update, not merged per key.
        /// </param>
        /// <param name="chartUpdates">
        /// Per-chart updates merged into the stored charts, instead of the full replacement charts_map does. Each chart is written on its own key, so concurrent edits to different charts do not conflict. Cannot be combined with charts_map.
        /// </param>
        /// <param name="filterCriteria">
        /// Dashboard-level filter criteria applied to all charts.
        /// </param>
        /// <param name="groupCriteria">
        /// Dashboard-level group/breakdown criteria applied to all charts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashboardUpdateRequest(
            string? name,
            global::RetellAI.ChartsMap? chartsMap,
            global::RetellAI.ChartUpdatesMap? chartUpdates,
            global::RetellAI.AnyOf<global::RetellAI.StoredCallFilter?, global::RetellAI.ChatFilter>? filterCriteria,
            global::System.Collections.Generic.IList<global::RetellAI.ChartGroupItem>? groupCriteria)
        {
            this.Name = name;
            this.ChartsMap = chartsMap;
            this.ChartUpdates = chartUpdates;
            this.FilterCriteria = filterCriteria;
            this.GroupCriteria = groupCriteria;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardUpdateRequest" /> class.
        /// </summary>
        public DashboardUpdateRequest()
        {
        }

    }
}