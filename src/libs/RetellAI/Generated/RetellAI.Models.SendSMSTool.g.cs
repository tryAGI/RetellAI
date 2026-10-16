
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SendSMSTool
    {
        /// <summary>
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state edges). Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SendSMSToolTypeJsonConverter))]
        public global::RetellAI.SendSMSToolType Type { get; set; }

        /// <summary>
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// If true, the agent will speak a short line before sending the SMS. If omitted, defaults to true (same as end_call / transfer_call tools).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// Describes what to say before sending the SMS. Only applicable when speak_during_execution is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_message_description")]
        public string? ExecutionMessageDescription { get; set; }

        /// <summary>
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SendSMSToolExecutionMessageTypeJsonConverter))]
        public global::RetellAI.SendSMSToolExecutionMessageType? ExecutionMessageType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SmsContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.SmsContent SmsContent { get; set; }

        /// <summary>
        /// SMS sender number configuration. If omitted, the message is sent from the agent's phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_sender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AnyOfJsonConverter<global::RetellAI.SmsSender2?, object>))]
        public global::RetellAI.AnyOf<global::RetellAI.SmsSender2?, object>? SmsSender { get; set; }

        /// <summary>
        /// SMS destination number configuration. If omitted, the message is sent to the customer number on the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AnyOfJsonConverter<global::RetellAI.SmsDestination2?, object>))]
        public global::RetellAI.AnyOf<global::RetellAI.SmsDestination2?, object>? SmsDestination { get; set; }

        /// <summary>
        /// Whether the agent should speak after the SMS tool finishes execution.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak_after_execution")]
        public bool? SpeakAfterExecution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendSMSTool" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state edges). Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </param>
        /// <param name="smsContent"></param>
        /// <param name="type"></param>
        /// <param name="description">
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </param>
        /// <param name="speakDuringExecution">
        /// If true, the agent will speak a short line before sending the SMS. If omitted, defaults to true (same as end_call / transfer_call tools).
        /// </param>
        /// <param name="executionMessageDescription">
        /// Describes what to say before sending the SMS. Only applicable when speak_during_execution is true.
        /// </param>
        /// <param name="executionMessageType">
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </param>
        /// <param name="smsSender">
        /// SMS sender number configuration. If omitted, the message is sent from the agent's phone number.
        /// </param>
        /// <param name="smsDestination">
        /// SMS destination number configuration. If omitted, the message is sent to the customer number on the call.
        /// </param>
        /// <param name="speakAfterExecution">
        /// Whether the agent should speak after the SMS tool finishes execution.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendSMSTool(
            string name,
            global::RetellAI.SmsContent smsContent,
            global::RetellAI.SendSMSToolType type,
            string? description,
            bool? speakDuringExecution,
            string? executionMessageDescription,
            global::RetellAI.SendSMSToolExecutionMessageType? executionMessageType,
            global::RetellAI.AnyOf<global::RetellAI.SmsSender2?, object>? smsSender,
            global::RetellAI.AnyOf<global::RetellAI.SmsDestination2?, object>? smsDestination,
            bool? speakAfterExecution)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description;
            this.SpeakDuringExecution = speakDuringExecution;
            this.ExecutionMessageDescription = executionMessageDescription;
            this.ExecutionMessageType = executionMessageType;
            this.SmsContent = smsContent;
            this.SmsSender = smsSender;
            this.SmsDestination = smsDestination;
            this.SpeakAfterExecution = speakAfterExecution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendSMSTool" /> class.
        /// </summary>
        public SendSMSTool()
        {
        }

    }
}