
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PreSessionToolVariant2
    {
        /// <summary>
        /// Names of tools that must run before this one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depends_on")]
        public global::System.Collections.Generic.IList<string>? DependsOn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreSessionToolVariant2" /> class.
        /// </summary>
        /// <param name="dependsOn">
        /// Names of tools that must run before this one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreSessionToolVariant2(
            global::System.Collections.Generic.IList<string>? dependsOn)
        {
            this.DependsOn = dependsOn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreSessionToolVariant2" /> class.
        /// </summary>
        public PreSessionToolVariant2()
        {
        }

    }
}