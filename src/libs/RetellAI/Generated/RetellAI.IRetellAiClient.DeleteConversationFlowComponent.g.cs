#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Delete a shared conversation flow component. When deleting a shared component, creates local copies for all linked conversation flows.
        /// </summary>
        /// <param name="conversationFlowComponentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteConversationFlowComponentAsync(
            string conversationFlowComponentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}