#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Rerun post-call analysis for a specific call. This operation incurs charges.
        /// </summary>
        /// <param name="callId">
        /// Example: call_119c3f8e47135a29e65947eeb34cf12d
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.V2CallResponse> RerunCallAnalysisAsync(
            string callId,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rerun post-call analysis for a specific call. This operation incurs charges.
        /// </summary>
        /// <param name="callId">
        /// Example: call_119c3f8e47135a29e65947eeb34cf12d
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.V2CallResponse>> RerunCallAnalysisAsResponseAsync(
            string callId,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}