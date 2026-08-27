
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListConversationFlowsResponse5
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ListConversationFlowsResponseStatus3JsonConverter))]
        public global::RetellAI.ListConversationFlowsResponseStatus3? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="ListConversationFlowsResponse5" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Forbidden
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListConversationFlowsResponse5(
            global::RetellAI.ListConversationFlowsResponseStatus3? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConversationFlowsResponse5" /> class.
        /// </summary>
        public ListConversationFlowsResponse5()
        {
        }

    }
}