#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// List test case definitions for a response engine
        /// </summary>
        /// <param name="type"></param>
        /// <param name="llmId"></param>
        /// <param name="conversationFlowId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::RetellAI.TestCaseDefinition>> ListTestCaseDefinitionsAsync(
            global::RetellAI.ListTestCaseDefinitionsType type,
            string? llmId = default,
            string? conversationFlowId = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List test case definitions for a response engine
        /// </summary>
        /// <param name="type"></param>
        /// <param name="llmId"></param>
        /// <param name="conversationFlowId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::RetellAI.TestCaseDefinition>>> ListTestCaseDefinitionsAsResponseAsync(
            global::RetellAI.ListTestCaseDefinitionsType type,
            string? llmId = default,
            string? conversationFlowId = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}