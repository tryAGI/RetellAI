
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormChoiceFieldVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConductorFormChoiceFieldVariant2KindJsonConverter))]
        public global::RetellAI.ConductorFormChoiceFieldVariant2Kind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.ConductorFormOption> Options { get; set; }

        /// <summary>
        /// When true, the user can pick several options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_select")]
        public bool? MultiSelect { get; set; }

        /// <summary>
        /// Adds an "Other" option the user types into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allows_custom_answer")]
        public bool? AllowsCustomAnswer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_value")]
        public global::RetellAI.ConductorFormChoiceFieldVariant2DefaultValue? DefaultValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormChoiceFieldVariant2" /> class.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="kind"></param>
        /// <param name="multiSelect">
        /// When true, the user can pick several options.
        /// </param>
        /// <param name="allowsCustomAnswer">
        /// Adds an "Other" option the user types into.
        /// </param>
        /// <param name="defaultValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormChoiceFieldVariant2(
            global::System.Collections.Generic.IList<global::RetellAI.ConductorFormOption> options,
            global::RetellAI.ConductorFormChoiceFieldVariant2Kind kind,
            bool? multiSelect,
            bool? allowsCustomAnswer,
            global::RetellAI.ConductorFormChoiceFieldVariant2DefaultValue? defaultValue)
        {
            this.Kind = kind;
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.MultiSelect = multiSelect;
            this.AllowsCustomAnswer = allowsCustomAnswer;
            this.DefaultValue = defaultValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormChoiceFieldVariant2" /> class.
        /// </summary>
        public ConductorFormChoiceFieldVariant2()
        {
        }

    }
}