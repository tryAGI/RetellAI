#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Delete a test case definition
        /// </summary>
        /// <param name="testCaseDefinitionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTestCaseDefinitionAsync(
            string testCaseDefinitionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}