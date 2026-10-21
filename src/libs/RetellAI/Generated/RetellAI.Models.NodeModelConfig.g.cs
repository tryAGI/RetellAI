
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Model override for this node. Only cascading flows use it.
    /// </summary>
    public sealed partial class NodeModelConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.TextModelRef Primary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeModelConfig" /> class.
        /// </summary>
        /// <param name="primary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeModelConfig(
            global::RetellAI.TextModelRef primary)
        {
            this.Primary = primary ?? throw new global::System.ArgumentNullException(nameof(primary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeModelConfig" /> class.
        /// </summary>
        public NodeModelConfig()
        {
        }

    }
}