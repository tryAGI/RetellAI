
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SmsMultimediaItem
    {
        /// <summary>
        /// URL of the multimedia attachment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Optional textual summary of the attachment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsMultimediaItem" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the multimedia attachment.
        /// </param>
        /// <param name="summary">
        /// Optional textual summary of the attachment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmsMultimediaItem(
            string url,
            string? summary)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsMultimediaItem" /> class.
        /// </summary>
        public SmsMultimediaItem()
        {
        }

    }
}