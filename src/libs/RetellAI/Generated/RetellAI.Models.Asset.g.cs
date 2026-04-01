
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Asset
    {
        /// <summary>
        /// Unique identifier for the asset.<br/>
        /// Example: asset_abc123def456
        /// </summary>
        /// <example>asset_abc123def456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// Original file name of the uploaded asset.<br/>
        /// Example: screenshot.png
        /// </summary>
        /// <example>screenshot.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// MIME type of the asset.<br/>
        /// Example: image/png
        /// </summary>
        /// <example>image/png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// File size in bytes.<br/>
        /// Example: 204800
        /// </summary>
        /// <example>204800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size")]
        public double? FileSize { get; set; }

        /// <summary>
        /// CDN URL to access the asset.<br/>
        /// Example: https://cdn.example.com/asset/org_123/asset_abc123def456/screenshot.png
        /// </summary>
        /// <example>https://cdn.example.com/asset/org_123/asset_abc123def456/screenshot.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Unix timestamp of when the asset was created.<br/>
        /// Example: 1710000000000
        /// </summary>
        /// <example>1710000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_timestamp")]
        public double? CreatedTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        /// <param name="assetId">
        /// Unique identifier for the asset.<br/>
        /// Example: asset_abc123def456
        /// </param>
        /// <param name="fileName">
        /// Original file name of the uploaded asset.<br/>
        /// Example: screenshot.png
        /// </param>
        /// <param name="contentType">
        /// MIME type of the asset.<br/>
        /// Example: image/png
        /// </param>
        /// <param name="fileSize">
        /// File size in bytes.<br/>
        /// Example: 204800
        /// </param>
        /// <param name="url">
        /// CDN URL to access the asset.<br/>
        /// Example: https://cdn.example.com/asset/org_123/asset_abc123def456/screenshot.png
        /// </param>
        /// <param name="createdTimestamp">
        /// Unix timestamp of when the asset was created.<br/>
        /// Example: 1710000000000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Asset(
            string? assetId,
            string? fileName,
            string? contentType,
            double? fileSize,
            string? url,
            double? createdTimestamp)
        {
            this.AssetId = assetId;
            this.FileName = fileName;
            this.ContentType = contentType;
            this.FileSize = fileSize;
            this.Url = url;
            this.CreatedTimestamp = createdTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        public Asset()
        {
        }
    }
}