#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Retrieve details of a specific Conversation Flow
        /// </summary>
        /// <param name="conversationFlowId"></param>
        /// <param name="version">
        /// Example: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.ConversationFlowResponse> GetConversationFlowAsync(
            string conversationFlowId,
            int? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}