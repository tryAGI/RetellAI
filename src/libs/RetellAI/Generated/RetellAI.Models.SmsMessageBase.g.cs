
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmsMessageBase
    {
        /// <summary>
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </summary>
        /// <example>Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// SMS message exchanged during the call (for example received from the user). Woven into the transcript and shown to the agent, but not part of the spoken conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SmsMessageBaseRoleJsonConverter))]
        public global::RetellAI.SmsMessageBaseRole Role { get; set; }

        /// <summary>
        /// Text content of the SMS message.<br/>
        /// Example: Here is the photo you asked for.
        /// </summary>
        /// <example>Here is the photo you asked for.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Multimedia attachments (MMS). Display only; not relayed into the spoken conversation.
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
        /// Initializes a new instance of the <see cref="SmsMessageBase" /> class.
        /// </summary>
        /// <param name="content">
        /// Text content of the SMS message.<br/>
        /// Example: Here is the photo you asked for.
        /// </param>
        /// <param name="messageId">
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </param>
        /// <param name="role">
        /// SMS message exchanged during the call (for example received from the user). Woven into the transcript and shown to the agent, but not part of the spoken conversation.
        /// </param>
        /// <param name="multimedia">
        /// Multimedia attachments (MMS). Display only; not relayed into the spoken conversation.
        /// </param>
        /// <param name="createdTimestamp">
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmsMessageBase(
            string content,
            string? messageId,
            global::RetellAI.SmsMessageBaseRole role,
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
        /// Initializes a new instance of the <see cref="SmsMessageBase" /> class.
        /// </summary>
        public SmsMessageBase()
        {
        }

    }
}