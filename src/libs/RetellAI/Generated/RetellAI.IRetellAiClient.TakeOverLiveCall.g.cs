#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Take over an in-progress call from the AI agent. The agent stops responding and the specified live-listen participant is allowed to speak directly to the caller. The call must be in ONGOING status.
        /// </summary>
        /// <param name="callId">
        /// Example: 119c3f8e47135a29e65947eeb34cf12d
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.TakeOverLiveCallResponse> TakeOverLiveCallAsync(
            string callId,

            global::RetellAI.TakeOverLiveCallRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Take over an in-progress call from the AI agent. The agent stops responding and the specified live-listen participant is allowed to speak directly to the caller. The call must be in ONGOING status.
        /// </summary>
        /// <param name="callId">
        /// Example: 119c3f8e47135a29e65947eeb34cf12d
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.TakeOverLiveCallResponse>> TakeOverLiveCallAsResponseAsync(
            string callId,

            global::RetellAI.TakeOverLiveCallRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Take over an in-progress call from the AI agent. The agent stops responding and the specified live-listen participant is allowed to speak directly to the caller. The call must be in ONGOING status.
        /// </summary>
        /// <param name="callId">
        /// Example: 119c3f8e47135a29e65947eeb34cf12d
        /// </param>
        /// <param name="participantId">
        /// The id of the live-listen participant to upgrade, obtained when joining via /v2/listen-live-call.<br/>
        /// Example: listener_a1b2c3d4e5f6g7h8i9j0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.TakeOverLiveCallResponse> TakeOverLiveCallAsync(
            string callId,
            string participantId,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}