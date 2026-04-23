#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Stateless playground completion. Send the full conversation history (same shape as chat completion messages) and receive only the newly generated messages. Nothing is persisted server-side — the caller manages conversation state.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="version"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AgentPlaygroundCompletionResponse> AgentPlaygroundCompletionAsync(
            string agentId,

            global::RetellAI.AgentPlaygroundCompletionRequest request,
            int? version = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stateless playground completion. Send the full conversation history (same shape as chat completion messages) and receive only the newly generated messages. Nothing is persisted server-side — the caller manages conversation state.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="version"></param>
        /// <param name="messages">
        /// Full conversation history, same shape as chat completion messages. message_id and created_timestamp are optional — server generates them if omitted.
        /// </param>
        /// <param name="dynamicVariables">
        /// Key-value pairs for dynamic variable substitution.
        /// </param>
        /// <param name="toolMocks">
        /// Optional mock responses for tools. When provided, the agent uses these instead of executing real tool calls.
        /// </param>
        /// <param name="currentState">
        /// Current state name for retell-llm agents. Used to resume from a specific state.
        /// </param>
        /// <param name="currentNodeId">
        /// Current node id for conversation-flow agents. Used to resume from a specific node. Must be provided together with component_id when testing components.
        /// </param>
        /// <param name="componentId">
        /// Conversation flow component id. Required when current_node_id refers to a node within a component.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AgentPlaygroundCompletionResponse> AgentPlaygroundCompletionAsync(
            string agentId,
            global::System.Collections.Generic.IList<global::RetellAI.ChatMessageInput> messages,
            int? version = default,
            global::System.Collections.Generic.Dictionary<string, string>? dynamicVariables = default,
            global::System.Collections.Generic.IList<global::RetellAI.ToolMock>? toolMocks = default,
            string? currentState = default,
            string? currentNodeId = default,
            string? componentId = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}