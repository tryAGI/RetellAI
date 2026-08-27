
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppCRMConfig
    {
        /// <summary>
        /// Field mappings applied when syncing CRM records into Retell contacts. Must include phone_number, which is the field the two systems are matched on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_sync_mappings")]
        public global::System.Collections.Generic.IList<global::RetellAI.CRMSyncMapping>? InboundSyncMappings { get; set; }

        /// <summary>
        /// Field mappings applied when writing Retell contact changes back to the CRM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound_sync_mappings")]
        public global::System.Collections.Generic.IList<global::RetellAI.CRMSyncMapping>? OutboundSyncMappings { get; set; }

        /// <summary>
        /// Whether to push call/chat activity to the external CRM. Opt-in — defaults to false when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_conversation_activity")]
        public bool? SyncConversationActivity { get; set; }

        /// <summary>
        /// Whether to create a CRM record after a conversation when the contact is not yet linked to one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_new_contacts")]
        public bool? SyncNewContacts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCRMConfig" /> class.
        /// </summary>
        /// <param name="inboundSyncMappings">
        /// Field mappings applied when syncing CRM records into Retell contacts. Must include phone_number, which is the field the two systems are matched on.
        /// </param>
        /// <param name="outboundSyncMappings">
        /// Field mappings applied when writing Retell contact changes back to the CRM.
        /// </param>
        /// <param name="syncConversationActivity">
        /// Whether to push call/chat activity to the external CRM. Opt-in — defaults to false when unset.
        /// </param>
        /// <param name="syncNewContacts">
        /// Whether to create a CRM record after a conversation when the contact is not yet linked to one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCRMConfig(
            global::System.Collections.Generic.IList<global::RetellAI.CRMSyncMapping>? inboundSyncMappings,
            global::System.Collections.Generic.IList<global::RetellAI.CRMSyncMapping>? outboundSyncMappings,
            bool? syncConversationActivity,
            bool? syncNewContacts)
        {
            this.InboundSyncMappings = inboundSyncMappings;
            this.OutboundSyncMappings = outboundSyncMappings;
            this.SyncConversationActivity = syncConversationActivity;
            this.SyncNewContacts = syncNewContacts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCRMConfig" /> class.
        /// </summary>
        public AppCRMConfig()
        {
        }

    }
}