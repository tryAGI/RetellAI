
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Position and span in the dashboard's 24-column grid.
    /// </summary>
    public sealed partial class ChartConfigSizeEnum2
    {
        /// <summary>
        /// 1-based starting column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("col")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Col { get; set; }

        /// <summary>
        /// 1-based starting row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Row { get; set; }

        /// <summary>
        /// Grid columns occupied. The chart must not extend beyond column 24.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("col_span")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ColSpan { get; set; }

        /// <summary>
        /// Grid rows occupied.
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
        /// 1-based starting column.
        /// </param>
        /// <param name="row">
        /// 1-based starting row.
        /// </param>
        /// <param name="colSpan">
        /// Grid columns occupied. The chart must not extend beyond column 24.
        /// </param>
        /// <param name="rowSpan">
        /// Grid rows occupied.
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