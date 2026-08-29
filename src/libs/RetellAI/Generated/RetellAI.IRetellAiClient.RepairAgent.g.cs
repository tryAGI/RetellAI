#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Remove references to resources that no longer exist in your workspace from an agent draft version and its response engine — tools whose app connection has been deleted, unknown knowledge bases, and deleted shared components — and remap voices that are no longer accessible to a default voice. If the agent's response engine version has been published, the engine is left untouched and only agent-level references are repaired. Repairing an agent with nothing to fix is a no-op.
        /// </summary>
        /// <param name="agentId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="version">
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). The string "latest" resolves to the most recently created version (the largest version number), and "latest_published" resolves to the most recently published version. When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version, latest, or latest_published is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.OneOf<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>> RepairAgentAsync(
            string agentId,
            global::RetellAI.AgentVersionReference? version = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove references to resources that no longer exist in your workspace from an agent draft version and its response engine — tools whose app connection has been deleted, unknown knowledge bases, and deleted shared components — and remap voices that are no longer accessible to a default voice. If the agent's response engine version has been published, the engine is left untouched and only agent-level references are repaired. Repairing an agent with nothing to fix is a no-op.
        /// </summary>
        /// <param name="agentId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="version">
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). The string "latest" resolves to the most recently created version (the largest version number), and "latest_published" resolves to the most recently published version. When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version, latest, or latest_published is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.OneOf<global::RetellAI.AgentResponse?, global::RetellAI.ChatAgentResponse?>>> RepairAgentAsResponseAsync(
            string agentId,
            global::RetellAI.AgentVersionReference? version = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}