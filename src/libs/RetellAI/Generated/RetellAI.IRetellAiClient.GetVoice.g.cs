#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Retrieve details of a specific voice
        /// </summary>
        /// <param name="voiceId">
        /// Example: retell-Cimo
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.VoiceResponse> GetVoiceAsync(
            string voiceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}