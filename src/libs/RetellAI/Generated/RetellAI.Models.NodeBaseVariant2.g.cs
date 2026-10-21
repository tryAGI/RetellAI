
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NodeBaseVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.NullableNodeModelConfigJsonConverter))]
        public global::RetellAI.NullableNodeModelConfig? ModelConfig { get; set; }

        /// <summary>
        /// Deprecated, use model_config. When a request sends both and they differ, the one that differs from the stored node is used, and model_config wins if both changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_choice")]
        public global::RetellAI.ModelChoiceCascading? ModelChoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeBaseVariant2" /> class.
        /// </summary>
        /// <param name="modelConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeBaseVariant2(
            global::RetellAI.NullableNodeModelConfig? modelConfig)
        {
            this.ModelConfig = modelConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeBaseVariant2" /> class.
        /// </summary>
        public NodeBaseVariant2()
        {
        }

    }
}