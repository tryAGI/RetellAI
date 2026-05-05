#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Delete an existing source from knowledge base
        /// </summary>
        /// <param name="knowledgeBaseId">
        /// Example: kb_1234567890
        /// </param>
        /// <param name="sourceId">
        /// Example: source_1234567890
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.KnowledgeBaseResponse> DeleteKnowledgeBaseSourceAsync(
            string knowledgeBaseId,
            string sourceId,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an existing source from knowledge base
        /// </summary>
        /// <param name="knowledgeBaseId">
        /// Example: kb_1234567890
        /// </param>
        /// <param name="sourceId">
        /// Example: source_1234567890
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.KnowledgeBaseResponse>> DeleteKnowledgeBaseSourceAsResponseAsync(
            string knowledgeBaseId,
            string sourceId,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}