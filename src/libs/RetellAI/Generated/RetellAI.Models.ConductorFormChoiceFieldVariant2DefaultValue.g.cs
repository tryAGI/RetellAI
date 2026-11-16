
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormChoiceFieldVariant2DefaultValue
    {
        /// <summary>
        /// Labels of the options picked to start with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Selected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormChoiceFieldVariant2DefaultValue" /> class.
        /// </summary>
        /// <param name="selected">
        /// Labels of the options picked to start with.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormChoiceFieldVariant2DefaultValue(
            global::System.Collections.Generic.IList<string> selected)
        {
            this.Selected = selected ?? throw new global::System.ArgumentNullException(nameof(selected));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormChoiceFieldVariant2DefaultValue" /> class.
        /// </summary>
        public ConductorFormChoiceFieldVariant2DefaultValue()
        {
        }

    }
}