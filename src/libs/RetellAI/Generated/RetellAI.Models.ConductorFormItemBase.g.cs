
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormItemBase
    {
        /// <summary>
        /// Short identifier for the item, such as `opening_hours`. Each item in the form needs a different id. Answers refer to their field by this id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Text shown above the field, or the heading of a text block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Helper text shown under the label, or the paragraph of a text block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormItemBase" /> class.
        /// </summary>
        /// <param name="id">
        /// Short identifier for the item, such as `opening_hours`. Each item in the form needs a different id. Answers refer to their field by this id.
        /// </param>
        /// <param name="label">
        /// Text shown above the field, or the heading of a text block.
        /// </param>
        /// <param name="description">
        /// Helper text shown under the label, or the paragraph of a text block.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormItemBase(
            string id,
            string? label,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Label = label;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormItemBase" /> class.
        /// </summary>
        public ConductorFormItemBase()
        {
        }

    }
}