
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RecordChatMessageRequestVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.RecordChatMessageRequestVariant2RoleJsonConverter))]
        public global::RetellAI.RecordChatMessageRequestVariant2Role Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idempotency_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdempotencyKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::RetellAI.RecordChatMessageRequestVariant2Metadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordChatMessageRequestVariant2" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="idempotencyKey"></param>
        /// <param name="role"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordChatMessageRequestVariant2(
            string message,
            string idempotencyKey,
            global::RetellAI.RecordChatMessageRequestVariant2Role role,
            global::RetellAI.RecordChatMessageRequestVariant2Metadata? metadata)
        {
            this.Role = role;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.IdempotencyKey = idempotencyKey ?? throw new global::System.ArgumentNullException(nameof(idempotencyKey));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordChatMessageRequestVariant2" /> class.
        /// </summary>
        public RecordChatMessageRequestVariant2()
        {
        }

    }
}