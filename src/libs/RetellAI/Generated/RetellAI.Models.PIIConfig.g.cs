
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PIIConfig
    {
        /// <summary>
        /// The processing mode for PII scrubbing. Currently only post-call is supported.<br/>
        /// Default Value: post_call
        /// </summary>
        /// <default>global::RetellAI.PIIConfigMode.PostCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.PIIConfigModeJsonConverter))]
        public global::RetellAI.PIIConfigMode Mode { get; set; } = global::RetellAI.PIIConfigMode.PostCall;

        /// <summary>
        /// List of PII categories to scrub from transcripts and recordings.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.PIIConfigCategorie> Categories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PIIConfig" /> class.
        /// </summary>
        /// <param name="mode">
        /// The processing mode for PII scrubbing. Currently only post-call is supported.<br/>
        /// Default Value: post_call
        /// </param>
        /// <param name="categories">
        /// List of PII categories to scrub from transcripts and recordings.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PIIConfig(
            global::System.Collections.Generic.IList<global::RetellAI.PIIConfigCategorie> categories,
            global::RetellAI.PIIConfigMode mode = global::RetellAI.PIIConfigMode.PostCall)
        {
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PIIConfig" /> class.
        /// </summary>
        public PIIConfig()
        {
        }
    }
}