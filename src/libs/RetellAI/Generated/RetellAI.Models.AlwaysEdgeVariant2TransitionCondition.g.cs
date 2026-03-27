
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlwaysEdgeVariant2TransitionCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AlwaysEdgeVariant2TransitionConditionTypeJsonConverter))]
        public global::RetellAI.AlwaysEdgeVariant2TransitionConditionType Type { get; set; }

        /// <summary>
        /// Must be "Always" for always edge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AlwaysEdgeVariant2TransitionConditionPromptJsonConverter))]
        public global::RetellAI.AlwaysEdgeVariant2TransitionConditionPrompt Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlwaysEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="prompt">
        /// Must be "Always" for always edge
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlwaysEdgeVariant2TransitionCondition(
            global::RetellAI.AlwaysEdgeVariant2TransitionConditionType type,
            global::RetellAI.AlwaysEdgeVariant2TransitionConditionPrompt prompt)
        {
            this.Type = type;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlwaysEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        public AlwaysEdgeVariant2TransitionCondition()
        {
        }
    }
}