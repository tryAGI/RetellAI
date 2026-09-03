
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Maximum concurrency in each time bucket.
    /// </summary>
    public enum ChartShowItemConcurrencySourceMeasurementType
    {
        /// <summary>
        ///
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartShowItemConcurrencySourceMeasurementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartShowItemConcurrencySourceMeasurementType value)
        {
            return value switch
            {
                ChartShowItemConcurrencySourceMeasurementType.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartShowItemConcurrencySourceMeasurementType? ToEnum(string value)
        {
            return value switch
            {
                "max" => ChartShowItemConcurrencySourceMeasurementType.Max,
                _ => null,
            };
        }
    }
}