#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Publish an existing draft version in place.
        /// </summary>
        /// <param name="agentId">
        /// Example: agent_xxx
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task PublishAgentVersionAsync(
            string agentId,

            global::RetellAI.PublishAgentVersionRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish an existing draft version in place.
        /// </summary>
        /// <param name="agentId">
        /// Example: agent_xxx
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse> PublishAgentVersionAsResponseAsync(
            string agentId,

            global::RetellAI.PublishAgentVersionRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish an existing draft version in place.
        /// </summary>
        /// <param name="agentId">
        /// Example: agent_xxx
        /// </param>
        /// <param name="version">
        /// Example: 15
        /// </param>
        /// <param name="versionDescription">
        /// Example: Hotfix for transfer timeout
        /// </param>
        /// <param name="versionTitle">
        /// Optional title of the agent version. Used for your own reference.<br/>
        /// Example: Hotfix
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PublishAgentVersionAsync(
            string agentId,
            int version,
            string? versionDescription = default,
            string? versionTitle = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}