
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UploadContactImportFileResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        public string? UploadId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadContactImportFileResponse" /> class.
        /// </summary>
        /// <param name="uploadId"></param>
        /// <param name="fileName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadContactImportFileResponse(
            string? uploadId,
            string? fileName)
        {
            this.UploadId = uploadId;
            this.FileName = fileName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadContactImportFileResponse" /> class.
        /// </summary>
        public UploadContactImportFileResponse()
        {
        }

    }
}