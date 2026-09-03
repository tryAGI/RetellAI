
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Map of chart_id to chart. Each entry's chart_id must equal its key. Sent in full on update, not merged per key.
    /// </summary>
    public sealed partial class ChartsMap
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}