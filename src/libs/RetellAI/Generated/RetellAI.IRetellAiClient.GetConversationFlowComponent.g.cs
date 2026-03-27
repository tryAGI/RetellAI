#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Get a shared conversation flow component
        /// </summary>
        /// <param name="conversationFlowComponentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.ConversationFlowComponentResponse> GetConversationFlowComponentAsync(
            string conversationFlowComponentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}