
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// `count` counts non-null values; other options aggregate the values.
    /// </summary>
    public enum ChartShowItemNumericSourceMeasurementType
    {
        /// <summary>
        ///
        /// </summary>
        Avg,
        /// <summary>
        ///
        /// </summary>
        Count,
        /// <summary>
        ///
        /// </summary>
        Max,
        /// <summary>
        ///
        /// </summary>
        Median,
        /// <summary>
        ///
        /// </summary>
        Min,
        /// <summary>
        ///
        /// </summary>
        P90,
        /// <summary>
        ///
        /// </summary>
        Sum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartShowItemNumericSourceMeasurementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartShowItemNumericSourceMeasurementType value)
        {
            return value switch
            {
                ChartShowItemNumericSourceMeasurementType.Avg => "avg",
                ChartShowItemNumericSourceMeasurementType.Count => "count",
                ChartShowItemNumericSourceMeasurementType.Max => "max",
                ChartShowItemNumericSourceMeasurementType.Median => "median",
                ChartShowItemNumericSourceMeasurementType.Min => "min",
                ChartShowItemNumericSourceMeasurementType.P90 => "p90",
                ChartShowItemNumericSourceMeasurementType.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartShowItemNumericSourceMeasurementType? ToEnum(string value)
        {
            return value switch
            {
                "avg" => ChartShowItemNumericSourceMeasurementType.Avg,
                "count" => ChartShowItemNumericSourceMeasurementType.Count,
                "max" => ChartShowItemNumericSourceMeasurementType.Max,
                "median" => ChartShowItemNumericSourceMeasurementType.Median,
                "min" => ChartShowItemNumericSourceMeasurementType.Min,
                "p90" => ChartShowItemNumericSourceMeasurementType.P90,
                "sum" => ChartShowItemNumericSourceMeasurementType.Sum,
                _ => null,
            };
        }
    }
}