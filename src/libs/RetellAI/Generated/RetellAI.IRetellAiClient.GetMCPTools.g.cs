#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Get MCP tools for a specific agent
        /// </summary>
        /// <param name="agentId">
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="version">
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). The string "latest" resolves to the most recently created version (the largest version number), and "latest_published" resolves to the most recently published version. When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version, latest, or latest_published is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </param>
        /// <param name="mcpId">
        /// Example: mcp-server-1
        /// </param>
        /// <param name="componentId">
        /// Example: component-123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::RetellAI.MCPToolDefinition>> GetMCPToolsAsync(
            string agentId,
            string mcpId,
            global::RetellAI.AgentVersionReference? version = default,
            string? componentId = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get MCP tools for a specific agent
        /// </summary>
        /// <param name="agentId">
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="version">
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). The string "latest" resolves to the most recently created version (the largest version number), and "latest_published" resolves to the most recently published version. When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version, latest, or latest_published is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </param>
        /// <param name="mcpId">
        /// Example: mcp-server-1
        /// </param>
        /// <param name="componentId">
        /// Example: component-123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::RetellAI.MCPToolDefinition>>> GetMCPToolsAsResponseAsync(
            string agentId,
            string mcpId,
            global::RetellAI.AgentVersionReference? version = default,
            string? componentId = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}