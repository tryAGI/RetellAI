
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BackupModelChoiceVariant2
    {
        /// <summary>
        /// Duration in milliseconds to prefer primary model output while both models run concurrently. Must be between 300 and 60000 milliseconds, inclusive. Defaults to 1500 when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backup_kick_in_timeout")]
        public int? BackupKickInTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupModelChoiceVariant2" /> class.
        /// </summary>
        /// <param name="backupKickInTimeout">
        /// Duration in milliseconds to prefer primary model output while both models run concurrently. Must be between 300 and 60000 milliseconds, inclusive. Defaults to 1500 when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupModelChoiceVariant2(
            int? backupKickInTimeout)
        {
            this.BackupKickInTimeout = backupKickInTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupModelChoiceVariant2" /> class.
        /// </summary>
        public BackupModelChoiceVariant2()
        {
        }

    }
}