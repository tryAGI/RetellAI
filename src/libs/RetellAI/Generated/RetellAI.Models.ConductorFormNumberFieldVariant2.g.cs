
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormNumberFieldVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConductorFormNumberFieldVariant2KindJsonConverter))]
        public global::RetellAI.ConductorFormNumberFieldVariant2Kind Kind { get; set; }

        /// <summary>
        /// Smallest allowed value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        /// Largest allowed value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// When true, only whole numbers are allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integer")]
        public bool? Integer { get; set; }

        /// <summary>
        /// Value the field starts with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_value")]
        public double? DefaultValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormNumberFieldVariant2" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="min">
        /// Smallest allowed value.
        /// </param>
        /// <param name="max">
        /// Largest allowed value.
        /// </param>
        /// <param name="integer">
        /// When true, only whole numbers are allowed.
        /// </param>
        /// <param name="defaultValue">
        /// Value the field starts with.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormNumberFieldVariant2(
            global::RetellAI.ConductorFormNumberFieldVariant2Kind kind,
            double? min,
            double? max,
            bool? integer,
            double? defaultValue)
        {
            this.Kind = kind;
            this.Min = min;
            this.Max = max;
            this.Integer = integer;
            this.DefaultValue = defaultValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormNumberFieldVariant2" /> class.
        /// </summary>
        public ConductorFormNumberFieldVariant2()
        {
        }

    }
}