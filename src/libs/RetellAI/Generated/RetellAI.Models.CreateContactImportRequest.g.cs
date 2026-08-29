
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateContactImportRequest
    {
        /// <summary>
        /// Id returned by upload-contact-import-file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadId { get; set; }

        /// <summary>
        /// CSV headers mapped to contact fields. field_name is the contact field and external_field_name is the CSV header. Exactly one mapping must target phone_number. Unmapped columns are ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_mapping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.CRMSyncMapping> ColumnMapping { get; set; }

        /// <summary>
        /// Country for parsing phone numbers without a country code. Defaults to US.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_country")]
        public string? DefaultCountry { get; set; }

        /// <summary>
        /// Tags added to every contact in this import. Existing tags are preserved. Omit to leave tags unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactImportRequest" /> class.
        /// </summary>
        /// <param name="uploadId">
        /// Id returned by upload-contact-import-file.
        /// </param>
        /// <param name="columnMapping">
        /// CSV headers mapped to contact fields. field_name is the contact field and external_field_name is the CSV header. Exactly one mapping must target phone_number. Unmapped columns are ignored.
        /// </param>
        /// <param name="defaultCountry">
        /// Country for parsing phone numbers without a country code. Defaults to US.
        /// </param>
        /// <param name="tags">
        /// Tags added to every contact in this import. Existing tags are preserved. Omit to leave tags unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateContactImportRequest(
            string uploadId,
            global::System.Collections.Generic.IList<global::RetellAI.CRMSyncMapping> columnMapping,
            string? defaultCountry,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.UploadId = uploadId ?? throw new global::System.ArgumentNullException(nameof(uploadId));
            this.ColumnMapping = columnMapping ?? throw new global::System.ArgumentNullException(nameof(columnMapping));
            this.DefaultCountry = defaultCountry;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactImportRequest" /> class.
        /// </summary>
        public CreateContactImportRequest()
        {
        }

    }
}