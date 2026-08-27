
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Filter by chat status.
    /// </summary>
    public sealed partial class ChatFilterChatStatus
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::System.Collections.Generic.IList<global::RetellAI.ChatFilterChatStatusValueItem>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFilterChatStatus" /> class.
        /// </summary>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatFilterChatStatus(
            global::System.Collections.Generic.IList<global::RetellAI.ChatFilterChatStatusValueItem>? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFilterChatStatus" /> class.
        /// </summary>
        public ChatFilterChatStatus()
        {
        }

    }
}