
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartTimeRangeVariant3Unit
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
    public static class ChartTimeRangeVariant3UnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartTimeRangeVariant3Unit value)
        {
            return value switch
            {
                ChartTimeRangeVariant3Unit.Day => "day",
                ChartTimeRangeVariant3Unit.Month => "month",
                ChartTimeRangeVariant3Unit.Week => "week",
                ChartTimeRangeVariant3Unit.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartTimeRangeVariant3Unit? ToEnum(string value)
        {
            return value switch
            {
                "day" => ChartTimeRangeVariant3Unit.Day,
                "month" => ChartTimeRangeVariant3Unit.Month,
                "week" => ChartTimeRangeVariant3Unit.Week,
                "year" => ChartTimeRangeVariant3Unit.Year,
                _ => null,
            };
        }
    }
}