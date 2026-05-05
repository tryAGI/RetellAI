#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Clone a voice from audio files
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.VoiceResponse> CloneVoiceAsync(

            global::RetellAI.CloneVoiceRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone a voice from audio files
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.VoiceResponse>> CloneVoiceAsResponseAsync(

            global::RetellAI.CloneVoiceRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone a voice from audio files
        /// </summary>
        /// <param name="files">
        /// Audio files to use for voice cloning. Up to 25 files allowed. For Cartesia and MiniMax, only 1 file is supported. For Inworld, up to 3 files are supported.
        /// </param>
        /// <param name="voiceName">
        /// Name for the cloned voice
        /// </param>
        /// <param name="voiceProvider">
        /// Voice provider to use for cloning.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.VoiceResponse> CloneVoiceAsync(
            global::System.Collections.Generic.IList<byte[]> files,
            string voiceName,
            global::RetellAI.CloneVoiceRequestVoiceProvider voiceProvider,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Clone a voice from audio files
        /// </summary>
        /// <param name="files">
        /// Audio files to use for voice cloning. Up to 25 files allowed. For Cartesia and MiniMax, only 1 file is supported. For Inworld, up to 3 files are supported.
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files' file parts.
        /// </param>
        /// <param name="voiceName">
        /// Name for the cloned voice
        /// </param>
        /// <param name="voiceProvider">
        /// Voice provider to use for cloning.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.VoiceResponse> CloneVoiceAsync(
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> files,
            string voiceName,
            global::RetellAI.CloneVoiceRequestVoiceProvider voiceProvider,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone a voice from audio files
        /// </summary>
        /// <param name="files">
        /// Audio files to use for voice cloning. Up to 25 files allowed. For Cartesia and MiniMax, only 1 file is supported. For Inworld, up to 3 files are supported.
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files' file parts.
        /// </param>
        /// <param name="voiceName">
        /// Name for the cloned voice
        /// </param>
        /// <param name="voiceProvider">
        /// Voice provider to use for cloning.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.VoiceResponse>> CloneVoiceAsResponseAsync(
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> files,
            string voiceName,
            global::RetellAI.CloneVoiceRequestVoiceProvider voiceProvider,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}