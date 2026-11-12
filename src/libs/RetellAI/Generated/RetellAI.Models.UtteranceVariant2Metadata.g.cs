
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UtteranceVariant2Metadata
    {
        /// <summary>
        /// Call-scoped agent response identifier, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public int? ResponseId { get; set; }

        /// <summary>
        /// Custom LLM agent interruption identifier, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupt_id")]
        public int? InterruptId { get; set; }

        /// <summary>
        /// Whether the utterance is a backchannel acknowledgment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_backchannel")]
        public bool? IsBackchannel { get; set; }

        /// <summary>
        /// Whether the user cut off this agent utterance before it finished playing. Only set for Retell LLM and conversation flow agents; absent when the agent was not interrupted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupted")]
        public bool? Interrupted { get; set; }

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
        /// Initializes a new instance of the <see cref="UtteranceVariant2Metadata" /> class.
        /// </summary>
        /// <param name="responseId">
        /// Call-scoped agent response identifier, when available.
        /// </param>
        /// <param name="interruptId">
        /// Custom LLM agent interruption identifier, when available.
        /// </param>
        /// <param name="isBackchannel">
        /// Whether the utterance is a backchannel acknowledgment.
        /// </param>
        /// <param name="interrupted">
        /// Whether the user cut off this agent utterance before it finished playing. Only set for Retell LLM and conversation flow agents; absent when the agent was not interrupted.
        /// </param>
        /// <param name="backupModelUsed">
        /// Selection details for a winning backup model used in a response or tool invocation. Timings are measured from the start of the candidate race to selection or first usable output, not completion of generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UtteranceVariant2Metadata(
            int? responseId,
            int? interruptId,
            bool? isBackchannel,
            bool? interrupted,
            global::RetellAI.BackupModelUsed? backupModelUsed)
        {
            this.ResponseId = responseId;
            this.InterruptId = interruptId;
            this.IsBackchannel = isBackchannel;
            this.Interrupted = interrupted;
            this.BackupModelUsed = backupModelUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceVariant2Metadata" /> class.
        /// </summary>
        public UtteranceVariant2Metadata()
        {
        }

    }
}