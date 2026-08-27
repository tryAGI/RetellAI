
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorOverageConfigVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ConductorOverageConfigVariant1ModeJsonConverter))]
        public global::RetellAI.ConductorOverageConfigVariant1Mode Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorOverageConfigVariant1" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorOverageConfigVariant1(
            global::RetellAI.ConductorOverageConfigVariant1Mode mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorOverageConfigVariant1" /> class.
        /// </summary>
        public ConductorOverageConfigVariant1()
        {
        }

    }
}