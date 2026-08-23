#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Update the organization's CRM configuration. Omitted fields stay as they are; a field that is sent replaces its stored value in full.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.CRMConfig> UpdateCrmConfigAsync(

            global::RetellAI.UpdateCrmConfigRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the organization's CRM configuration. Omitted fields stay as they are; a field that is sent replaces its stored value in full.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.CRMConfig>> UpdateCrmConfigAsResponseAsync(

            global::RetellAI.UpdateCrmConfigRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the organization's CRM configuration. Omitted fields stay as they are; a field that is sent replaces its stored value in full.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.CRMConfig> UpdateCrmConfigAsync(
            string? appId = default,
            global::System.Collections.Generic.IList<global::RetellAI.CRMCustomFieldSchema>? customFields = default,
            global::System.Collections.Generic.IList<global::RetellAI.CRMAnalysisDataMapping>? crmAnalysisDataMappings = default,
            global::System.Collections.Generic.IList<string>? contactColumnsOrder = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}