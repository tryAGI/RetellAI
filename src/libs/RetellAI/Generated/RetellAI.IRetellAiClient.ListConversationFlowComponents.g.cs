#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// List shared conversation flow components
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::RetellAI.ConversationFlowComponentResponse>> ListConversationFlowComponentsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}