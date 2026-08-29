
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAssetRequest
    {
        /// <summary>
        /// Image or audio file to upload. Images support PNG, JPEG, GIF, WebP, and SVG. Audio supports MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. Maximum size is 10 MB; audio is limited to 210 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// Image or audio file to upload. Images support PNG, JPEG, GIF, WebP, and SVG. Audio supports MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. Maximum size is 10 MB; audio is limited to 210 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// Image or audio file to upload. Images support PNG, JPEG, GIF, WebP, and SVG. Audio supports MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. Maximum size is 10 MB; audio is limited to 210 seconds.
        /// </param>
        /// <param name="filename">
        /// Image or audio file to upload. Images support PNG, JPEG, GIF, WebP, and SVG. Audio supports MP3, WAV, WebM, OGG, M4A, AAC, and FLAC. Maximum size is 10 MB; audio is limited to 210 seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetRequest(
            byte[] file,
            string filename)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetRequest" /> class.
        /// </summary>
        public CreateAssetRequest()
        {
        }

    }
}