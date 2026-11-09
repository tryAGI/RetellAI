
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Customer-defined fields nested in args on chat_transfer_requested events. String values support dynamic variables such as {{customer_id}}, including inside nested objects and arrays. Field names and non-string values are preserved.
    /// </summary>
    public sealed partial class EscalationDestinationDestinationBody
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}