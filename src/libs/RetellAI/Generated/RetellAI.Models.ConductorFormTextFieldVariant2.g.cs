
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormTextFieldVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConductorFormTextFieldVariant2KindJsonConverter))]
        public global::RetellAI.ConductorFormTextFieldVariant2Kind Kind { get; set; }

        /// <summary>
        /// Checks that the answer is a valid email or URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConductorFormTextFieldVariant2FormatJsonConverter))]
        public global::RetellAI.ConductorFormTextFieldVariant2Format? Format { get; set; }

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
        /// Initializes a new instance of the <see cref="ConductorFormTextFieldVariant2" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="format">
        /// Checks that the answer is a valid email or URL.
        /// </param>
        /// <param name="defaultValue">
        /// Value the field starts with.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormTextFieldVariant2(
            global::RetellAI.ConductorFormTextFieldVariant2Kind kind,
            global::RetellAI.ConductorFormTextFieldVariant2Format? format,
            string? defaultValue)
        {
            this.Kind = kind;
            this.Format = format;
            this.DefaultValue = defaultValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormTextFieldVariant2" /> class.
        /// </summary>
        public ConductorFormTextFieldVariant2()
        {
        }

    }
}