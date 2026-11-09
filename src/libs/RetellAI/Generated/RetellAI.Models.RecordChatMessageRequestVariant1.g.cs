
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RecordChatMessageRequestVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.RecordChatMessageRequestVariant1RoleJsonConverter))]
        public global::RetellAI.RecordChatMessageRequestVariant1Role Role { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordChatMessageRequestVariant1" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="idempotencyKey"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordChatMessageRequestVariant1(
            string message,
            string idempotencyKey,
            global::RetellAI.RecordChatMessageRequestVariant1Role role)
        {
            this.Role = role;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.IdempotencyKey = idempotencyKey ?? throw new global::System.ArgumentNullException(nameof(idempotencyKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordChatMessageRequestVariant1" /> class.
        /// </summary>
        public RecordChatMessageRequestVariant1()
        {
        }

    }
}