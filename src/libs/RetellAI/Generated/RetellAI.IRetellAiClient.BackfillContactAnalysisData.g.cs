#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Trigger a backfill job that re-applies analysis data mappings to contacts using historical call data. Only one backfill job can run per organization at a time.
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
        /// Trigger a backfill job that re-applies analysis data mappings to contacts using historical call data. Only one backfill job can run per organization at a time.
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
        /// Trigger a backfill job that re-applies analysis data mappings to contacts using historical call data. Only one backfill job can run per organization at a time.
        /// </summary>
        /// <param name="backfillCallFilter">
        /// Optional call filter to scope which calls are processed. Supports agent and start_timestamp from the standard call filter.
        /// </param>
        /// <param name="backfillAttributes">
        /// Contact fields to recompute. Each one must still exist as a contact field and have an analysis data mapping configured, otherwise the request is rejected rather than running a job that writes nothing.
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