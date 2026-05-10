
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListConversationFlowsV2Response5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ListConversationFlowsV2ResponseStatus3JsonConverter))]
        public global::RetellAI.ListConversationFlowsV2ResponseStatus3? Status { get; set; }

        /// <summary>
        /// Example: Forbidden
        /// </summary>
        /// <example>Forbidden</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConversationFlowsV2Response5" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Forbidden
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListConversationFlowsV2Response5(
            global::RetellAI.ListConversationFlowsV2ResponseStatus3? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConversationFlowsV2Response5" /> class.
        /// </summary>
        public ListConversationFlowsV2Response5()
        {
        }

    }
}