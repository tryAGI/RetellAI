
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateCrmConfigRequest
    {
        /// <summary>
        /// ID of the CRM app to link. Pass null to unlink, which stops syncing. Changing it resets the sync cursor, so the next sync re-reads every contact from the new CRM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// Replaces the stored list. Names must be snake_case and cannot collide with a built-in contact field or start with `contact`/`external`. Removing a field that an analysis data mapping still targets is rejected — send crm_analysis_data_mappings in the same request to retarget or drop those mappings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_fields")]
        public global::System.Collections.Generic.IList<global::RetellAI.CRMCustomFieldSchema>? CustomFields { get; set; }

        /// <summary>
        /// Replaces the stored list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crm_analysis_data_mappings")]
        public global::System.Collections.Generic.IList<global::RetellAI.CRMAnalysisDataMapping>? CrmAnalysisDataMappings { get; set; }

        /// <summary>
        /// Preferred display order of contact fields, for clients that render contacts as a table. Not used by the API itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_columns_order")]
        public global::System.Collections.Generic.IList<string>? ContactColumnsOrder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCrmConfigRequest" /> class.
        /// </summary>
        /// <param name="appId">
        /// ID of the CRM app to link. Pass null to unlink, which stops syncing. Changing it resets the sync cursor, so the next sync re-reads every contact from the new CRM.
        /// </param>
        /// <param name="customFields">
        /// Replaces the stored list. Names must be snake_case and cannot collide with a built-in contact field or start with `contact`/`external`. Removing a field that an analysis data mapping still targets is rejected — send crm_analysis_data_mappings in the same request to retarget or drop those mappings.
        /// </param>
        /// <param name="crmAnalysisDataMappings">
        /// Replaces the stored list.
        /// </param>
        /// <param name="contactColumnsOrder">
        /// Preferred display order of contact fields, for clients that render contacts as a table. Not used by the API itself.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCrmConfigRequest(
            string? appId,
            global::System.Collections.Generic.IList<global::RetellAI.CRMCustomFieldSchema>? customFields,
            global::System.Collections.Generic.IList<global::RetellAI.CRMAnalysisDataMapping>? crmAnalysisDataMappings,
            global::System.Collections.Generic.IList<string>? contactColumnsOrder)
        {
            this.AppId = appId;
            this.CustomFields = customFields;
            this.CrmAnalysisDataMappings = crmAnalysisDataMappings;
            this.ContactColumnsOrder = contactColumnsOrder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCrmConfigRequest" /> class.
        /// </summary>
        public UpdateCrmConfigRequest()
        {
        }

    }
}