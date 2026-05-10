
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmsContentTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SmsContentTemplateTypeJsonConverter))]
        public global::RetellAI.SmsContentTemplateType Type { get; set; }

        /// <summary>
        /// The template to use for the SMS content. "info_collection" sends a predefined message requesting information from the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.SmsContentTemplateTemplateJsonConverter))]
        public global::RetellAI.SmsContentTemplateTemplate Template { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsContentTemplate" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="template">
        /// The template to use for the SMS content. "info_collection" sends a predefined message requesting information from the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmsContentTemplate(
            global::RetellAI.SmsContentTemplateType type,
            global::RetellAI.SmsContentTemplateTemplate template)
        {
            this.Type = type;
            this.Template = template;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsContentTemplate" /> class.
        /// </summary>
        public SmsContentTemplate()
        {
        }

    }
}