
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartShowItemKeywordSourceSourceType
    {
        /// <summary>
        ///
        /// </summary>
        CallId,
        /// <summary>
        ///
        /// </summary>
        ChatId,
        /// <summary>
        ///
        /// </summary>
        DisconnectionReason,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartShowItemKeywordSourceSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartShowItemKeywordSourceSourceType value)
        {
            return value switch
            {
                ChartShowItemKeywordSourceSourceType.CallId => "call_id",
                ChartShowItemKeywordSourceSourceType.ChatId => "chat_id",
                ChartShowItemKeywordSourceSourceType.DisconnectionReason => "disconnection_reason",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartShowItemKeywordSourceSourceType? ToEnum(string value)
        {
            return value switch
            {
                "call_id" => ChartShowItemKeywordSourceSourceType.CallId,
                "chat_id" => ChartShowItemKeywordSourceSourceType.ChatId,
                "disconnection_reason" => ChartShowItemKeywordSourceSourceType.DisconnectionReason,
                _ => null,
            };
        }
    }
}