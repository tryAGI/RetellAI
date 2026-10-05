
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EndNodeVariant2
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.EndNodeVariant2TypeJsonConverter))]
        public global::RetellAI.EndNodeVariant2Type Type { get; set; }

        /// <summary>
        /// Custom SIP headers sent on the outgoing BYE when ending the call. Header names must start with X- or x-. Supports dynamic variables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_sip_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomSipHeaders { get; set; }

        /// <summary>
        /// If true, will speak during execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.NodeInstructionJsonConverter))]
        public global::RetellAI.NodeInstruction? Instruction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndNodeVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="customSipHeaders">
        /// Custom SIP headers sent on the outgoing BYE when ending the call. Header names must start with X- or x-. Supports dynamic variables.
        /// </param>
        /// <param name="speakDuringExecution">
        /// If true, will speak during execution
        /// </param>
        /// <param name="instruction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndNodeVariant2(
            global::RetellAI.EndNodeVariant2Type type,
            global::System.Collections.Generic.Dictionary<string, string>? customSipHeaders,
            bool? speakDuringExecution,
            global::RetellAI.NodeInstruction? instruction)
        {
            this.Type = type;
            this.CustomSipHeaders = customSipHeaders;
            this.SpeakDuringExecution = speakDuringExecution;
            this.Instruction = instruction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndNodeVariant2" /> class.
        /// </summary>
        public EndNodeVariant2()
        {
        }

    }
}