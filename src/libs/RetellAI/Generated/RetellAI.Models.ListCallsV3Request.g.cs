
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCallsV3Request
    {
        /// <summary>
        /// Filter criteria for calls. All conditions are implicitly connected with AND.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_criteria")]
        public global::RetellAI.CallFilter? FilterCriteria { get; set; }

        /// <summary>
        /// Sort calls by `start_timestamp` in ascending or descending order.<br/>
        /// Default Value: descending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ListCallsV3RequestSortOrderJsonConverter))]
        public global::RetellAI.ListCallsV3RequestSortOrder? SortOrder { get; set; }

        /// <summary>
        /// Maximum number of calls to return.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Number of records to skip for pagination.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        public int? Skip { get; set; }

        /// <summary>
        /// Opaque pagination cursor from a previous response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination_key")]
        public string? PaginationKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCallsV3Request" /> class.
        /// </summary>
        /// <param name="filterCriteria">
        /// Filter criteria for calls. All conditions are implicitly connected with AND.
        /// </param>
        /// <param name="sortOrder">
        /// Sort calls by `start_timestamp` in ascending or descending order.<br/>
        /// Default Value: descending
        /// </param>
        /// <param name="limit">
        /// Maximum number of calls to return.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="skip">
        /// Number of records to skip for pagination.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="paginationKey">
        /// Opaque pagination cursor from a previous response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCallsV3Request(
            global::RetellAI.CallFilter? filterCriteria,
            global::RetellAI.ListCallsV3RequestSortOrder? sortOrder,
            int? limit,
            int? skip,
            string? paginationKey)
        {
            this.FilterCriteria = filterCriteria;
            this.SortOrder = sortOrder;
            this.Limit = limit;
            this.Skip = skip;
            this.PaginationKey = paginationKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCallsV3Request" /> class.
        /// </summary>
        public ListCallsV3Request()
        {
        }

    }
}