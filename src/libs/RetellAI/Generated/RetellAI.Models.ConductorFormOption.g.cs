
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormOption
    {
        /// <summary>
        /// Text shown for the option. Unique within the field. Answers and default values refer to the option by this label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Helper text shown under the option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Small badge next to an option, such as "Recommended".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public global::RetellAI.ConductorFormTag? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormOption" /> class.
        /// </summary>
        /// <param name="label">
        /// Text shown for the option. Unique within the field. Answers and default values refer to the option by this label.
        /// </param>
        /// <param name="description">
        /// Helper text shown under the option.
        /// </param>
        /// <param name="tag">
        /// Small badge next to an option, such as "Recommended".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormOption(
            string label,
            string? description,
            global::RetellAI.ConductorFormTag? tag)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description;
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormOption" /> class.
        /// </summary>
        public ConductorFormOption()
        {
        }

    }
}