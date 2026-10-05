#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Trigger a backfill job that re-applies analysis data mappings to contacts using historical call and SMS chat data. Only one backfill job can run per organization at a time. Select contact_memory to rewrite memory from matching ended phone calls and SMS chats in chronological order, one conversation at a time, with no conversation-count cap. Backfill starts with the contact's existing memory. Each rewrite builds on the previous result, and the final successful result is saved once per contact. When mapped analysis fields and contact_memory are selected together, they are saved together in one contact update. Memory rewrites use the currently stored contact fields.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.JobStatus> BackfillContactAnalysisDataAsync(

            global::RetellAI.BackfillContactAnalysisDataRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger a backfill job that re-applies analysis data mappings to contacts using historical call and SMS chat data. Only one backfill job can run per organization at a time. Select contact_memory to rewrite memory from matching ended phone calls and SMS chats in chronological order, one conversation at a time, with no conversation-count cap. Backfill starts with the contact's existing memory. Each rewrite builds on the previous result, and the final successful result is saved once per contact. When mapped analysis fields and contact_memory are selected together, they are saved together in one contact update. Memory rewrites use the currently stored contact fields.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.JobStatus>> BackfillContactAnalysisDataAsResponseAsync(

            global::RetellAI.BackfillContactAnalysisDataRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger a backfill job that re-applies analysis data mappings to contacts using historical call and SMS chat data. Only one backfill job can run per organization at a time. Select contact_memory to rewrite memory from matching ended phone calls and SMS chats in chronological order, one conversation at a time, with no conversation-count cap. Backfill starts with the contact's existing memory. Each rewrite builds on the previous result, and the final successful result is saved once per contact. When mapped analysis fields and contact_memory are selected together, they are saved together in one contact update. Memory rewrites use the currently stored contact fields.
        /// </summary>
        /// <param name="backfillCallFilter">
        /// Optional filter to scope which conversations are processed. Supports agent and start_timestamp from the standard call filter. The same filter applies to phone calls and SMS chats for both analysis data mappings and contact_memory.
        /// </param>
        /// <param name="backfillAttributes">
        /// Contact fields to recompute. Each one must still exist as a contact field and have an analysis data mapping configured, except for the built-in contact_memory attribute, which requires no mapping and supports requests on its own or alongside mapped fields. Memory backfill skips conversations without retained transcripts.<br/>
        /// Example: [contact_memory]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.JobStatus> BackfillContactAnalysisDataAsync(
            global::System.Collections.Generic.IList<string> backfillAttributes,
            global::RetellAI.BackfillContactAnalysisDataRequestBackfillCallFilter? backfillCallFilter = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}