
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmsInstructionTemplate
    {
        /// <summary>
        /// Type of instruction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTypeJsonConverter))]
        public global::RetellAI.SmsInstructionTemplateType Type { get; set; }

        /// <summary>
        /// The template to use for the instruction. "info_collection" sends a predefined message requesting information from the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SmsInstructionTemplateTemplateJsonConverter))]
        public global::RetellAI.SmsInstructionTemplateTemplate Template { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsInstructionTemplate" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of instruction
        /// </param>
        /// <param name="template">
        /// The template to use for the instruction. "info_collection" sends a predefined message requesting information from the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmsInstructionTemplate(
            global::RetellAI.SmsInstructionTemplateType type,
            global::RetellAI.SmsInstructionTemplateTemplate template)
        {
            this.Type = type;
            this.Template = template;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsInstructionTemplate" /> class.
        /// </summary>
        public SmsInstructionTemplate()
        {
        }

    }
}