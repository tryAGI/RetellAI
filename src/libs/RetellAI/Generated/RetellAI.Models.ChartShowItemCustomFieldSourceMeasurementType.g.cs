
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// `count` works for any value; other options require numeric or castable values.
    /// </summary>
    public enum ChartShowItemCustomFieldSourceMeasurementType
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
    public static class ChartShowItemCustomFieldSourceMeasurementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartShowItemCustomFieldSourceMeasurementType value)
        {
            return value switch
            {
                ChartShowItemCustomFieldSourceMeasurementType.Avg => "avg",
                ChartShowItemCustomFieldSourceMeasurementType.Count => "count",
                ChartShowItemCustomFieldSourceMeasurementType.Max => "max",
                ChartShowItemCustomFieldSourceMeasurementType.Median => "median",
                ChartShowItemCustomFieldSourceMeasurementType.Min => "min",
                ChartShowItemCustomFieldSourceMeasurementType.P90 => "p90",
                ChartShowItemCustomFieldSourceMeasurementType.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartShowItemCustomFieldSourceMeasurementType? ToEnum(string value)
        {
            return value switch
            {
                "avg" => ChartShowItemCustomFieldSourceMeasurementType.Avg,
                "count" => ChartShowItemCustomFieldSourceMeasurementType.Count,
                "max" => ChartShowItemCustomFieldSourceMeasurementType.Max,
                "median" => ChartShowItemCustomFieldSourceMeasurementType.Median,
                "min" => ChartShowItemCustomFieldSourceMeasurementType.Min,
                "p90" => ChartShowItemCustomFieldSourceMeasurementType.P90,
                "sum" => ChartShowItemCustomFieldSourceMeasurementType.Sum,
                _ => null,
            };
        }
    }
}