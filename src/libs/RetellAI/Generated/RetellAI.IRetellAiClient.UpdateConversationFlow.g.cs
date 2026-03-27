#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Update an existing conversation flow
        /// </summary>
        /// <param name="conversationFlowId"></param>
        /// <param name="version">
        /// Example: 1
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.ConversationFlowResponse> UpdateConversationFlowAsync(
            string conversationFlowId,

            global::RetellAI.ConversationFlow request,
            int? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing conversation flow
        /// </summary>
        /// <param name="conversationFlowId"></param>
        /// <param name="version">
        /// Example: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.ConversationFlowResponse> UpdateConversationFlowAsync(
            string conversationFlowId,
            int? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}