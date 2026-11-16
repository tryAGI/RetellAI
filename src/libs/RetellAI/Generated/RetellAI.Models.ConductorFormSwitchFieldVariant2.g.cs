
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormSwitchFieldVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConductorFormSwitchFieldVariant2KindJsonConverter))]
        public global::RetellAI.ConductorFormSwitchFieldVariant2Kind Kind { get; set; }

        /// <summary>
        /// Starting position of the switch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DefaultValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormSwitchFieldVariant2" /> class.
        /// </summary>
        /// <param name="defaultValue">
        /// Starting position of the switch.
        /// </param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormSwitchFieldVariant2(
            bool defaultValue,
            global::RetellAI.ConductorFormSwitchFieldVariant2Kind kind)
        {
            this.Kind = kind;
            this.DefaultValue = defaultValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormSwitchFieldVariant2" /> class.
        /// </summary>
        public ConductorFormSwitchFieldVariant2()
        {
        }

    }
}