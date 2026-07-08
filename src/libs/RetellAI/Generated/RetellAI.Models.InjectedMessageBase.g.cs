
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InjectedMessageBase
    {
        /// <summary>
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </summary>
        /// <example>Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// External context injected into the conversation via the update-live-call API. Not spoken by either party.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.InjectedMessageBaseRoleJsonConverter))]
        public global::RetellAI.InjectedMessageBaseRole Role { get; set; }

        /// <summary>
        /// The injected context text.<br/>
        /// Example: Customer just opened a support ticket about billing.
        /// </summary>
        /// <example>Customer just opened a support ticket about billing.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </summary>
        /// <example>1703302428855</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_timestamp")]
        public long? CreatedTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InjectedMessageBase" /> class.
        /// </summary>
        /// <param name="content">
        /// The injected context text.<br/>
        /// Example: Customer just opened a support ticket about billing.
        /// </param>
        /// <param name="messageId">
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </param>
        /// <param name="role">
        /// External context injected into the conversation via the update-live-call API. Not spoken by either party.
        /// </param>
        /// <param name="createdTimestamp">
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InjectedMessageBase(
            string content,
            string? messageId,
            global::RetellAI.InjectedMessageBaseRole role,
            long? createdTimestamp)
        {
            this.MessageId = messageId;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.CreatedTimestamp = createdTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InjectedMessageBase" /> class.
        /// </summary>
        public InjectedMessageBase()
        {
        }

    }
}