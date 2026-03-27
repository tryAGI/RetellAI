
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeInstructionPrompt
    {
        /// <summary>
        /// Type of instruction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.NodeInstructionPromptTypeJsonConverter))]
        public global::RetellAI.NodeInstructionPromptType Type { get; set; }

        /// <summary>
        /// The prompt text for the instruction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInstructionPrompt" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of instruction
        /// </param>
        /// <param name="text">
        /// The prompt text for the instruction
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeInstructionPrompt(
            string text,
            global::RetellAI.NodeInstructionPromptType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInstructionPrompt" /> class.
        /// </summary>
        public NodeInstructionPrompt()
        {
        }
    }
}