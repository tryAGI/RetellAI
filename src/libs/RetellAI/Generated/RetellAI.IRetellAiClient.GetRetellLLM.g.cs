#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Retrieve details of a specific Retell LLM Response Engine
        /// </summary>
        /// <param name="llmId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="version">
        /// Example: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.RetellLLMResponse> GetRetellLLMAsync(
            string llmId,
            int? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}