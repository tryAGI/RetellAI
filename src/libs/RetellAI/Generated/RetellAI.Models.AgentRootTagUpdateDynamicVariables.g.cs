
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Dynamic variable values supplied when a call uses this tag. Replaces all of the tag's current values. Set to null to remove them. If omitted, the tag keeps its current values.
    /// </summary>
    public sealed partial class AgentRootTagUpdateDynamicVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}