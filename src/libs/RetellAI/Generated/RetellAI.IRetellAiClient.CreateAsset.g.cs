#nullable enable

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Upload an image or audio asset. Audio is normalized to headerless mono PCM16 at 24 kHz and can be referenced by `custom_on_hold_music_asset_id` on warm and agentic-warm transfer options. Accepted audio formats are MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. The maximum upload size is 10 MB and audio duration is limited to 210 seconds.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.Asset> CreateAssetAsync(

            global::RetellAI.CreateAssetRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload an image or audio asset. Audio is normalized to headerless mono PCM16 at 24 kHz and can be referenced by `custom_on_hold_music_asset_id` on warm and agentic-warm transfer options. Accepted audio formats are MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. The maximum upload size is 10 MB and audio duration is limited to 210 seconds.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.Asset>> CreateAssetAsResponseAsync(

            global::RetellAI.CreateAssetRequest request,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload an image or audio asset. Audio is normalized to headerless mono PCM16 at 24 kHz and can be referenced by `custom_on_hold_music_asset_id` on warm and agentic-warm transfer options. Accepted audio formats are MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. The maximum upload size is 10 MB and audio duration is limited to 210 seconds.
        /// </summary>
        /// <param name="file">
        /// Image or audio file to upload. Images support PNG, JPEG, GIF, WebP, and SVG. Audio supports MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. Maximum size is 10 MB; audio is limited to 210 seconds.
        /// </param>
        /// <param name="filename">
        /// Image or audio file to upload. Images support PNG, JPEG, GIF, WebP, and SVG. Audio supports MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. Maximum size is 10 MB; audio is limited to 210 seconds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.Asset> CreateAssetAsync(
            byte[] file,
            string filename,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload an image or audio asset. Audio is normalized to headerless mono PCM16 at 24 kHz and can be referenced by `custom_on_hold_music_asset_id` on warm and agentic-warm transfer options. Accepted audio formats are MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. The maximum upload size is 10 MB and audio duration is limited to 210 seconds.
        /// </summary>
        /// <param name="file">
        /// Image or audio file to upload. Images support PNG, JPEG, GIF, WebP, and SVG. Audio supports MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. Maximum size is 10 MB; audio is limited to 210 seconds.
        /// </param>
        /// <param name="filename">
        /// Image or audio file to upload. Images support PNG, JPEG, GIF, WebP, and SVG. Audio supports MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. Maximum size is 10 MB; audio is limited to 210 seconds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.Asset> CreateAssetAsync(
            global::System.IO.Stream file,
            string filename,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload an image or audio asset. Audio is normalized to headerless mono PCM16 at 24 kHz and can be referenced by `custom_on_hold_music_asset_id` on warm and agentic-warm transfer options. Accepted audio formats are MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. The maximum upload size is 10 MB and audio duration is limited to 210 seconds.
        /// </summary>
        /// <param name="file">
        /// Image or audio file to upload. Images support PNG, JPEG, GIF, WebP, and SVG. Audio supports MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. Maximum size is 10 MB; audio is limited to 210 seconds.
        /// </param>
        /// <param name="filename">
        /// Image or audio file to upload. Images support PNG, JPEG, GIF, WebP, and SVG. Audio supports MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. Maximum size is 10 MB; audio is limited to 210 seconds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.Asset>> CreateAssetAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}