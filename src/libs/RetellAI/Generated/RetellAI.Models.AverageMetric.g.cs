
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AverageMetric
    {
        /// <summary>
        /// Contains one average per entry in timepoints, in the same order. null indicates no qualifying observations for that metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_averages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> TimeAverages { get; set; }

        /// <summary>
        /// Weighted average across all time buckets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_average")]
        public double? OverallAverage { get; set; }

        /// <summary>
        /// Aggregate numerator used to calculate overall_average.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numerator")]
        public double? Numerator { get; set; }

        /// <summary>
        /// Aggregate denominator used to calculate overall_average.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("denominator")]
        public double? Denominator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AverageMetric" /> class.
        /// </summary>
        /// <param name="timeAverages">
        /// Contains one average per entry in timepoints, in the same order. null indicates no qualifying observations for that metric.
        /// </param>
        /// <param name="overallAverage">
        /// Weighted average across all time buckets.
        /// </param>
        /// <param name="numerator">
        /// Aggregate numerator used to calculate overall_average.
        /// </param>
        /// <param name="denominator">
        /// Aggregate denominator used to calculate overall_average.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AverageMetric(
            global::System.Collections.Generic.IList<double> timeAverages,
            double? overallAverage,
            double? numerator,
            double? denominator)
        {
            this.TimeAverages = timeAverages ?? throw new global::System.ArgumentNullException(nameof(timeAverages));
            this.OverallAverage = overallAverage;
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AverageMetric" /> class.
        /// </summary>
        public AverageMetric()
        {
        }

    }
}