
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Sorting and pagination options for listing a cohort's call QAs.
    /// </summary>
    public sealed partial class CohortQaListArgs
    {
        /// <summary>
        /// Field to sort by. Defaults to "score".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CohortQaListArgsSortKeyJsonConverter))]
        public global::RetellAI.CohortQaListArgsSortKey? SortKey { get; set; }

        /// <summary>
        /// Maximum number of records to return. Defaults to 1000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Sort order. Defaults to "desc".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CohortQaListArgsOrderJsonConverter))]
        public global::RetellAI.CohortQaListArgsOrder? Order { get; set; }

        /// <summary>
        /// Number of records to skip for pagination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        public int? Skip { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortQaListArgs" /> class.
        /// </summary>
        /// <param name="sortKey">
        /// Field to sort by. Defaults to "score".
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return. Defaults to 1000.
        /// </param>
        /// <param name="order">
        /// Sort order. Defaults to "desc".
        /// </param>
        /// <param name="skip">
        /// Number of records to skip for pagination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CohortQaListArgs(
            global::RetellAI.CohortQaListArgsSortKey? sortKey,
            int? limit,
            global::RetellAI.CohortQaListArgsOrder? order,
            int? skip)
        {
            this.SortKey = sortKey;
            this.Limit = limit;
            this.Order = order;
            this.Skip = skip;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortQaListArgs" /> class.
        /// </summary>
        public CohortQaListArgs()
        {
        }

    }
}