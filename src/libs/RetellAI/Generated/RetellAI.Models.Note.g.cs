
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Note
    {
        /// <summary>
        /// Unique identifier for the note.<br/>
        /// Example: note_abc123
        /// </summary>
        /// <example>note_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Text content of the note, can contain refs to images in the format "&lt;image:asset_id&gt;"<br/>
        /// Example: Remember to handle edge cases here.
        /// </summary>
        /// <example>Remember to handle edge cases here.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Position of the note on the canvas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.NoteDisplayPosition DisplayPosition { get; set; }

        /// <summary>
        /// Dimensions of the note on the canvas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.NoteSize Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Note" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the note.<br/>
        /// Example: note_abc123
        /// </param>
        /// <param name="content">
        /// Text content of the note, can contain refs to images in the format "&lt;image:asset_id&gt;"<br/>
        /// Example: Remember to handle edge cases here.
        /// </param>
        /// <param name="displayPosition">
        /// Position of the note on the canvas.
        /// </param>
        /// <param name="size">
        /// Dimensions of the note on the canvas.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Note(
            string id,
            string content,
            global::RetellAI.NoteDisplayPosition displayPosition,
            global::RetellAI.NoteSize size)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.DisplayPosition = displayPosition ?? throw new global::System.ArgumentNullException(nameof(displayPosition));
            this.Size = size ?? throw new global::System.ArgumentNullException(nameof(size));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Note" /> class.
        /// </summary>
        public Note()
        {
        }
    }
}