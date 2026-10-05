
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OutputSelectionVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OutputSelectionVariant2ModeJsonConverter))]
        public global::RetellAI.OutputSelectionVariant2Mode Mode { get; set; }

        /// <summary>
        /// The only response fields the agent and the transcript see, as dot-paths into the response schema returned by get-app-tool-schema. Everything else is dropped. Selecting a parent keeps its whole subtree. A plain segment traverses arrays element-wise (deals.properties.amount keeps that field on every deal), while key[n] selects one element (deals[0].id keeps only the first deal's id); paths that match nothing contribute nothing.<br/>
        /// Example: [id, properties.email]
        /// </summary>
        /// <example>[id, properties.email]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputSelectionVariant2" /> class.
        /// </summary>
        /// <param name="fields">
        /// The only response fields the agent and the transcript see, as dot-paths into the response schema returned by get-app-tool-schema. Everything else is dropped. Selecting a parent keeps its whole subtree. A plain segment traverses arrays element-wise (deals.properties.amount keeps that field on every deal), while key[n] selects one element (deals[0].id keeps only the first deal's id); paths that match nothing contribute nothing.<br/>
        /// Example: [id, properties.email]
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputSelectionVariant2(
            global::System.Collections.Generic.IList<string> fields,
            global::RetellAI.OutputSelectionVariant2Mode mode)
        {
            this.Mode = mode;
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputSelectionVariant2" /> class.
        /// </summary>
        public OutputSelectionVariant2()
        {
        }

    }
}