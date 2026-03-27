#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Publish the latest version of the chat agent and create a new draft chat agent with newer version.
        /// </summary>
        /// <param name="agentId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task PublishChatAgentAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}