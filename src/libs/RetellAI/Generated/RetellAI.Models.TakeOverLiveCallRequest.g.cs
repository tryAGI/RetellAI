
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TakeOverLiveCallRequest
    {
        /// <summary>
        /// The id of the live-listen participant to upgrade, obtained when joining via /v2/listen-live-call.<br/>
        /// Example: listener_a1b2c3d4e5f6g7h8i9j0
        /// </summary>
        /// <example>listener_a1b2c3d4e5f6g7h8i9j0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("participant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParticipantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TakeOverLiveCallRequest" /> class.
        /// </summary>
        /// <param name="participantId">
        /// The id of the live-listen participant to upgrade, obtained when joining via /v2/listen-live-call.<br/>
        /// Example: listener_a1b2c3d4e5f6g7h8i9j0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TakeOverLiveCallRequest(
            string participantId)
        {
            this.ParticipantId = participantId ?? throw new global::System.ArgumentNullException(nameof(participantId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TakeOverLiveCallRequest" /> class.
        /// </summary>
        public TakeOverLiveCallRequest()
        {
        }

    }
}