
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JobStatus
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.JobStatusStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.JobStatusStatus Status { get; set; }

        /// <summary>
        /// Epoch milliseconds when the job started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        public double? StartTimestamp { get; set; }

        /// <summary>
        /// Number of items processed successfully so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded")]
        public double? Succeeded { get; set; }

        /// <summary>
        /// Number of items that errored so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public double? Failed { get; set; }

        /// <summary>
        /// Whether the job was started by an explicit API call (`manual`) or by the scheduled sync (`cron`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggered_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.JobStatusTriggeredByJsonConverter))]
        public global::RetellAI.JobStatusTriggeredBy? TriggeredBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobStatus" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="startTimestamp">
        /// Epoch milliseconds when the job started.
        /// </param>
        /// <param name="succeeded">
        /// Number of items processed successfully so far.
        /// </param>
        /// <param name="failed">
        /// Number of items that errored so far.
        /// </param>
        /// <param name="triggeredBy">
        /// Whether the job was started by an explicit API call (`manual`) or by the scheduled sync (`cron`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobStatus(
            global::RetellAI.JobStatusStatus status,
            double? startTimestamp,
            double? succeeded,
            double? failed,
            global::RetellAI.JobStatusTriggeredBy? triggeredBy)
        {
            this.Status = status;
            this.StartTimestamp = startTimestamp;
            this.Succeeded = succeeded;
            this.Failed = failed;
            this.TriggeredBy = triggeredBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobStatus" /> class.
        /// </summary>
        public JobStatus()
        {
        }

    }
}