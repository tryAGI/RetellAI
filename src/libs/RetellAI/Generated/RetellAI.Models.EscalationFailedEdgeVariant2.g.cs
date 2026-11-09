
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EscalationFailedEdgeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_condition")]
        public global::RetellAI.EscalationFailedEdgeVariant2TransitionCondition? TransitionCondition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EscalationFailedEdgeVariant2" /> class.
        /// </summary>
        /// <param name="transitionCondition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EscalationFailedEdgeVariant2(
            global::RetellAI.EscalationFailedEdgeVariant2TransitionCondition? transitionCondition)
        {
            this.TransitionCondition = transitionCondition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EscalationFailedEdgeVariant2" /> class.
        /// </summary>
        public EscalationFailedEdgeVariant2()
        {
        }

    }
}