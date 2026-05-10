
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Key-value pairs for dynamic variable substitution.<br/>
    /// Example: {"customer_name":"John Smith","customer_phone":"444-223-3564"}
    /// </summary>
    public sealed partial class AgentPlaygroundCompletionRequestDynamicVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}