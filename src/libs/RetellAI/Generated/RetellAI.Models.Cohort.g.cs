
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// A QA cohort - a saved set of call filters, sampling, and scoring criteria used to evaluate a group of calls.
    /// </summary>
    public sealed partial class Cohort
    {
        /// <summary>
        /// Unique identifier for the cohort.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohort_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CohortId { get; set; }

        /// <summary>
        /// User-provided name of the cohort.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Call filter criteria to create QA.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohort_filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.CohortFilter CohortFilter { get; set; }

        /// <summary>
        /// Percentage of matching calls sampled for QA.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SamplingPercentage { get; set; }

        /// <summary>
        /// Optional cap on the number of calls sampled per week.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_weekly_max")]
        public double? SamplingWeeklyMax { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring_criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ScoringCriteria ScoringCriteria { get; set; }

        /// <summary>
        /// Score threshold a call must meet to be marked successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful_criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.CohortSuccessfulCriteria SuccessfulCriteria { get; set; }

        /// <summary>
        /// Total number of calls matched into the cohort.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCalls { get; set; }

        /// <summary>
        /// Number of analyzed calls that passed the cohort's success criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResolvedCalls { get; set; }

        /// <summary>
        /// Number of calls that have completed QA analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyzed_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AnalyzedCalls { get; set; }

        /// <summary>
        /// "default" requires every condition and metric to pass; "weighted" allows a lower `successful_criteria` threshold, so a call can pass without meeting every one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CohortEvaluationModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.CohortEvaluationMode EvaluationMode { get; set; }

        /// <summary>
        /// Whether QA processing for this cohort is paused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paused")]
        public bool? Paused { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Cohort" /> class.
        /// </summary>
        /// <param name="cohortId">
        /// Unique identifier for the cohort.
        /// </param>
        /// <param name="name">
        /// User-provided name of the cohort.
        /// </param>
        /// <param name="cohortFilter">
        /// Call filter criteria to create QA.
        /// </param>
        /// <param name="samplingPercentage">
        /// Percentage of matching calls sampled for QA.
        /// </param>
        /// <param name="scoringCriteria"></param>
        /// <param name="successfulCriteria">
        /// Score threshold a call must meet to be marked successful.
        /// </param>
        /// <param name="totalCalls">
        /// Total number of calls matched into the cohort.
        /// </param>
        /// <param name="resolvedCalls">
        /// Number of analyzed calls that passed the cohort's success criteria.
        /// </param>
        /// <param name="analyzedCalls">
        /// Number of calls that have completed QA analysis.
        /// </param>
        /// <param name="evaluationMode">
        /// "default" requires every condition and metric to pass; "weighted" allows a lower `successful_criteria` threshold, so a call can pass without meeting every one.
        /// </param>
        /// <param name="samplingWeeklyMax">
        /// Optional cap on the number of calls sampled per week.
        /// </param>
        /// <param name="paused">
        /// Whether QA processing for this cohort is paused.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Cohort(
            string cohortId,
            string name,
            global::RetellAI.CohortFilter cohortFilter,
            double samplingPercentage,
            global::RetellAI.ScoringCriteria scoringCriteria,
            global::RetellAI.CohortSuccessfulCriteria successfulCriteria,
            double totalCalls,
            double resolvedCalls,
            double analyzedCalls,
            global::RetellAI.CohortEvaluationMode evaluationMode,
            double? samplingWeeklyMax,
            bool? paused)
        {
            this.CohortId = cohortId ?? throw new global::System.ArgumentNullException(nameof(cohortId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CohortFilter = cohortFilter ?? throw new global::System.ArgumentNullException(nameof(cohortFilter));
            this.SamplingPercentage = samplingPercentage;
            this.SamplingWeeklyMax = samplingWeeklyMax;
            this.ScoringCriteria = scoringCriteria ?? throw new global::System.ArgumentNullException(nameof(scoringCriteria));
            this.SuccessfulCriteria = successfulCriteria ?? throw new global::System.ArgumentNullException(nameof(successfulCriteria));
            this.TotalCalls = totalCalls;
            this.ResolvedCalls = resolvedCalls;
            this.AnalyzedCalls = analyzedCalls;
            this.EvaluationMode = evaluationMode;
            this.Paused = paused;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cohort" /> class.
        /// </summary>
        public Cohort()
        {
        }

    }
}