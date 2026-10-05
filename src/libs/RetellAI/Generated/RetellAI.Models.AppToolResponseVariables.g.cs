
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Mapping of a dynamic-variable name to the response field (dot-path) it is populated from. Missing paths are ignored.<br/>
    /// Example: {"contact_first_name":"data.first_name"}
    /// </summary>
    public sealed partial class AppToolResponseVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}