
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Position of the note on the canvas.
    /// </summary>
    public sealed partial class NoteDisplayPosition
    {
        /// <summary>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        public double? X { get; set; }

        /// <summary>
        /// Example: 150
        /// </summary>
        /// <example>150</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        public double? Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NoteDisplayPosition" /> class.
        /// </summary>
        /// <param name="x">
        /// Example: 300
        /// </param>
        /// <param name="y">
        /// Example: 150
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NoteDisplayPosition(
            double? x,
            double? y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoteDisplayPosition" /> class.
        /// </summary>
        public NoteDisplayPosition()
        {
        }
    }
}