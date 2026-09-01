
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartGroupType
    {
        /// <summary>
        ///
        /// </summary>
        AgentId,
        /// <summary>
        ///
        /// </summary>
        AgentVersion,
        /// <summary>
        ///
        /// </summary>
        BatchCallId,
        /// <summary>
        ///
        /// </summary>
        CallStatus,
        /// <summary>
        ///
        /// </summary>
        CallSuccessful,
        /// <summary>
        ///
        /// </summary>
        CallType,
        /// <summary>
        ///
        /// </summary>
        ChatStatus,
        /// <summary>
        ///
        /// </summary>
        ChatSuccessful,
        /// <summary>
        ///
        /// </summary>
        CustomAnalysisData,
        /// <summary>
        ///
        /// </summary>
        CustomAttribute,
        /// <summary>
        ///
        /// </summary>
        Direction,
        /// <summary>
        ///
        /// </summary>
        DisconnectionReason,
        /// <summary>
        ///
        /// </summary>
        Time,
        /// <summary>
        ///
        /// </summary>
        UserSentiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartGroupType value)
        {
            return value switch
            {
                ChartGroupType.AgentId => "agent_id",
                ChartGroupType.AgentVersion => "agent_version",
                ChartGroupType.BatchCallId => "batch_call_id",
                ChartGroupType.CallStatus => "call_status",
                ChartGroupType.CallSuccessful => "call_successful",
                ChartGroupType.CallType => "call_type",
                ChartGroupType.ChatStatus => "chat_status",
                ChartGroupType.ChatSuccessful => "chat_successful",
                ChartGroupType.CustomAnalysisData => "custom_analysis_data",
                ChartGroupType.CustomAttribute => "custom_attribute",
                ChartGroupType.Direction => "direction",
                ChartGroupType.DisconnectionReason => "disconnection_reason",
                ChartGroupType.Time => "time",
                ChartGroupType.UserSentiment => "user_sentiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartGroupType? ToEnum(string value)
        {
            return value switch
            {
                "agent_id" => ChartGroupType.AgentId,
                "agent_version" => ChartGroupType.AgentVersion,
                "batch_call_id" => ChartGroupType.BatchCallId,
                "call_status" => ChartGroupType.CallStatus,
                "call_successful" => ChartGroupType.CallSuccessful,
                "call_type" => ChartGroupType.CallType,
                "chat_status" => ChartGroupType.ChatStatus,
                "chat_successful" => ChartGroupType.ChatSuccessful,
                "custom_analysis_data" => ChartGroupType.CustomAnalysisData,
                "custom_attribute" => ChartGroupType.CustomAttribute,
                "direction" => ChartGroupType.Direction,
                "disconnection_reason" => ChartGroupType.DisconnectionReason,
                "time" => ChartGroupType.Time,
                "user_sentiment" => ChartGroupType.UserSentiment,
                _ => null,
            };
        }
    }
}