
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Live agent control. At least one of `additional_context` or `trigger_response` should be supplied; an empty object is a no-op.
    /// </summary>
    public sealed partial class UpdateLiveCallRequestCallControl
    {
        /// <summary>
        /// Only `true` has an effect. When set, if the agent is currently speaking the response is interrupted and a new one is generated. If the agent has already finished speaking and is waiting silently for the user, the agent is nudged to produce another response. If the user is currently speaking, this field is a no-op so the agent does not talk over them. This field respects the agent's `interruption_sensitivity`: when sensitivity is `0` the agent's current speech is treated as uninterruptible, so `trigger_response` is a no-op while the agent is speaking. Omitting or setting `false` leaves the call untouched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_response")]
        public bool? TriggerResponse { get; set; }

        /// <summary>
        /// Free-form text appended to the call transcript with role "injected" and injected into the next agent response context. Must be non-empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_context")]
        public string? AdditionalContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLiveCallRequestCallControl" /> class.
        /// </summary>
        /// <param name="triggerResponse">
        /// Only `true` has an effect. When set, if the agent is currently speaking the response is interrupted and a new one is generated. If the agent has already finished speaking and is waiting silently for the user, the agent is nudged to produce another response. If the user is currently speaking, this field is a no-op so the agent does not talk over them. This field respects the agent's `interruption_sensitivity`: when sensitivity is `0` the agent's current speech is treated as uninterruptible, so `trigger_response` is a no-op while the agent is speaking. Omitting or setting `false` leaves the call untouched.
        /// </param>
        /// <param name="additionalContext">
        /// Free-form text appended to the call transcript with role "injected" and injected into the next agent response context. Must be non-empty.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateLiveCallRequestCallControl(
            bool? triggerResponse,
            string? additionalContext)
        {
            this.TriggerResponse = triggerResponse;
            this.AdditionalContext = additionalContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLiveCallRequestCallControl" /> class.
        /// </summary>
        public UpdateLiveCallRequestCallControl()
        {
        }

    }
}