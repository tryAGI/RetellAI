
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChartUpdateVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.ChartUpdateVariant2Size Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartUpdateVariant2" /> class.
        /// </summary>
        /// <param name="size"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartUpdateVariant2(
            global::RetellAI.ChartUpdateVariant2Size size)
        {
            this.Size = size ?? throw new global::System.ArgumentNullException(nameof(size));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartUpdateVariant2" /> class.
        /// </summary>
        public ChartUpdateVariant2()
        {
        }

    }
}