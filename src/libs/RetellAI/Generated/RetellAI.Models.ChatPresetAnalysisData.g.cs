
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// System preset for post-chat analysis (chat agents). Use in post_chat_analysis_data to override prompts or mark fields optional.
    /// </summary>
    public sealed partial class ChatPresetAnalysisData
    {
        /// <summary>
        /// Identifies this item as a system preset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataTypeJsonConverter))]
        public global::RetellAI.ChatPresetAnalysisDataType Type { get; set; }

        /// <summary>
        /// Preset identifier for chat agent analysis.<br/>
        /// Example: chat_summary
        /// </summary>
        /// <example>chat_summary</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChatPresetAnalysisDataNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChatPresetAnalysisDataName Name { get; set; }

        /// <summary>
        /// Prompt or description for this preset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// If false, this field is optional in the analysis. If true or unset, the field is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Optional instruction to help decide whether this field needs to be populated. If not set, the field is always included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditional_prompt")]
        public string? ConditionalPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatPresetAnalysisData" /> class.
        /// </summary>
        /// <param name="name">
        /// Preset identifier for chat agent analysis.<br/>
        /// Example: chat_summary
        /// </param>
        /// <param name="type">
        /// Identifies this item as a system preset.
        /// </param>
        /// <param name="description">
        /// Prompt or description for this preset.
        /// </param>
        /// <param name="required">
        /// If false, this field is optional in the analysis. If true or unset, the field is required.
        /// </param>
        /// <param name="conditionalPrompt">
        /// Optional instruction to help decide whether this field needs to be populated. If not set, the field is always included.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatPresetAnalysisData(
            global::RetellAI.ChatPresetAnalysisDataName name,
            global::RetellAI.ChatPresetAnalysisDataType type,
            string? description,
            bool? required,
            string? conditionalPrompt)
        {
            this.Type = type;
            this.Name = name;
            this.Description = description;
            this.Required = required;
            this.ConditionalPrompt = conditionalPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatPresetAnalysisData" /> class.
        /// </summary>
        public ChatPresetAnalysisData()
        {
        }
    }
}