
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Values must match the types defined in CRM config custom fields. Set a value to null to clear it.
    /// </summary>
    public sealed partial class UpdateContactRequestCustomFields
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}