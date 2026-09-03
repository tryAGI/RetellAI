
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Lookback interval unit.
    /// </summary>
    public enum ChartTimeRangeVariant1WindowUnit
    {
        /// <summary>
        ///
        /// </summary>
        Day,
        /// <summary>
        ///
        /// </summary>
        Month,
        /// <summary>
        ///
        /// </summary>
        Week,
        /// <summary>
        ///
        /// </summary>
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartTimeRangeVariant1WindowUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartTimeRangeVariant1WindowUnit value)
        {
            return value switch
            {
                ChartTimeRangeVariant1WindowUnit.Day => "day",
                ChartTimeRangeVariant1WindowUnit.Month => "month",
                ChartTimeRangeVariant1WindowUnit.Week => "week",
                ChartTimeRangeVariant1WindowUnit.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartTimeRangeVariant1WindowUnit? ToEnum(string value)
        {
            return value switch
            {
                "day" => ChartTimeRangeVariant1WindowUnit.Day,
                "month" => ChartTimeRangeVariant1WindowUnit.Month,
                "week" => ChartTimeRangeVariant1WindowUnit.Week,
                "year" => ChartTimeRangeVariant1WindowUnit.Year,
                _ => null,
            };
        }
    }
}