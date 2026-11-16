
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormSelectFieldVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConductorFormSelectFieldVariant2KindJsonConverter))]
        public global::RetellAI.ConductorFormSelectFieldVariant2Kind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.ConductorFormOption> Options { get; set; }

        /// <summary>
        /// Label of the option picked to start with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_value")]
        public string? DefaultValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormSelectFieldVariant2" /> class.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="kind"></param>
        /// <param name="defaultValue">
        /// Label of the option picked to start with.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormSelectFieldVariant2(
            global::System.Collections.Generic.IList<global::RetellAI.ConductorFormOption> options,
            global::RetellAI.ConductorFormSelectFieldVariant2Kind kind,
            string? defaultValue)
        {
            this.Kind = kind;
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.DefaultValue = defaultValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormSelectFieldVariant2" /> class.
        /// </summary>
        public ConductorFormSelectFieldVariant2()
        {
        }

    }
}