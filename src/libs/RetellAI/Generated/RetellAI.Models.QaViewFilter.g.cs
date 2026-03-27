
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Filter criteria for QA views.
    /// </summary>
    public sealed partial class QaViewFilter
    {
        /// <summary>
        /// Filter by agent(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>? Agent { get; set; }

        /// <summary>
        /// Start timestamp filter (epoch ms).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? StartTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public global::RetellAI.NumberFilter? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnection_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.QaViewFilterDisconnectionReason>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.QaViewFilterDisconnectionReason>? DisconnectionReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<bool?, global::RetellAI.BooleanFilter>))]
        public global::RetellAI.OneOf<bool?, global::RetellAI.BooleanFilter>? Passed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calibrated")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<bool?, global::RetellAI.BooleanFilter>))]
        public global::RetellAI.OneOf<bool?, global::RetellAI.BooleanFilter>? Calibrated { get; set; }

        /// <summary>
        /// Deprecated: use 'agent' instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>? Agents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_range")]
        public global::RetellAI.DateRange? DateRange { get; set; }

        /// <summary>
        /// Deprecated: use 'score' instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_range")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::RetellAI.QaViewFilterScoreRange? ScoreRange { get; set; }

        /// <summary>
        /// Deprecated: use 'disconnection_reason' instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnection_reasons")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::RetellAI.DisconnectionReason4>? DisconnectionReasons { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QaViewFilter" /> class.
        /// </summary>
        /// <param name="agent">
        /// Filter by agent(s).
        /// </param>
        /// <param name="startTimestamp">
        /// Start timestamp filter (epoch ms).
        /// </param>
        /// <param name="score"></param>
        /// <param name="disconnectionReason"></param>
        /// <param name="passed"></param>
        /// <param name="calibrated"></param>
        /// <param name="dateRange"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QaViewFilter(
            global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>? agent,
            global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? startTimestamp,
            global::RetellAI.NumberFilter? score,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.QaViewFilterDisconnectionReason>? disconnectionReason,
            global::RetellAI.OneOf<bool?, global::RetellAI.BooleanFilter>? passed,
            global::RetellAI.OneOf<bool?, global::RetellAI.BooleanFilter>? calibrated,
            global::RetellAI.DateRange? dateRange)
        {
            this.Agent = agent;
            this.StartTimestamp = startTimestamp;
            this.Score = score;
            this.DisconnectionReason = disconnectionReason;
            this.Passed = passed;
            this.Calibrated = calibrated;
            this.DateRange = dateRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QaViewFilter" /> class.
        /// </summary>
        public QaViewFilter()
        {
        }
    }
}