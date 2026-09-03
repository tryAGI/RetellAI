
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Duration and latency are milliseconds; `combined_cost` is cents. Averaging a boolean yields the fraction of populated values that are true, from 0 to 1.
    /// </summary>
    public enum ChartShowItemNumericSourceSourceType
    {
        /// <summary>
        ///
        /// </summary>
        CallPickedUp,
        /// <summary>
        ///
        /// </summary>
        CallSuccessful,
        /// <summary>
        ///
        /// </summary>
        CallTransferred,
        /// <summary>
        ///
        /// </summary>
        ChatSuccessful,
        /// <summary>
        ///
        /// </summary>
        CombinedCost,
        /// <summary>
        ///
        /// </summary>
        DurationMs,
        /// <summary>
        ///
        /// </summary>
        E2eLatencyP50,
        /// <summary>
        ///
        /// </summary>
        InVoicemail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartShowItemNumericSourceSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartShowItemNumericSourceSourceType value)
        {
            return value switch
            {
                ChartShowItemNumericSourceSourceType.CallPickedUp => "call_picked_up",
                ChartShowItemNumericSourceSourceType.CallSuccessful => "call_successful",
                ChartShowItemNumericSourceSourceType.CallTransferred => "call_transferred",
                ChartShowItemNumericSourceSourceType.ChatSuccessful => "chat_successful",
                ChartShowItemNumericSourceSourceType.CombinedCost => "combined_cost",
                ChartShowItemNumericSourceSourceType.DurationMs => "duration_ms",
                ChartShowItemNumericSourceSourceType.E2eLatencyP50 => "e2e_latency_p50",
                ChartShowItemNumericSourceSourceType.InVoicemail => "in_voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartShowItemNumericSourceSourceType? ToEnum(string value)
        {
            return value switch
            {
                "call_picked_up" => ChartShowItemNumericSourceSourceType.CallPickedUp,
                "call_successful" => ChartShowItemNumericSourceSourceType.CallSuccessful,
                "call_transferred" => ChartShowItemNumericSourceSourceType.CallTransferred,
                "chat_successful" => ChartShowItemNumericSourceSourceType.ChatSuccessful,
                "combined_cost" => ChartShowItemNumericSourceSourceType.CombinedCost,
                "duration_ms" => ChartShowItemNumericSourceSourceType.DurationMs,
                "e2e_latency_p50" => ChartShowItemNumericSourceSourceType.E2eLatencyP50,
                "in_voicemail" => ChartShowItemNumericSourceSourceType.InVoicemail,
                _ => null,
            };
        }
    }
}