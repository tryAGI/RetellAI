
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListContactsRequest
    {
        /// <summary>
        /// Maximum number of contacts to return.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Number of records to skip for offset-based pagination.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        public double? Skip { get; set; }

        /// <summary>
        /// Sort contacts by `last_conversation_timestamp` in ascending or descending order. Contacts that have never been contacted sort as if their timestamp were 0.<br/>
        /// Default Value: desc
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ListContactsRequestSortOrderJsonConverter))]
        public global::RetellAI.ListContactsRequestSortOrder? SortOrder { get; set; }

        /// <summary>
        /// Base64url-encoded pagination key from a previous response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination_key")]
        public string? PaginationKey { get; set; }

        /// <summary>
        /// Filter criteria for contacts. All conditions are implicitly connected with AND. first_name and last_name are not filterable here; use search_query to match on those.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_criteria")]
        public global::RetellAI.ContactFilter? FilterCriteria { get; set; }

        /// <summary>
        /// Case-insensitive substring match against phone number, first name, last name, external ID, and custom field values. This is the only way to match on a contact's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_query")]
        public string? SearchQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListContactsRequest" /> class.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of contacts to return.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="skip">
        /// Number of records to skip for offset-based pagination.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="sortOrder">
        /// Sort contacts by `last_conversation_timestamp` in ascending or descending order. Contacts that have never been contacted sort as if their timestamp were 0.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="paginationKey">
        /// Base64url-encoded pagination key from a previous response.
        /// </param>
        /// <param name="filterCriteria">
        /// Filter criteria for contacts. All conditions are implicitly connected with AND. first_name and last_name are not filterable here; use search_query to match on those.
        /// </param>
        /// <param name="searchQuery">
        /// Case-insensitive substring match against phone number, first name, last name, external ID, and custom field values. This is the only way to match on a contact's name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListContactsRequest(
            double? limit,
            double? skip,
            global::RetellAI.ListContactsRequestSortOrder? sortOrder,
            string? paginationKey,
            global::RetellAI.ContactFilter? filterCriteria,
            string? searchQuery)
        {
            this.Limit = limit;
            this.Skip = skip;
            this.SortOrder = sortOrder;
            this.PaginationKey = paginationKey;
            this.FilterCriteria = filterCriteria;
            this.SearchQuery = searchQuery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListContactsRequest" /> class.
        /// </summary>
        public ListContactsRequest()
        {
        }

    }
}