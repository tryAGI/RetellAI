
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormTextareaFieldVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConductorFormTextareaFieldVariant2KindJsonConverter))]
        public global::RetellAI.ConductorFormTextareaFieldVariant2Kind Kind { get; set; }

        /// <summary>
        /// Value the field starts with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_value")]
        public string? DefaultValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormTextareaFieldVariant2" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="defaultValue">
        /// Value the field starts with.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormTextareaFieldVariant2(
            global::RetellAI.ConductorFormTextareaFieldVariant2Kind kind,
            string? defaultValue)
        {
            this.Kind = kind;
            this.DefaultValue = defaultValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormTextareaFieldVariant2" /> class.
        /// </summary>
        public ConductorFormTextareaFieldVariant2()
        {
        }

    }
}