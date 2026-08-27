
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessageBase
    {
        /// <summary>
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </summary>
        /// <example>Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// Documents whether this message is sent by agent or user.<br/>
        /// Example: agent
        /// </summary>
        /// <example>agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.MessageBaseRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.MessageBaseRole Role { get; set; }

        /// <summary>
        /// Content of the message<br/>
        /// Example: hi how are you doing?
        /// </summary>
        /// <example>hi how are you doing?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Multimedia attachments received with this message (MMS). Display only; a textual summary of each attachment is already included in content. Response only — supplying it in a request has no effect and is silently ignored. Omitted from PII-scrubbed messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multimedia")]
        public global::System.Collections.Generic.IList<global::RetellAI.SmsMultimediaItem>? Multimedia { get; set; }

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
        /// Initializes a new instance of the <see cref="MessageBase" /> class.
        /// </summary>
        /// <param name="role">
        /// Documents whether this message is sent by agent or user.<br/>
        /// Example: agent
        /// </param>
        /// <param name="content">
        /// Content of the message<br/>
        /// Example: hi how are you doing?
        /// </param>
        /// <param name="messageId">
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </param>
        /// <param name="multimedia">
        /// Multimedia attachments received with this message (MMS). Display only; a textual summary of each attachment is already included in content. Response only — supplying it in a request has no effect and is silently ignored. Omitted from PII-scrubbed messages.
        /// </param>
        /// <param name="createdTimestamp">
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageBase(
            global::RetellAI.MessageBaseRole role,
            string content,
            string? messageId,
            global::System.Collections.Generic.IList<global::RetellAI.SmsMultimediaItem>? multimedia,
            long? createdTimestamp)
        {
            this.MessageId = messageId;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Multimedia = multimedia;
            this.CreatedTimestamp = createdTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBase" /> class.
        /// </summary>
        public MessageBase()
        {
        }

    }
}