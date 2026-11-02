
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UtteranceVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::RetellAI.UtteranceVariant2Metadata? Metadata { get; set; }

        /// <summary>
        /// Array of words in the utterance with the word timestamp. Useful for understanding what word was spoken at what time. Note that the word timestamp is not guaranteed to be accurate, it's more like an approximation.<br/>
        /// Example: [{"word":"hi","start":0.7,"end":1.3}]
        /// </summary>
        /// <example>[{"word":"hi","start":0.7,"end":1.3}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.UtteranceVariant2Word> Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceVariant2" /> class.
        /// </summary>
        /// <param name="words">
        /// Array of words in the utterance with the word timestamp. Useful for understanding what word was spoken at what time. Note that the word timestamp is not guaranteed to be accurate, it's more like an approximation.<br/>
        /// Example: [{"word":"hi","start":0.7,"end":1.3}]
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UtteranceVariant2(
            global::System.Collections.Generic.IList<global::RetellAI.UtteranceVariant2Word> words,
            global::RetellAI.UtteranceVariant2Metadata? metadata)
        {
            this.Metadata = metadata;
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceVariant2" /> class.
        /// </summary>
        public UtteranceVariant2()
        {
        }

    }
}