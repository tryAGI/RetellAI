#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Update an ongoing call at runtime. Supports overriding dynamic variables, metadata, and the data storage setting on the running call, and controlling the live agent (inject context, trigger a response). These overrides take effect immediately on the live call; metadata and data storage setting changes are also persisted to the call record. To update a call that is no longer ongoing, use /v2/update-call/{call_id}.
        /// </summary>
        /// <param name="callId">
        /// Example: call_a4441234567890777c4a4a123e6
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.UpdateLiveCallResponse> UpdateLiveCallAsync(
            string callId,

            global::RetellAI.UpdateLiveCallRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an ongoing call at runtime. Supports overriding dynamic variables, metadata, and the data storage setting on the running call, and controlling the live agent (inject context, trigger a response). These overrides take effect immediately on the live call; metadata and data storage setting changes are also persisted to the call record. To update a call that is no longer ongoing, use /v2/update-call/{call_id}.
        /// </summary>
        /// <param name="callId">
        /// Example: call_a4441234567890777c4a4a123e6
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.UpdateLiveCallResponse>> UpdateLiveCallAsResponseAsync(
            string callId,

            global::RetellAI.UpdateLiveCallRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an ongoing call at runtime. Supports overriding dynamic variables, metadata, and the data storage setting on the running call, and controlling the live agent (inject context, trigger a response). These overrides take effect immediately on the live call; metadata and data storage setting changes are also persisted to the call record. To update a call that is no longer ongoing, use /v2/update-call/{call_id}.
        /// </summary>
        /// <param name="callId">
        /// Example: call_a4441234567890777c4a4a123e6
        /// </param>
        /// <param name="fieldsToOverride">
        /// Call fields to override on the running call. Each field is applied to the live call immediately; omitted fields are left unchanged.
        /// </param>
        /// <param name="callControl">
        /// Live agent control. At least one of `additional_context` or `trigger_response` should be supplied; an empty object is a no-op.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.UpdateLiveCallResponse> UpdateLiveCallAsync(
            string callId,
            global::RetellAI.UpdateLiveCallRequestFieldsToOverride? fieldsToOverride = default,
            global::RetellAI.UpdateLiveCallRequestCallControl? callControl = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}