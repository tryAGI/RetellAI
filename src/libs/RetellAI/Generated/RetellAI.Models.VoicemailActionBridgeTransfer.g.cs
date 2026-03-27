
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicemailActionBridgeTransfer
    {
        /// <summary>
        /// Example: bridge_transfer
        /// </summary>
        /// <example>bridge_transfer</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.VoicemailActionBridgeTransferTypeJsonConverter))]
        public global::RetellAI.VoicemailActionBridgeTransferType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailActionBridgeTransfer" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: bridge_transfer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicemailActionBridgeTransfer(
            global::RetellAI.VoicemailActionBridgeTransferType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailActionBridgeTransfer" /> class.
        /// </summary>
        public VoicemailActionBridgeTransfer()
        {
        }
    }
}