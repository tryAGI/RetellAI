
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContactConversationListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::RetellAI.ContactConversation>? Items { get; set; }

        /// <summary>
        /// Base64url-encoded pagination key. Pass as `pagination_key` query parameter to fetch the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination_key")]
        public string? PaginationKey { get; set; }

        /// <summary>
        /// Whether more conversations exist beyond the returned window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactConversationListResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="paginationKey">
        /// Base64url-encoded pagination key. Pass as `pagination_key` query parameter to fetch the next page.
        /// </param>
        /// <param name="hasMore">
        /// Whether more conversations exist beyond the returned window.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactConversationListResponse(
            global::System.Collections.Generic.IList<global::RetellAI.ContactConversation>? items,
            string? paginationKey,
            bool? hasMore)
        {
            this.Items = items;
            this.PaginationKey = paginationKey;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactConversationListResponse" /> class.
        /// </summary>
        public ContactConversationListResponse()
        {
        }

    }
}