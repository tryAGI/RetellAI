#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Record a user or human transfer-target message in an ongoing escalated chat. SMS chats accept only transfer_target and send SMS before recording. API chats only record; delivery is the customer's responsibility. Idempotency keys are scoped to the organization. Successful results are retained for 24 hours. Concurrent requests with the same key wait for the lock. Reusing a key after success returns 200 with the original message_id and created_timestamp, without sending again. No duplicate-key error is raised. Failures are not cached and release the lock so the same key can be retried. Each execution makes one SMS send attempt. If delivery is uncertain or processing fails after sending, a retried request can send the SMS again and cause duplicates.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.RecordChatMessageResponse> RecordChatMessageAsync(
            string chatId,

            global::RetellAI.OneOf<global::RetellAI.RecordChatMessageRequestVariant1, global::RetellAI.RecordChatMessageRequestVariant2> request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Record a user or human transfer-target message in an ongoing escalated chat. SMS chats accept only transfer_target and send SMS before recording. API chats only record; delivery is the customer's responsibility. Idempotency keys are scoped to the organization. Successful results are retained for 24 hours. Concurrent requests with the same key wait for the lock. Reusing a key after success returns 200 with the original message_id and created_timestamp, without sending again. No duplicate-key error is raised. Failures are not cached and release the lock so the same key can be retried. Each execution makes one SMS send attempt. If delivery is uncertain or processing fails after sending, a retried request can send the SMS again and cause duplicates.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.RecordChatMessageResponse>> RecordChatMessageAsResponseAsync(
            string chatId,

            global::RetellAI.OneOf<global::RetellAI.RecordChatMessageRequestVariant1, global::RetellAI.RecordChatMessageRequestVariant2> request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Record a user or human transfer-target message in an ongoing escalated chat. SMS chats accept only transfer_target and send SMS before recording. API chats only record; delivery is the customer's responsibility. Idempotency keys are scoped to the organization. Successful results are retained for 24 hours. Concurrent requests with the same key wait for the lock. Reusing a key after success returns 200 with the original message_id and created_timestamp, without sending again. No duplicate-key error is raised. Failures are not cached and release the lock so the same key can be retried. Each execution makes one SMS send attempt. If delivery is uncertain or processing fails after sending, a retried request can send the SMS again and cause duplicates.
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.RecordChatMessageResponse> RecordChatMessageAsync(
            string chatId,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}