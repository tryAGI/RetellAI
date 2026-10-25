
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Selection details for a winning backup model used in a response or tool invocation. Timings are measured from the start of the candidate race to selection or first usable output, not completion of generation.
    /// </summary>
    public sealed partial class BackupModelUsed
    {
        /// <summary>
        /// Actual selected model after routing and retries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Primary model configured for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrimaryModel { get; set; }

        /// <summary>
        /// Backup model configured for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backup_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BackupModel { get; set; }

        /// <summary>
        /// Why the backup won. primary_failed means primary attempts failed; preference_expired means backup was ready within the primary preference window; first_usable means backup became ready after that window and won the race.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.BackupModelUsedReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.BackupModelUsedReason Reason { get; set; }

        /// <summary>
        /// Elapsed milliseconds from race start to winner selection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selection_latency_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SelectionLatencyMs { get; set; }

        /// <summary>
        /// Elapsed milliseconds until primary produced usable output. Omitted if primary was not ready when the winner was selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_ready_ms")]
        public double? PrimaryReadyMs { get; set; }

        /// <summary>
        /// Elapsed milliseconds until backup produced usable output. Omitted when unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backup_ready_ms")]
        public double? BackupReadyMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupModelUsed" /> class.
        /// </summary>
        /// <param name="model">
        /// Actual selected model after routing and retries.
        /// </param>
        /// <param name="primaryModel">
        /// Primary model configured for this request.
        /// </param>
        /// <param name="backupModel">
        /// Backup model configured for this request.
        /// </param>
        /// <param name="reason">
        /// Why the backup won. primary_failed means primary attempts failed; preference_expired means backup was ready within the primary preference window; first_usable means backup became ready after that window and won the race.
        /// </param>
        /// <param name="selectionLatencyMs">
        /// Elapsed milliseconds from race start to winner selection.
        /// </param>
        /// <param name="primaryReadyMs">
        /// Elapsed milliseconds until primary produced usable output. Omitted if primary was not ready when the winner was selected.
        /// </param>
        /// <param name="backupReadyMs">
        /// Elapsed milliseconds until backup produced usable output. Omitted when unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupModelUsed(
            string model,
            string primaryModel,
            string backupModel,
            global::RetellAI.BackupModelUsedReason reason,
            double selectionLatencyMs,
            double? primaryReadyMs,
            double? backupReadyMs)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.PrimaryModel = primaryModel ?? throw new global::System.ArgumentNullException(nameof(primaryModel));
            this.BackupModel = backupModel ?? throw new global::System.ArgumentNullException(nameof(backupModel));
            this.Reason = reason;
            this.SelectionLatencyMs = selectionLatencyMs;
            this.PrimaryReadyMs = primaryReadyMs;
            this.BackupReadyMs = backupReadyMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupModelUsed" /> class.
        /// </summary>
        public BackupModelUsed()
        {
        }

    }
}