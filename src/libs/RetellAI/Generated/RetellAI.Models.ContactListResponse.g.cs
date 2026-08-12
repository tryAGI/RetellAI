
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContactListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::RetellAI.Contact>? Items { get; set; }

        /// <summary>
        /// Base64url-encoded pagination key for the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination_key")]
        public string? PaginationKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Total count of contacts matching the filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public double? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="paginationKey">
        /// Base64url-encoded pagination key for the next page.
        /// </param>
        /// <param name="hasMore"></param>
        /// <param name="total">
        /// Total count of contacts matching the filter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactListResponse(
            global::System.Collections.Generic.IList<global::RetellAI.Contact>? items,
            string? paginationKey,
            bool? hasMore,
            double? total)
        {
            this.Items = items;
            this.PaginationKey = paginationKey;
            this.HasMore = hasMore;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListResponse" /> class.
        /// </summary>
        public ContactListResponse()
        {
        }

    }
}