
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListExportRequestsResponseItem
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ListExportRequestsResponseItemChannelJsonConverter))]
        public global::RetellAI.ListExportRequestsResponseItemChannel? Channel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ListExportRequestsResponseItemStatusJsonConverter))]
        public global::RetellAI.ListExportRequestsResponseItemStatus? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="ListExportRequestsResponseItem" /> class.
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
        public ListExportRequestsResponseItem(
            string? exportRequestId,
            global::RetellAI.ListExportRequestsResponseItemChannel? channel,
            global::RetellAI.ListExportRequestsResponseItemStatus? status,
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
        /// Initializes a new instance of the <see cref="ListExportRequestsResponseItem" /> class.
        /// </summary>
        public ListExportRequestsResponseItem()
        {
        }

    }
}