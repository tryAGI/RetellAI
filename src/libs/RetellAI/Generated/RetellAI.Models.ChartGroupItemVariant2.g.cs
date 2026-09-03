
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChartGroupItemVariant2
    {
        /// <summary>
        /// `custom_analysis_data` groups by an analysis output; `custom_attribute` groups by a custom attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ChartGroupItemVariant2TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartGroupItemVariant2Type Type { get; set; }

        /// <summary>
        /// Exact custom field name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartGroupItemVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// `custom_analysis_data` groups by an analysis output; `custom_attribute` groups by a custom attribute.
        /// </param>
        /// <param name="field">
        /// Exact custom field name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartGroupItemVariant2(
            global::RetellAI.ChartGroupItemVariant2Type type,
            string field)
        {
            this.Type = type;
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartGroupItemVariant2" /> class.
        /// </summary>
        public ChartGroupItemVariant2()
        {
        }

    }
}