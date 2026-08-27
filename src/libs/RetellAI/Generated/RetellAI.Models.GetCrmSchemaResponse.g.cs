
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetCrmSchemaResponse
    {
        /// <summary>
        /// CRM provider name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.CRMCustomFieldSchema> Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCrmSchemaResponse" /> class.
        /// </summary>
        /// <param name="provider">
        /// CRM provider name.
        /// </param>
        /// <param name="fields"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCrmSchemaResponse(
            string provider,
            global::System.Collections.Generic.IList<global::RetellAI.CRMCustomFieldSchema> fields)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCrmSchemaResponse" /> class.
        /// </summary>
        public GetCrmSchemaResponse()
        {
        }

    }
}