
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class S2SModelConfig
    {
        /// <summary>
        /// Runs a speech-to-speech model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.S2SModelConfigTypeJsonConverter))]
        public global::RetellAI.S2SModelConfigType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        public global::RetellAI.S2SModelRef? Primary { get; set; }

        /// <summary>
        /// Randomness of the response, from 0 to 1. Defaults to 0; a lower value is recommended for tool calling.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="S2SModelConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Runs a speech-to-speech model.
        /// </param>
        /// <param name="primary"></param>
        /// <param name="temperature">
        /// Randomness of the response, from 0 to 1. Defaults to 0; a lower value is recommended for tool calling.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public S2SModelConfig(
            global::RetellAI.S2SModelConfigType? type,
            global::RetellAI.S2SModelRef? primary,
            double? temperature)
        {
            this.Type = type;
            this.Primary = primary;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="S2SModelConfig" /> class.
        /// </summary>
        public S2SModelConfig()
        {
        }

    }
}