
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolCallInvocationUtteranceMetadata
    {
        /// <summary>
        /// Selection details for a winning backup model used in a response or tool invocation. Timings are measured from the start of the candidate race to selection or first usable output, not completion of generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backup_model_used")]
        public global::RetellAI.BackupModelUsed? BackupModelUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallInvocationUtteranceMetadata" /> class.
        /// </summary>
        /// <param name="backupModelUsed">
        /// Selection details for a winning backup model used in a response or tool invocation. Timings are measured from the start of the candidate race to selection or first usable output, not completion of generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallInvocationUtteranceMetadata(
            global::RetellAI.BackupModelUsed? backupModelUsed)
        {
            this.BackupModelUsed = backupModelUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallInvocationUtteranceMetadata" /> class.
        /// </summary>
        public ToolCallInvocationUtteranceMetadata()
        {
        }

    }
}