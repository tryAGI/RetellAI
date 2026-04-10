#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Search for community voices from voice providers
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.SearchCommunityVoiceResponse> SearchCommunityVoiceAsync(

            global::RetellAI.SearchCommunityVoiceRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for community voices from voice providers
        /// </summary>
        /// <param name="voiceProvider">
        /// Voice provider to search.
        /// </param>
        /// <param name="searchQuery">
        /// Search query to find voices by name, description, or ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.SearchCommunityVoiceResponse> SearchCommunityVoiceAsync(
            string searchQuery,
            global::RetellAI.SearchCommunityVoiceRequestVoiceProvider? voiceProvider = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}