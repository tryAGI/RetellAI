
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Filter criteria for calls. All conditions are implicitly connected with AND.
    /// </summary>
    public sealed partial class CallFilter
    {
        /// <summary>
        /// Filter by agent(s). Agent filters are connected by OR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public global::RetellAI.StringFilter? CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_call_id")]
        public global::RetellAI.StringFilter? BatchCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallStatus>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallStatus>? CallStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_voicemail")]
        public global::RetellAI.BooleanFilter? InVoicemail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnection_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDisconnectionReason>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDisconnectionReason>? DisconnectionReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_number")]
        public global::RetellAI.StringFilter? FromNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_number")]
        public global::RetellAI.StringFilter? ToNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallType>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallType>? CallType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDirection>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDirection>? Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterUserSentiment>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterUserSentiment>? UserSentiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_storage_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDataStorageSetting>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDataStorageSetting>? DataStorageSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_successful")]
        public global::RetellAI.BooleanFilter? CallSuccessful { get; set; }

        /// <summary>
        /// Filter by call start timestamp (epoch ms).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? StartTimestamp { get; set; }

        /// <summary>
        /// Filter by call end timestamp (epoch ms).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? EndTimestamp { get; set; }

        /// <summary>
        /// Filter by call duration in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? DurationMs { get; set; }

        /// <summary>
        /// Filter by combined cost of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("combined_cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? CombinedCost { get; set; }

        /// <summary>
        /// Filter by end-to-end latency p50.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("e2e_latency_p50")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OneOfJsonConverter<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>))]
        public global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? E2eLatencyP50 { get; set; }

        /// <summary>
        /// Filter by tool call criteria. Tool call filters are connected by AND.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::RetellAI.ToolCallFilter>? ToolCalls { get; set; }

        /// <summary>
        /// Filter by custom analysis data fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_analysis_data")]
        public global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? CustomAnalysisData { get; set; }

        /// <summary>
        /// Filter by custom attributes fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_attributes")]
        public global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? CustomAttributes { get; set; }

        /// <summary>
        /// Filter by metadata fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? Metadata { get; set; }

        /// <summary>
        /// Filter by dynamic variables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.CallFilterDynamicVariable>>? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallFilter" /> class.
        /// </summary>
        /// <param name="agent">
        /// Filter by agent(s). Agent filters are connected by OR.
        /// </param>
        /// <param name="callId"></param>
        /// <param name="batchCallId"></param>
        /// <param name="callStatus"></param>
        /// <param name="inVoicemail"></param>
        /// <param name="disconnectionReason"></param>
        /// <param name="fromNumber"></param>
        /// <param name="toNumber"></param>
        /// <param name="callType"></param>
        /// <param name="direction"></param>
        /// <param name="userSentiment"></param>
        /// <param name="dataStorageSetting"></param>
        /// <param name="callSuccessful"></param>
        /// <param name="startTimestamp">
        /// Filter by call start timestamp (epoch ms).
        /// </param>
        /// <param name="endTimestamp">
        /// Filter by call end timestamp (epoch ms).
        /// </param>
        /// <param name="durationMs">
        /// Filter by call duration in milliseconds.
        /// </param>
        /// <param name="combinedCost">
        /// Filter by combined cost of the call.
        /// </param>
        /// <param name="e2eLatencyP50">
        /// Filter by end-to-end latency p50.
        /// </param>
        /// <param name="toolCalls">
        /// Filter by tool call criteria. Tool call filters are connected by AND.
        /// </param>
        /// <param name="customAnalysisData">
        /// Filter by custom analysis data fields.
        /// </param>
        /// <param name="customAttributes">
        /// Filter by custom attributes fields.
        /// </param>
        /// <param name="metadata">
        /// Filter by metadata fields.
        /// </param>
        /// <param name="dynamicVariables">
        /// Filter by dynamic variables.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallFilter(
            global::System.Collections.Generic.IList<global::RetellAI.AgentFilter>? agent,
            global::RetellAI.StringFilter? callId,
            global::RetellAI.StringFilter? batchCallId,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallStatus>? callStatus,
            global::RetellAI.BooleanFilter? inVoicemail,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDisconnectionReason>? disconnectionReason,
            global::RetellAI.StringFilter? fromNumber,
            global::RetellAI.StringFilter? toNumber,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterCallType>? callType,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDirection>? direction,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterUserSentiment>? userSentiment,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.CallFilterDataStorageSetting>? dataStorageSetting,
            global::RetellAI.BooleanFilter? callSuccessful,
            global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? startTimestamp,
            global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? endTimestamp,
            global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? durationMs,
            global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? combinedCost,
            global::RetellAI.OneOf<global::RetellAI.NumberFilter, global::RetellAI.RangeFilter>? e2eLatencyP50,
            global::System.Collections.Generic.IList<global::RetellAI.ToolCallFilter>? toolCalls,
            global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? customAnalysisData,
            global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? customAttributes,
            global::System.Collections.Generic.IList<global::RetellAI.CustomFieldFilter>? metadata,
            global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.StringFilter, global::RetellAI.CallFilterDynamicVariable>>? dynamicVariables)
        {
            this.Agent = agent;
            this.CallId = callId;
            this.BatchCallId = batchCallId;
            this.CallStatus = callStatus;
            this.InVoicemail = inVoicemail;
            this.DisconnectionReason = disconnectionReason;
            this.FromNumber = fromNumber;
            this.ToNumber = toNumber;
            this.CallType = callType;
            this.Direction = direction;
            this.UserSentiment = userSentiment;
            this.DataStorageSetting = dataStorageSetting;
            this.CallSuccessful = callSuccessful;
            this.StartTimestamp = startTimestamp;
            this.EndTimestamp = endTimestamp;
            this.DurationMs = durationMs;
            this.CombinedCost = combinedCost;
            this.E2eLatencyP50 = e2eLatencyP50;
            this.ToolCalls = toolCalls;
            this.CustomAnalysisData = customAnalysisData;
            this.CustomAttributes = customAttributes;
            this.Metadata = metadata;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallFilter" /> class.
        /// </summary>
        public CallFilter()
        {
        }
    }
}