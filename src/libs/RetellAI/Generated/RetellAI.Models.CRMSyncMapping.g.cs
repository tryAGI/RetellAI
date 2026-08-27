
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CRMSyncMapping
    {
        /// <summary>
        /// Retell contact field, built-in or custom, to map. Types must be compatible with the CRM field on both sides of the sync.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FieldName { get; set; }

        /// <summary>
        /// Field on the CRM's contact object to map to. A name that does not exist there surfaces as an error on the sync job rather than at configuration time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_field_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalFieldName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CRMSyncMapping" /> class.
        /// </summary>
        /// <param name="fieldName">
        /// Retell contact field, built-in or custom, to map. Types must be compatible with the CRM field on both sides of the sync.
        /// </param>
        /// <param name="externalFieldName">
        /// Field on the CRM's contact object to map to. A name that does not exist there surfaces as an error on the sync job rather than at configuration time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CRMSyncMapping(
            string fieldName,
            string externalFieldName)
        {
            this.FieldName = fieldName ?? throw new global::System.ArgumentNullException(nameof(fieldName));
            this.ExternalFieldName = externalFieldName ?? throw new global::System.ArgumentNullException(nameof(externalFieldName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CRMSyncMapping" /> class.
        /// </summary>
        public CRMSyncMapping()
        {
        }

    }
}