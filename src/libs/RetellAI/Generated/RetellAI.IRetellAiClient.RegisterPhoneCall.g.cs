#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Register a new phone call for custom telephony
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.V2PhoneCallResponse> RegisterPhoneCallAsync(

            global::RetellAI.RegisterPhoneCallRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a new phone call for custom telephony
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.V2PhoneCallResponse>> RegisterPhoneCallAsResponseAsync(

            global::RetellAI.RegisterPhoneCallRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a new phone call for custom telephony
        /// </summary>
        /// <param name="agentId">
        /// The agent to use for the call.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="agentVersion">
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). The string "latest" resolves to the most recently created version (the largest version number), and "latest_published" resolves to the most recently published version. When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version, latest, or latest_published is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </param>
        /// <param name="agentOverride">
        /// Override configuration for agent, retell LLM, or conversation flow settings for a specific call.
        /// </param>
        /// <param name="fromNumber">
        /// The number you own in E.164 format. Stored for tracking purpose.<br/>
        /// Example: +14157774444
        /// </param>
        /// <param name="toNumber">
        /// The number you want to call, in E.164 format. Stored for tracking purpose.<br/>
        /// Example: +12137774445
        /// </param>
        /// <param name="direction">
        /// Direction of the phone call. Stored for tracking purpose.<br/>
        /// Example: inbound
        /// </param>
        /// <param name="metadata">
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the call. Not used for processing. You can later get this field from the call object.
        /// </param>
        /// <param name="retellLlmDynamicVariables">
        /// Add optional dynamic variables in key value pairs of string that injects into your Response Engine prompt and tool description. Only applicable for Response Engine.<br/>
        /// Example: {"customer_name":"John Doe"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.V2PhoneCallResponse> RegisterPhoneCallAsync(
            string agentId,
            global::RetellAI.AgentVersionReference? agentVersion = default,
            global::RetellAI.AgentOverrideRequest? agentOverride = default,
            string? fromNumber = default,
            string? toNumber = default,
            global::RetellAI.RegisterPhoneCallRequestDirection? direction = default,
            object? metadata = default,
            global::System.Collections.Generic.Dictionary<string, string>? retellLlmDynamicVariables = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}