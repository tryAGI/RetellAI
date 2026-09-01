
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartShowItemCustomToolSourceMeasurementType
    {
        /// <summary>
        ///
        /// </summary>
        Avg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartShowItemCustomToolSourceMeasurementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartShowItemCustomToolSourceMeasurementType value)
        {
            return value switch
            {
                ChartShowItemCustomToolSourceMeasurementType.Avg => "avg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartShowItemCustomToolSourceMeasurementType? ToEnum(string value)
        {
            return value switch
            {
                "avg" => ChartShowItemCustomToolSourceMeasurementType.Avg,
                _ => null,
            };
        }
    }
}