#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Stateless playground completion. Send the full conversation history (same shape as chat completion messages) and receive only the newly generated messages. Nothing is persisted server-side — the caller manages conversation state.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="version">
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). The string "latest" resolves to the most recently created version (the largest version number), and "latest_published" resolves to the most recently published version. When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version, latest, or latest_published is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AgentPlaygroundCompletionResponse> AgentPlaygroundCompletionAsync(
            string agentId,

            global::RetellAI.AgentPlaygroundCompletionRequest request,
            global::RetellAI.AgentVersionReference? version = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stateless playground completion. Send the full conversation history (same shape as chat completion messages) and receive only the newly generated messages. Nothing is persisted server-side — the caller manages conversation state.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="version">
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). The string "latest" resolves to the most recently created version (the largest version number), and "latest_published" resolves to the most recently published version. When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version, latest, or latest_published is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.AgentPlaygroundCompletionResponse>> AgentPlaygroundCompletionAsResponseAsync(
            string agentId,

            global::RetellAI.AgentPlaygroundCompletionRequest request,
            global::RetellAI.AgentVersionReference? version = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stateless playground completion. Send the full conversation history (same shape as chat completion messages) and receive only the newly generated messages. Nothing is persisted server-side — the caller manages conversation state.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="version">
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). The string "latest" resolves to the most recently created version (the largest version number), and "latest_published" resolves to the most recently published version. When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version, latest, or latest_published is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </param>
        /// <param name="messages">
        /// Full conversation history, same shape as chat completion messages. message_id and created_timestamp are optional — server generates them if omitted.<br/>
        /// Example: [{"role":"user","content":"Hi, I\u0027d like to check my appointment."}, {"role":"agent","content":"Sure! Could you please provide your name?"}, {"role":"user","content":"My name is John Smith."}]
        /// </param>
        /// <param name="dynamicVariables">
        /// Key-value pairs for dynamic variable substitution.<br/>
        /// Example: {"customer_name":"John Smith","customer_phone":"444-223-3564"}
        /// </param>
        /// <param name="toolMocks">
        /// Optional mock responses for tools. When provided, the agent uses these instead of executing real tool calls.
        /// </param>
        /// <param name="currentState">
        /// Current state name for retell-llm agents. Used to resume from a specific state.<br/>
        /// Example: greeting
        /// </param>
        /// <param name="currentNodeId">
        /// Current node id for conversation-flow agents. Used to resume from a specific node. Must be provided together with component_id when testing components.<br/>
        /// Example: start-node-abc123
        /// </param>
        /// <param name="componentId">
        /// Conversation flow component id. Required when current_node_id refers to a node within a component.<br/>
        /// Example: component_xyz789
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AgentPlaygroundCompletionResponse> AgentPlaygroundCompletionAsync(
            string agentId,
            global::System.Collections.Generic.IList<global::RetellAI.ChatMessageInput> messages,
            global::RetellAI.AgentVersionReference? version = default,
            global::System.Collections.Generic.Dictionary<string, string>? dynamicVariables = default,
            global::System.Collections.Generic.IList<global::RetellAI.ToolMock>? toolMocks = default,
            string? currentState = default,
            string? currentNodeId = default,
            string? componentId = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}