
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChartUpdateVariant2Size
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("col_span")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ColSpan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartUpdateVariant2Size" /> class.
        /// </summary>
        /// <param name="colSpan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartUpdateVariant2Size(
            object colSpan)
        {
            this.ColSpan = colSpan ?? throw new global::System.ArgumentNullException(nameof(colSpan));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartUpdateVariant2Size" /> class.
        /// </summary>
        public ChartUpdateVariant2Size()
        {
        }

    }
}