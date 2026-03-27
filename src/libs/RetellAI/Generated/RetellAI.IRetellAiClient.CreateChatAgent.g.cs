#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Create a new chat agent
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.ChatAgentResponse> CreateChatAgentAsync(

            global::RetellAI.AllOf<global::RetellAI.ChatAgentRequest, object> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new chat agent
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.ChatAgentResponse> CreateChatAgentAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}