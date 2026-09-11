
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BackfillContactAnalysisDataRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_call_filter")]
        public global::RetellAI.BackfillContactAnalysisDataRequestBackfillCallFilter? BackfillCallFilter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> BackfillAttributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackfillContactAnalysisDataRequest" /> class.
        /// </summary>
        /// <param name="backfillAttributes"></param>
        /// <param name="backfillCallFilter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackfillContactAnalysisDataRequest(
            global::System.Collections.Generic.IList<string> backfillAttributes,
            global::RetellAI.BackfillContactAnalysisDataRequestBackfillCallFilter? backfillCallFilter)
        {
            this.BackfillCallFilter = backfillCallFilter;
            this.BackfillAttributes = backfillAttributes ?? throw new global::System.ArgumentNullException(nameof(backfillAttributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackfillContactAnalysisDataRequest" /> class.
        /// </summary>
        public BackfillContactAnalysisDataRequest()
        {
        }

    }
}