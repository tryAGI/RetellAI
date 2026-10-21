
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class S2SModelRef
    {
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
        /// Initializes a new instance of the <see cref="S2SModelRef" /> class.
        /// </summary>
        /// <param name="model">
        /// The speech-to-speech model to use
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public S2SModelRef(
            global::RetellAI.S2SModel model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="S2SModelRef" /> class.
        /// </summary>
        public S2SModelRef()
        {
        }

    }
}