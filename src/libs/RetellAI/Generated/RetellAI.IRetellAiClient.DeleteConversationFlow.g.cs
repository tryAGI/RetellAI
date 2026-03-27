#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Delete a conversation flow and all its versions
        /// </summary>
        /// <param name="conversationFlowId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteConversationFlowAsync(
            string conversationFlowId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}