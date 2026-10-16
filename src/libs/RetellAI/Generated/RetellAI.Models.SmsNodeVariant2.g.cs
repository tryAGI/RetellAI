
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SmsNodeVariant2
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SmsNodeVariant2TypeJsonConverter))]
        public global::RetellAI.SmsNodeVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NodeInstruction?, global::RetellAI.SmsInstructionTemplate>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.OneOf<global::RetellAI.NodeInstruction?, global::RetellAI.SmsInstructionTemplate> Instruction { get; set; }

        /// <summary>
        /// Transition followed by an SMS node after the send operation reports success.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_edge")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SmsSuccessEdgeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.SmsSuccessEdge SuccessEdge { get; set; }

        /// <summary>
        /// Transition followed by an SMS node when generating the message content or sending the message fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_edge")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SmsFailedEdgeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.SmsFailedEdge FailedEdge { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsNodeVariant2" /> class.
        /// </summary>
        /// <param name="instruction"></param>
        /// <param name="successEdge">
        /// Transition followed by an SMS node after the send operation reports success.
        /// </param>
        /// <param name="failedEdge">
        /// Transition followed by an SMS node when generating the message content or sending the message fails.
        /// </param>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="smsSender">
        /// SMS sender number configuration. If omitted, the message is sent from the agent's phone number.
        /// </param>
        /// <param name="smsDestination">
        /// SMS destination number configuration. If omitted, the message is sent to the customer number on the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmsNodeVariant2(
            global::RetellAI.OneOf<global::RetellAI.NodeInstruction?, global::RetellAI.SmsInstructionTemplate> instruction,
            global::RetellAI.SmsSuccessEdge successEdge,
            global::RetellAI.SmsFailedEdge failedEdge,
            global::RetellAI.SmsNodeVariant2Type type,
            global::RetellAI.AnyOf<global::RetellAI.SmsSender2?, object>? smsSender,
            global::RetellAI.AnyOf<global::RetellAI.SmsDestination2?, object>? smsDestination)
        {
            this.Type = type;
            this.Instruction = instruction;
            this.SuccessEdge = successEdge;
            this.FailedEdge = failedEdge;
            this.SmsSender = smsSender;
            this.SmsDestination = smsDestination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsNodeVariant2" /> class.
        /// </summary>
        public SmsNodeVariant2()
        {
        }

    }
}