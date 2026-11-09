
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EscalateChatNodeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.EscalateChatNodeVariant2TypeJsonConverter))]
        public global::RetellAI.EscalateChatNodeVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.EscalationDestination Destination { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.EscalationFailedEdgeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.EscalationFailedEdge Edge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EscalateChatNodeVariant2" /> class.
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="edge"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EscalateChatNodeVariant2(
            global::RetellAI.EscalationDestination destination,
            global::RetellAI.EscalationFailedEdge edge,
            global::RetellAI.EscalateChatNodeVariant2Type type)
        {
            this.Type = type;
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.Edge = edge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EscalateChatNodeVariant2" /> class.
        /// </summary>
        public EscalateChatNodeVariant2()
        {
        }

    }
}