#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Manually refresh a knowledge base. Refreshes do not consume ingestion quota, including URLs discovered through auto-crawling paths. Refreshes the refreshable sources present when background processing begins.
        /// </summary>
        /// <param name="knowledgeBaseId">
        /// Example: knowledge_base_1234567890
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task RefreshKnowledgeBaseAsync(
            string knowledgeBaseId,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Manually refresh a knowledge base. Refreshes do not consume ingestion quota, including URLs discovered through auto-crawling paths. Refreshes the refreshable sources present when background processing begins.
        /// </summary>
        /// <param name="knowledgeBaseId">
        /// Example: knowledge_base_1234567890
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse> RefreshKnowledgeBaseAsResponseAsync(
            string knowledgeBaseId,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}