
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorForm
    {
        /// <summary>
        /// Shown one page at a time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.ConductorFormStep> Steps { get; set; }

        /// <summary>
        /// Submit button text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_button_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrimaryButtonLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorForm" /> class.
        /// </summary>
        /// <param name="steps">
        /// Shown one page at a time.
        /// </param>
        /// <param name="primaryButtonLabel">
        /// Submit button text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorForm(
            global::System.Collections.Generic.IList<global::RetellAI.ConductorFormStep> steps,
            string primaryButtonLabel)
        {
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
            this.PrimaryButtonLabel = primaryButtonLabel ?? throw new global::System.ArgumentNullException(nameof(primaryButtonLabel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorForm" /> class.
        /// </summary>
        public ConductorForm()
        {
        }

    }
}