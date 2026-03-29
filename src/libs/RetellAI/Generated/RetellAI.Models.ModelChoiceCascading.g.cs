
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelChoiceCascading
    {
        /// <summary>
        /// Type of model choice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ModelChoiceCascadingTypeJsonConverter))]
        public global::RetellAI.ModelChoiceCascadingType Type { get; set; }

        /// <summary>
        /// Available LLM models for agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.LLMModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.LLMModel Model { get; set; }

        /// <summary>
        /// Whether to use high priority pool with more dedicated resource, default false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_priority")]
        public bool? HighPriority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelChoiceCascading" /> class.
        /// </summary>
        /// <param name="model">
        /// Available LLM models for agents.
        /// </param>
        /// <param name="type">
        /// Type of model choice
        /// </param>
        /// <param name="highPriority">
        /// Whether to use high priority pool with more dedicated resource, default false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelChoiceCascading(
            global::RetellAI.LLMModel model,
            global::RetellAI.ModelChoiceCascadingType type,
            bool? highPriority)
        {
            this.Type = type;
            this.Model = model;
            this.HighPriority = highPriority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelChoiceCascading" /> class.
        /// </summary>
        public ModelChoiceCascading()
        {
        }
    }
}