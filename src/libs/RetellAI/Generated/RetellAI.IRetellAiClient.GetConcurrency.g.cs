#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Get the current concurrency and concurrency limit of the org
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.GetConcurrencyResponse> GetConcurrencyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}