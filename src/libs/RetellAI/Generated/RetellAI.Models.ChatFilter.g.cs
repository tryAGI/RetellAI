
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Filter criteria for chats. All conditions are implicitly connected with AND.
    /// </summary>
    public sealed partial class ChatFilter
    {
        /// <summary>
        /// Filter by agent(s). Agent filters are connected by OR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>? Agent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_tag")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, object>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, object>? AgentTag { get; set; }

        /// <summary>
        /// Filter by chat ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.StringFilter, global::RetellAI.EnumFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.StringFilter, global::RetellAI.EnumFilter>? ChatId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatStatus>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatStatus>? ChatStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnection_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDisconnectionReason>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDisconnectionReason>? DisconnectionReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterUserSentiment>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterUserSentiment>? UserSentiment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_successful")]
        public global::RetellAI.BooleanFilter? ChatSuccessful { get; set; }

        /// <summary>
        /// Filter by chat start timestamp (epoch ms).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? StartTimestamp { get; set; }

        /// <summary>
        /// Filter by chat end timestamp (epoch ms).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? EndTimestamp { get; set; }

        /// <summary>
        /// Filter by chat duration in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? DurationMs { get; set; }

        /// <summary>
        /// Filter by total chat cost in cents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("combined_cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? CombinedCost { get; set; }

        /// <summary>
        /// Filter by custom post-chat analysis outputs. Each filter `key` matches the configured output's `name`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_analysis_data")]
        public global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? CustomAnalysisData { get; set; }

        /// <summary>
        /// Filter by organization-level attributes that attach business context to chats, such as customer tier or campaign, so chats can be organized and filtered consistently in Chat History. Use the attribute ID as `key` and the chat's attribute value as `value`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_attributes")]
        public global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? CustomAttributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFilter" /> class.
        /// </summary>
        /// <param name="agent">
        /// Filter by agent(s). Agent filters are connected by OR.
        /// </param>
        /// <param name="agentTag"></param>
        /// <param name="chatId">
        /// Filter by chat ID.
        /// </param>
        /// <param name="chatStatus"></param>
        /// <param name="disconnectionReason"></param>
        /// <param name="userSentiment"></param>
        /// <param name="chatSuccessful"></param>
        /// <param name="startTimestamp">
        /// Filter by chat start timestamp (epoch ms).
        /// </param>
        /// <param name="endTimestamp">
        /// Filter by chat end timestamp (epoch ms).
        /// </param>
        /// <param name="durationMs">
        /// Filter by chat duration in milliseconds.
        /// </param>
        /// <param name="combinedCost">
        /// Filter by total chat cost in cents.
        /// </param>
        /// <param name="customAnalysisData">
        /// Filter by custom post-chat analysis outputs. Each filter `key` matches the configured output's `name`.
        /// </param>
        /// <param name="customAttributes">
        /// Filter by organization-level attributes that attach business context to chats, such as customer tier or campaign, so chats can be organized and filtered consistently in Chat History. Use the attribute ID as `key` and the chat's attribute value as `value`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatFilter(
            global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>? agent,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, object>? agentTag,
            global::RetellAI.OneOf<global::RetellAI.StringFilter, global::RetellAI.EnumFilter>? chatId,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterChatStatus>? chatStatus,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterDisconnectionReason>? disconnectionReason,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.ChatFilterUserSentiment>? userSentiment,
            global::RetellAI.BooleanFilter? chatSuccessful,
            global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? startTimestamp,
            global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? endTimestamp,
            global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? durationMs,
            global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? combinedCost,
            global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? customAnalysisData,
            global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? customAttributes)
        {
            this.Agent = agent;
            this.AgentTag = agentTag;
            this.ChatId = chatId;
            this.ChatStatus = chatStatus;
            this.DisconnectionReason = disconnectionReason;
            this.UserSentiment = userSentiment;
            this.ChatSuccessful = chatSuccessful;
            this.StartTimestamp = startTimestamp;
            this.EndTimestamp = endTimestamp;
            this.DurationMs = durationMs;
            this.CombinedCost = combinedCost;
            this.CustomAnalysisData = customAnalysisData;
            this.CustomAttributes = customAttributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFilter" /> class.
        /// </summary>
        public ChatFilter()
        {
        }

    }
}