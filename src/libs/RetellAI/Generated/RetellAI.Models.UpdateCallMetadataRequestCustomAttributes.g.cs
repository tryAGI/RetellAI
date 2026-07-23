
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Custom attributes for the call, as key-value pairs. Each attribute must first be defined for your organization in the Retell dashboard (Call History → Actions → Custom attributes) before it can be set here. The object key must match the id of an existing organization-level custom attribute; keys that do not match a defined attribute are ignored and will not be saved. Values must be a string, number, or boolean.<br/>
    /// Example: {"custom_attribute_1":"value1","custom_attribute_2":"value2"}
    /// </summary>
    public sealed partial class UpdateCallMetadataRequestCustomAttributes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}