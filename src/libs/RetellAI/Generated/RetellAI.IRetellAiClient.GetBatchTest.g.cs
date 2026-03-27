#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Get a batch test job by ID
        /// </summary>
        /// <param name="testCaseBatchJobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.TestCaseBatchJob> GetBatchTestAsync(
            string testCaseBatchJobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}