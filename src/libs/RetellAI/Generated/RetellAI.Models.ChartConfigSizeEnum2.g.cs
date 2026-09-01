
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Grid placement and span for the chart in a 24-column layout.
    /// </summary>
    public sealed partial class ChartConfigSizeEnum2
    {
        /// <summary>
        /// Starting column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("col")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Col { get; set; }

        /// <summary>
        /// Starting row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Row { get; set; }

        /// <summary>
        /// Number of columns the chart spans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("col_span")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ColSpan { get; set; }

        /// <summary>
        /// Number of rows the chart spans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_span")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RowSpan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartConfigSizeEnum2" /> class.
        /// </summary>
        /// <param name="col">
        /// Starting column.
        /// </param>
        /// <param name="row">
        /// Starting row.
        /// </param>
        /// <param name="colSpan">
        /// Number of columns the chart spans.
        /// </param>
        /// <param name="rowSpan">
        /// Number of rows the chart spans.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartConfigSizeEnum2(
            int col,
            int row,
            int colSpan,
            int rowSpan)
        {
            this.Col = col;
            this.Row = row;
            this.ColSpan = colSpan;
            this.RowSpan = rowSpan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartConfigSizeEnum2" /> class.
        /// </summary>
        public ChartConfigSizeEnum2()
        {
        }

    }
}