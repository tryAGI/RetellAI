
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormTimeFieldVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConductorFormTimeFieldVariant2KindJsonConverter))]
        public global::RetellAI.ConductorFormTimeFieldVariant2Kind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_value")]
        public global::RetellAI.ConductorFormTimeValue? DefaultValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormTimeFieldVariant2" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="defaultValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormTimeFieldVariant2(
            global::RetellAI.ConductorFormTimeFieldVariant2Kind kind,
            global::RetellAI.ConductorFormTimeValue? defaultValue)
        {
            this.Kind = kind;
            this.DefaultValue = defaultValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormTimeFieldVariant2" /> class.
        /// </summary>
        public ConductorFormTimeFieldVariant2()
        {
        }

    }
}