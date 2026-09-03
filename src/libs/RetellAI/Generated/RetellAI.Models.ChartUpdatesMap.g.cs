
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Partial map of chart_id to chart, merged into the dashboard's stored charts. Each entry's chart_id must equal its key, a null value deletes that chart, and charts left out stay unchanged.
    /// </summary>
    public sealed partial class ChartUpdatesMap
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}