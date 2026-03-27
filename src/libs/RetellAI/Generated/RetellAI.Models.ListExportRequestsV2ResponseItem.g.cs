
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListExportRequestsV2ResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_request_id")]
        public string? ExportRequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ListExportRequestsV2ResponseItemChannelJsonConverter))]
        public global::RetellAI.ListExportRequestsV2ResponseItemChannel? Channel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ListExportRequestsV2ResponseItemStatusJsonConverter))]
        public global::RetellAI.ListExportRequestsV2ResponseItemStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_timestamp")]
        public int? CreatedTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListExportRequestsV2ResponseItem" /> class.
        /// </summary>
        /// <param name="exportRequestId"></param>
        /// <param name="channel"></param>
        /// <param name="status"></param>
        /// <param name="url"></param>
        /// <param name="createdTimestamp"></param>
        /// <param name="timezone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListExportRequestsV2ResponseItem(
            string? exportRequestId,
            global::RetellAI.ListExportRequestsV2ResponseItemChannel? channel,
            global::RetellAI.ListExportRequestsV2ResponseItemStatus? status,
            string? url,
            int? createdTimestamp,
            string? timezone)
        {
            this.ExportRequestId = exportRequestId;
            this.Channel = channel;
            this.Status = status;
            this.Url = url;
            this.CreatedTimestamp = createdTimestamp;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListExportRequestsV2ResponseItem" /> class.
        /// </summary>
        public ListExportRequestsV2ResponseItem()
        {
        }
    }
}