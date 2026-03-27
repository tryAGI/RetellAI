#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Create a new Retell LLM Response Engine that can be attached to an agent. This is used to generate response output for the agent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.RetellLLMResponse> CreateRetellLLMAsync(

            global::RetellAI.RetellLlmRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new Retell LLM Response Engine that can be attached to an agent. This is used to generate response output for the agent.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.RetellLLMResponse> CreateRetellLLMAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}