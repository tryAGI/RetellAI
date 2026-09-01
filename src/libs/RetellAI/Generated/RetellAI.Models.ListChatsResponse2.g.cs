
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListChatsResponse2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.V3ChatResponse> Items { get; set; }

        /// <summary>
        /// Total number of chats matching `filter_criteria`. Only present when `include_total` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChatsResponse2" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="total">
        /// Total number of chats matching `filter_criteria`. Only present when `include_total` is true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListChatsResponse2(
            global::System.Collections.Generic.IList<global::RetellAI.V3ChatResponse> items,
            int? total)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChatsResponse2" /> class.
        /// </summary>
        public ListChatsResponse2()
        {
        }

    }
}