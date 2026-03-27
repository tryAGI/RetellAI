#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Create a new shared conversation flow component
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.ConversationFlowComponentResponse> CreateConversationFlowComponentAsync(

            global::RetellAI.CreateConversationFlowComponentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new shared conversation flow component
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.ConversationFlowComponentResponse> CreateConversationFlowComponentAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}