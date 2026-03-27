#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Get a test case definition by ID
        /// </summary>
        /// <param name="testCaseDefinitionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.TestCaseDefinition> GetTestCaseDefinitionAsync(
            string testCaseDefinitionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}