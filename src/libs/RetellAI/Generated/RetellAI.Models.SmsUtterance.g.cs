
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmsUtterance
    {
        /// <summary>
        /// SMS message received from the user during the call (for example while the agent is leaving a voicemail). Not part of the spoken conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SmsUtteranceRoleJsonConverter))]
        public global::RetellAI.SmsUtteranceRole Role { get; set; }

        /// <summary>
        /// Text content of the SMS message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Multimedia attachments (MMS). Display only; not relayed into the spoken conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multimedia")]
        public global::System.Collections.Generic.IList<global::RetellAI.SmsMultimediaItem>? Multimedia { get; set; }

        /// <summary>
        /// Time the SMS was received, in seconds relative to the start of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TimeSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsUtterance" /> class.
        /// </summary>
        /// <param name="content">
        /// Text content of the SMS message.
        /// </param>
        /// <param name="timeSec">
        /// Time the SMS was received, in seconds relative to the start of the call.
        /// </param>
        /// <param name="role">
        /// SMS message received from the user during the call (for example while the agent is leaving a voicemail). Not part of the spoken conversation.
        /// </param>
        /// <param name="multimedia">
        /// Multimedia attachments (MMS). Display only; not relayed into the spoken conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmsUtterance(
            string content,
            double timeSec,
            global::RetellAI.SmsUtteranceRole role,
            global::System.Collections.Generic.IList<global::RetellAI.SmsMultimediaItem>? multimedia)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Multimedia = multimedia;
            this.TimeSec = timeSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsUtterance" /> class.
        /// </summary>
        public SmsUtterance()
        {
        }

    }
}