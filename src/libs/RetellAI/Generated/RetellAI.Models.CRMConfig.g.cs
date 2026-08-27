
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CRMConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// The connected CRM integration app ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// Epoch milliseconds of the last successful sync.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_timestamp")]
        public double? LastSyncTimestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_fields")]
        public global::System.Collections.Generic.IList<global::RetellAI.CRMCustomFieldSchema>? CustomFields { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="CRMConfig" /> class.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="appId">
        /// The connected CRM integration app ID.
        /// </param>
        /// <param name="lastSyncTimestamp">
        /// Epoch milliseconds of the last successful sync.
        /// </param>
        /// <param name="customFields"></param>
        /// <param name="crmAnalysisDataMappings"></param>
        /// <param name="contactColumnsOrder">
        /// Preferred display order of contact fields, for clients that render contacts as a table. Not used by the API itself.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CRMConfig(
            string orgId,
            string? appId,
            double? lastSyncTimestamp,
            global::System.Collections.Generic.IList<global::RetellAI.CRMCustomFieldSchema>? customFields,
            global::System.Collections.Generic.IList<global::RetellAI.CRMAnalysisDataMapping>? crmAnalysisDataMappings,
            global::System.Collections.Generic.IList<string>? contactColumnsOrder)
        {
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.AppId = appId;
            this.LastSyncTimestamp = lastSyncTimestamp;
            this.CustomFields = customFields;
            this.CrmAnalysisDataMappings = crmAnalysisDataMappings;
            this.ContactColumnsOrder = contactColumnsOrder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CRMConfig" /> class.
        /// </summary>
        public CRMConfig()
        {
        }

    }
}