
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BreakdownMetric
    {
        /// <summary>
        /// Aggregate counts for each category across all time buckets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_breakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.Breakdown> OverallBreakdown { get; set; }

        /// <summary>
        /// Each element contains the category breakdown for the corresponding entry in timepoints, in the same order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_breakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::RetellAI.Breakdown>> TimeBreakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BreakdownMetric" /> class.
        /// </summary>
        /// <param name="overallBreakdown">
        /// Aggregate counts for each category across all time buckets.
        /// </param>
        /// <param name="timeBreakdown">
        /// Each element contains the category breakdown for the corresponding entry in timepoints, in the same order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BreakdownMetric(
            global::System.Collections.Generic.IList<global::RetellAI.Breakdown> overallBreakdown,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::RetellAI.Breakdown>> timeBreakdown)
        {
            this.OverallBreakdown = overallBreakdown ?? throw new global::System.ArgumentNullException(nameof(overallBreakdown));
            this.TimeBreakdown = timeBreakdown ?? throw new global::System.ArgumentNullException(nameof(timeBreakdown));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BreakdownMetric" /> class.
        /// </summary>
        public BreakdownMetric()
        {
        }

    }
}