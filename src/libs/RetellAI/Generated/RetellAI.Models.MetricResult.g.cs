
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricResult
    {
        /// <summary>
        /// Can be either a PerformanceMetricCriteria or CustomMetricCriteria object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_criteria")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.OneOf<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria> MetricCriteria { get; set; }

        /// <summary>
        /// The calculated value of the metric. Omittable for custom metric criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<double?, bool?, string>))]
        public global::RetellAI.OneOf<double?, bool?, string>? Value { get; set; }

        /// <summary>
        /// An optional vote based on the metric result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vote")]
        public bool? Vote { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricResult" /> class.
        /// </summary>
        /// <param name="metricCriteria">
        /// Can be either a PerformanceMetricCriteria or CustomMetricCriteria object.
        /// </param>
        /// <param name="value">
        /// The calculated value of the metric. Omittable for custom metric criteria.
        /// </param>
        /// <param name="vote">
        /// An optional vote based on the metric result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricResult(
            global::RetellAI.OneOf<global::RetellAI.PerformanceMetricCriteria, global::RetellAI.CustomMetricCriteria> metricCriteria,
            global::RetellAI.OneOf<double?, bool?, string>? value,
            bool? vote)
        {
            this.MetricCriteria = metricCriteria;
            this.Value = value;
            this.Vote = vote;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricResult" /> class.
        /// </summary>
        public MetricResult()
        {
        }
    }
}