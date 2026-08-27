
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateLiveCallRequest
    {
        /// <summary>
        /// Call fields to override on the running call. Each field is applied to the live call immediately; omitted fields are left unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields_to_override")]
        public global::RetellAI.UpdateLiveCallRequestFieldsToOverride? FieldsToOverride { get; set; }

        /// <summary>
        /// Live agent control. At least one of `additional_context` or `trigger_response` should be supplied; an empty object is a no-op.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_control")]
        public global::RetellAI.UpdateLiveCallRequestCallControl? CallControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLiveCallRequest" /> class.
        /// </summary>
        /// <param name="fieldsToOverride">
        /// Call fields to override on the running call. Each field is applied to the live call immediately; omitted fields are left unchanged.
        /// </param>
        /// <param name="callControl">
        /// Live agent control. At least one of `additional_context` or `trigger_response` should be supplied; an empty object is a no-op.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateLiveCallRequest(
            global::RetellAI.UpdateLiveCallRequestFieldsToOverride? fieldsToOverride,
            global::RetellAI.UpdateLiveCallRequestCallControl? callControl)
        {
            this.FieldsToOverride = fieldsToOverride;
            this.CallControl = callControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLiveCallRequest" /> class.
        /// </summary>
        public UpdateLiveCallRequest()
        {
        }

    }
}