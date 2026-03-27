#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// End an ongoing chat
        /// </summary>
        /// <param name="chatId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task EndChatAsync(
            string chatId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}