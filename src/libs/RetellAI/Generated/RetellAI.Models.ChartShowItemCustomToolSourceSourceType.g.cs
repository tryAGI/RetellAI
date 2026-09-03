
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Latency is milliseconds; success rate is a ratio from 0 to 1.
    /// </summary>
    public enum ChartShowItemCustomToolSourceSourceType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolLatency,
        /// <summary>
        ///
        /// </summary>
        CustomToolSuccessRate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartShowItemCustomToolSourceSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartShowItemCustomToolSourceSourceType value)
        {
            return value switch
            {
                ChartShowItemCustomToolSourceSourceType.CustomToolLatency => "custom_tool_latency",
                ChartShowItemCustomToolSourceSourceType.CustomToolSuccessRate => "custom_tool_success_rate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartShowItemCustomToolSourceSourceType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_latency" => ChartShowItemCustomToolSourceSourceType.CustomToolLatency,
                "custom_tool_success_rate" => ChartShowItemCustomToolSourceSourceType.CustomToolSuccessRate,
                _ => null,
            };
        }
    }
}