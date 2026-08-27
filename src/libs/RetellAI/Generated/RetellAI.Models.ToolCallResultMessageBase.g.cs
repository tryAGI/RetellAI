
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolCallResultMessageBase
    {
        /// <summary>
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </summary>
        /// <example>Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// This is the result of a tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ToolCallResultMessageBaseRoleJsonConverter))]
        public global::RetellAI.ToolCallResultMessageBaseRole Role { get; set; }

        /// <summary>
        /// Tool call id, globally unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Result of the tool call, can be a string, a stringified json, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Whether the tool call was successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        public bool? Successful { get; set; }

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
        /// Initializes a new instance of the <see cref="ToolCallResultMessageBase" /> class.
        /// </summary>
        /// <param name="toolCallId">
        /// Tool call id, globally unique.
        /// </param>
        /// <param name="content">
        /// Result of the tool call, can be a string, a stringified json, etc.
        /// </param>
        /// <param name="messageId">
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </param>
        /// <param name="role">
        /// This is the result of a tool call.
        /// </param>
        /// <param name="successful">
        /// Whether the tool call was successful.
        /// </param>
        /// <param name="createdTimestamp">
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallResultMessageBase(
            string toolCallId,
            string content,
            string? messageId,
            global::RetellAI.ToolCallResultMessageBaseRole role,
            bool? successful,
            long? createdTimestamp)
        {
            this.MessageId = messageId;
            this.Role = role;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Successful = successful;
            this.CreatedTimestamp = createdTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallResultMessageBase" /> class.
        /// </summary>
        public ToolCallResultMessageBase()
        {
        }

    }
}