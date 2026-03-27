#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// List test case definitions for a response engine
        /// </summary>
        /// <param name="type"></param>
        /// <param name="llmId"></param>
        /// <param name="conversationFlowId"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::RetellAI.TestCaseDefinition>> ListTestCaseDefinitionsAsync(
            global::RetellAI.ListTestCaseDefinitionsType type,
            string? llmId = default,
            string? conversationFlowId = default,
            int? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}