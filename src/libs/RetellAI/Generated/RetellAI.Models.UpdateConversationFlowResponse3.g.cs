
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConversationFlowResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.UpdateConversationFlowResponseStatus3JsonConverter))]
        public global::RetellAI.UpdateConversationFlowResponseStatus3? Status { get; set; }

        /// <summary>
        /// Example: Precondition failed for conditional update.
        /// </summary>
        /// <example>Precondition failed for conditional update.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversationFlowResponse3" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Precondition failed for conditional update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateConversationFlowResponse3(
            global::RetellAI.UpdateConversationFlowResponseStatus3? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversationFlowResponse3" /> class.
        /// </summary>
        public UpdateConversationFlowResponse3()
        {
        }

    }
}