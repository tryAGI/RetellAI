#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Get all versions of an agent
        /// </summary>
        /// <param name="agentId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="includeResponseEngine">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::RetellAI.AgentResponse>> GetAgentVersionsAsync(
            string agentId,
            bool? includeResponseEngine = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all versions of an agent
        /// </summary>
        /// <param name="agentId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="includeResponseEngine">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::RetellAI.AgentResponse>>> GetAgentVersionsAsResponseAsync(
            string agentId,
            bool? includeResponseEngine = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}