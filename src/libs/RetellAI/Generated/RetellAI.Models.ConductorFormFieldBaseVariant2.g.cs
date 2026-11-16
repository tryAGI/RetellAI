
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormFieldBaseVariant2
    {
        /// <summary>
        /// When true, the user must answer before submitting. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormFieldBaseVariant2" /> class.
        /// </summary>
        /// <param name="required">
        /// When true, the user must answer before submitting. Defaults to false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormFieldBaseVariant2(
            bool? required)
        {
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormFieldBaseVariant2" /> class.
        /// </summary>
        public ConductorFormFieldBaseVariant2()
        {
        }

    }
}