
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Breakdown dimension. Call-only values include `batch_call_id`, `call_successful`, `call_status`, `direction`, and `call_type`; chat-only values are `chat_successful` and `chat_status`. `agent_version` also separates results by `agent_id`. On donut charts, `direction` includes phone calls only. Do not set `time`; it is added automatically for `line`, `bar`, and `column`.
    /// </summary>
    public enum ChartGroupItemVariant1Type
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
    public static class ChartGroupItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartGroupItemVariant1Type value)
        {
            return value switch
            {
                ChartGroupItemVariant1Type.AgentId => "agent_id",
                ChartGroupItemVariant1Type.AgentVersion => "agent_version",
                ChartGroupItemVariant1Type.BatchCallId => "batch_call_id",
                ChartGroupItemVariant1Type.CallStatus => "call_status",
                ChartGroupItemVariant1Type.CallSuccessful => "call_successful",
                ChartGroupItemVariant1Type.CallType => "call_type",
                ChartGroupItemVariant1Type.ChatStatus => "chat_status",
                ChartGroupItemVariant1Type.ChatSuccessful => "chat_successful",
                ChartGroupItemVariant1Type.Direction => "direction",
                ChartGroupItemVariant1Type.DisconnectionReason => "disconnection_reason",
                ChartGroupItemVariant1Type.Time => "time",
                ChartGroupItemVariant1Type.UserSentiment => "user_sentiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartGroupItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "agent_id" => ChartGroupItemVariant1Type.AgentId,
                "agent_version" => ChartGroupItemVariant1Type.AgentVersion,
                "batch_call_id" => ChartGroupItemVariant1Type.BatchCallId,
                "call_status" => ChartGroupItemVariant1Type.CallStatus,
                "call_successful" => ChartGroupItemVariant1Type.CallSuccessful,
                "call_type" => ChartGroupItemVariant1Type.CallType,
                "chat_status" => ChartGroupItemVariant1Type.ChatStatus,
                "chat_successful" => ChartGroupItemVariant1Type.ChatSuccessful,
                "direction" => ChartGroupItemVariant1Type.Direction,
                "disconnection_reason" => ChartGroupItemVariant1Type.DisconnectionReason,
                "time" => ChartGroupItemVariant1Type.Time,
                "user_sentiment" => ChartGroupItemVariant1Type.UserSentiment,
                _ => null,
            };
        }
    }
}