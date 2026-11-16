
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConductorFormStep
    {
        /// <summary>
        /// Items in the same row sit side by side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::RetellAI.ConductorFormItem>> Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormStep" /> class.
        /// </summary>
        /// <param name="rows">
        /// Items in the same row sit side by side.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConductorFormStep(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::RetellAI.ConductorFormItem>> rows)
        {
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConductorFormStep" /> class.
        /// </summary>
        public ConductorFormStep()
        {
        }

    }
}