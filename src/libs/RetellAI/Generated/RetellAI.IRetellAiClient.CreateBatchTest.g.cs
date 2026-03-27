#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Create a batch test to run multiple test cases
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.TestCaseBatchJob> CreateBatchTestAsync(

            global::RetellAI.CreateBatchTestRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch test to run multiple test cases
        /// </summary>
        /// <param name="testCaseDefinitionIds">
        /// Array of test case definition IDs to run
        /// </param>
        /// <param name="responseEngine">
        /// Response engine for test cases. Custom LLM is not supported.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.TestCaseBatchJob> CreateBatchTestAsync(
            global::System.Collections.Generic.IList<string> testCaseDefinitionIds,
            global::RetellAI.RetellResponseEngine responseEngine,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}