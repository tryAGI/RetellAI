
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OutputSelectionVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OutputSelectionVariant1ModeJsonConverter))]
        public global::RetellAI.OutputSelectionVariant1Mode Mode { get; set; }

        /// <summary>
        /// Not used at runtime; stored and returned as-is for the UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<string>? Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputSelectionVariant1" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="fields">
        /// Not used at runtime; stored and returned as-is for the UI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputSelectionVariant1(
            global::RetellAI.OutputSelectionVariant1Mode mode,
            global::System.Collections.Generic.IList<string>? fields)
        {
            this.Mode = mode;
            this.Fields = fields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputSelectionVariant1" /> class.
        /// </summary>
        public OutputSelectionVariant1()
        {
        }

    }
}