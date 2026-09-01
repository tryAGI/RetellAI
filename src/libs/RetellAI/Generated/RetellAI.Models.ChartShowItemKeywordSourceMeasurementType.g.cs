
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartShowItemKeywordSourceMeasurementType
    {
        /// <summary>
        ///
        /// </summary>
        Count,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartShowItemKeywordSourceMeasurementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartShowItemKeywordSourceMeasurementType value)
        {
            return value switch
            {
                ChartShowItemKeywordSourceMeasurementType.Count => "count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartShowItemKeywordSourceMeasurementType? ToEnum(string value)
        {
            return value switch
            {
                "count" => ChartShowItemKeywordSourceMeasurementType.Count,
                _ => null,
            };
        }
    }
}