
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessageBaseCustomerDefinedMetadata
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_target_name")]
        public string? TransferTargetName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBaseCustomerDefinedMetadata" /> class.
        /// </summary>
        /// <param name="transferTargetName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageBaseCustomerDefinedMetadata(
            string? transferTargetName)
        {
            this.TransferTargetName = transferTargetName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBaseCustomerDefinedMetadata" /> class.
        /// </summary>
        public MessageBaseCustomerDefinedMetadata()
        {
        }

    }
}