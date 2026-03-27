#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Create a chat completion message
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.CreateChatCompletionResponse> CreateChatCompletionAsync(

            global::RetellAI.CreateChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion message
        /// </summary>
        /// <param name="chatId">
        /// Unique id of the chat to create completion.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="content">
        /// user message to generate agent chat completion.<br/>
        /// Example: hi how are you doing?
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.CreateChatCompletionResponse> CreateChatCompletionAsync(
            string chatId,
            string content,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}