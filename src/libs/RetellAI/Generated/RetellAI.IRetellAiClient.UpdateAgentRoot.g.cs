#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Change settings that apply to all versions of an agent, such as its environment tags.
        /// </summary>
        /// <param name="agentId">
        /// Example: agent_xxx
        /// </param>
        /// <param name="ifMatch">
        /// Example: "1744761835123"
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AgentRootResponse> UpdateAgentRootAsync(
            string agentId,

            global::RetellAI.UpdateAgentRootRequest request,
            string? ifMatch = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change settings that apply to all versions of an agent, such as its environment tags.
        /// </summary>
        /// <param name="agentId">
        /// Example: agent_xxx
        /// </param>
        /// <param name="ifMatch">
        /// Example: "1744761835123"
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.AgentRootResponse>> UpdateAgentRootAsResponseAsync(
            string agentId,

            global::RetellAI.UpdateAgentRootRequest request,
            string? ifMatch = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change settings that apply to all versions of an agent, such as its environment tags.
        /// </summary>
        /// <param name="agentId">
        /// Example: agent_xxx
        /// </param>
        /// <param name="ifMatch">
        /// Example: "1744761835123"
        /// </param>
        /// <param name="tags">
        /// Environment tags to add, change, or delete, keyed by tag name. Set a tag to an object to add or change it, or to null to delete it. Tags you leave out stay as they are. The prod and staging tags cannot be deleted. An agent can have up to 10 tags. Tag names must be 1-20 characters, start with a lowercase letter, use only lowercase letters, digits, underscores, or hyphens, and cannot be "latest", "latest_published", or "v" followed only by digits, such as "v2".<br/>
        /// Example: {"prod":{"version":3}}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AgentRootResponse> UpdateAgentRootAsync(
            string agentId,
            string? ifMatch = default,
            global::RetellAI.UpdateAgentRootRequestTags? tags = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}