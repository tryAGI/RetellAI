
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.NodeInstructionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.NodeInstruction Instruction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_edge")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SmsSuccessEdgeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.SmsSuccessEdge SuccessEdge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_edge")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SmsFailedEdgeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.SmsFailedEdge FailedEdge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsNodeVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="instruction"></param>
        /// <param name="successEdge"></param>
        /// <param name="failedEdge"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmsNodeVariant2(
            global::RetellAI.NodeInstruction instruction,
            global::RetellAI.SmsSuccessEdge successEdge,
            global::RetellAI.SmsFailedEdge failedEdge,
            global::RetellAI.SmsNodeVariant2Type type)
        {
            this.Instruction = instruction;
            this.SuccessEdge = successEdge;
            this.FailedEdge = failedEdge;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsNodeVariant2" /> class.
        /// </summary>
        public SmsNodeVariant2()
        {
        }
    }
}