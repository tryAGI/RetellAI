
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelChoiceS2S
    {
        /// <summary>
        /// Type of model choice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ModelChoiceS2STypeJsonConverter))]
        public global::RetellAI.ModelChoiceS2SType Type { get; set; }

        /// <summary>
        /// The speech-to-speech model to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.S2SModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.S2SModel Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelChoiceS2S" /> class.
        /// </summary>
        /// <param name="model">
        /// The speech-to-speech model to use
        /// </param>
        /// <param name="type">
        /// Type of model choice
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelChoiceS2S(
            global::RetellAI.S2SModel model,
            global::RetellAI.ModelChoiceS2SType type)
        {
            this.Type = type;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelChoiceS2S" /> class.
        /// </summary>
        public ModelChoiceS2S()
        {
        }

    }
}