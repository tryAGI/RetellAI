
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NumberAnalysisData
    {
        /// <summary>
        /// Type of the variable to extract.<br/>
        /// Example: number
        /// </summary>
        /// <example>number</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.NumberAnalysisDataTypeJsonConverter))]
        public global::RetellAI.NumberAnalysisDataType Type { get; set; }

        /// <summary>
        /// Name of the variable.<br/>
        /// Example: order_count
        /// </summary>
        /// <example>order_count</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the variable.<br/>
        /// Example: How many the customer intend to order.
        /// </summary>
        /// <example>How many the customer intend to order.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Whether this data is required. If true and the data is not extracted, the call will be marked as unsuccessful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Optional instruction to help decide whether this field needs to be populated in the analysis. If not set, the field is always included. If required is true, this is ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditional_prompt")]
        public string? ConditionalPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberAnalysisData" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the variable.<br/>
        /// Example: order_count
        /// </param>
        /// <param name="description">
        /// Description of the variable.<br/>
        /// Example: How many the customer intend to order.
        /// </param>
        /// <param name="type">
        /// Type of the variable to extract.<br/>
        /// Example: number
        /// </param>
        /// <param name="required">
        /// Whether this data is required. If true and the data is not extracted, the call will be marked as unsuccessful.
        /// </param>
        /// <param name="conditionalPrompt">
        /// Optional instruction to help decide whether this field needs to be populated in the analysis. If not set, the field is always included. If required is true, this is ignored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NumberAnalysisData(
            string name,
            string description,
            global::RetellAI.NumberAnalysisDataType type,
            bool? required,
            string? conditionalPrompt)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Required = required;
            this.ConditionalPrompt = conditionalPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberAnalysisData" /> class.
        /// </summary>
        public NumberAnalysisData()
        {
        }
    }
}