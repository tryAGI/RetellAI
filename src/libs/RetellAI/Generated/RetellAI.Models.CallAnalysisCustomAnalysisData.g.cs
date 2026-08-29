
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Custom analysis data that was extracted based on the schema defined in agent Post Call Extraction data. Can be empty if nothing is specified.
    /// </summary>
    public sealed partial class CallAnalysisCustomAnalysisData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}