
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Number of calls active at the same time.
    /// </summary>
    public enum ChartShowItemConcurrencySourceSourceType
    {
        /// <summary>
        ///
        /// </summary>
        CallConcurrency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartShowItemConcurrencySourceSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartShowItemConcurrencySourceSourceType value)
        {
            return value switch
            {
                ChartShowItemConcurrencySourceSourceType.CallConcurrency => "call_concurrency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartShowItemConcurrencySourceSourceType? ToEnum(string value)
        {
            return value switch
            {
                "call_concurrency" => ChartShowItemConcurrencySourceSourceType.CallConcurrency,
                _ => null,
            };
        }
    }
}