#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Get a test case job (test run) by ID
        /// </summary>
        /// <param name="testCaseJobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.TestCaseJob> GetTestRunAsync(
            string testCaseJobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}