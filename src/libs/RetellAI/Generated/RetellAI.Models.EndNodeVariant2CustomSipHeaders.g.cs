
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Custom SIP headers sent on the outgoing BYE when ending the call. Header names must start with X- or x-. Supports dynamic variables.
    /// </summary>
    public sealed partial class EndNodeVariant2CustomSipHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}