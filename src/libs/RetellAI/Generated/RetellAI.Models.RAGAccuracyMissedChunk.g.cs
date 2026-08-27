
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RAGAccuracyMissedChunk
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChunkId { get; set; }

        /// <summary>
        /// Content of the missed chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk")]
        public string? Chunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGAccuracyMissedChunk" /> class.
        /// </summary>
        /// <param name="chunkId"></param>
        /// <param name="chunk">
        /// Content of the missed chunk.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RAGAccuracyMissedChunk(
            string chunkId,
            string? chunk)
        {
            this.ChunkId = chunkId ?? throw new global::System.ArgumentNullException(nameof(chunkId));
            this.Chunk = chunk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGAccuracyMissedChunk" /> class.
        /// </summary>
        public RAGAccuracyMissedChunk()
        {
        }

    }
}