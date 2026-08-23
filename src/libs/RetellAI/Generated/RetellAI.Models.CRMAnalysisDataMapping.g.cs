
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CRMAnalysisDataMapping
    {
        /// <summary>
        /// Contact field to write to. Must be an existing built-in or custom contact field, and cannot be phone_number, which identifies the contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FieldName { get; set; }

        /// <summary>
        /// Name of the post-call analysis field to read the value from. A value that does not match the contact field's type is skipped rather than failing the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_data_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AnalysisDataName { get; set; }

        /// <summary>
        /// How to reconcile the new value with what the contact already holds. `overwrite` always replaces it, `fill_if_empty` writes only when the field is empty, and `merge` combines the existing text with the new value. `merge` is available on string fields only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CRMAnalysisDataMappingUpdateModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.CRMAnalysisDataMappingUpdateMode UpdateMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CRMAnalysisDataMapping" /> class.
        /// </summary>
        /// <param name="fieldName">
        /// Contact field to write to. Must be an existing built-in or custom contact field, and cannot be phone_number, which identifies the contact.
        /// </param>
        /// <param name="analysisDataName">
        /// Name of the post-call analysis field to read the value from. A value that does not match the contact field's type is skipped rather than failing the conversation.
        /// </param>
        /// <param name="updateMode">
        /// How to reconcile the new value with what the contact already holds. `overwrite` always replaces it, `fill_if_empty` writes only when the field is empty, and `merge` combines the existing text with the new value. `merge` is available on string fields only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CRMAnalysisDataMapping(
            string fieldName,
            string analysisDataName,
            global::RetellAI.CRMAnalysisDataMappingUpdateMode updateMode)
        {
            this.FieldName = fieldName ?? throw new global::System.ArgumentNullException(nameof(fieldName));
            this.AnalysisDataName = analysisDataName ?? throw new global::System.ArgumentNullException(nameof(analysisDataName));
            this.UpdateMode = updateMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CRMAnalysisDataMapping" /> class.
        /// </summary>
        public CRMAnalysisDataMapping()
        {
        }

    }
}