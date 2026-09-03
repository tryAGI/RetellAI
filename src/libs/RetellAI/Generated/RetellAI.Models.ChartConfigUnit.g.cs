
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Time-bucket size for `line`, `bar`, `column`, and concurrency charts. Defaults to `week` when the calculated range exceeds 30 whole days, `month` for all time, and `day` otherwise.
    /// </summary>
    public enum ChartConfigUnit
    {
        /// <summary>
        ///
        /// </summary>
        Day,
        /// <summary>
        ///
        /// </summary>
        Hour,
        /// <summary>
        ///
        /// </summary>
        Month,
        /// <summary>
        ///
        /// </summary>
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartConfigUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartConfigUnit value)
        {
            return value switch
            {
                ChartConfigUnit.Day => "day",
                ChartConfigUnit.Hour => "hour",
                ChartConfigUnit.Month => "month",
                ChartConfigUnit.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartConfigUnit? ToEnum(string value)
        {
            return value switch
            {
                "day" => ChartConfigUnit.Day,
                "hour" => ChartConfigUnit.Hour,
                "month" => ChartConfigUnit.Month,
                "week" => ChartConfigUnit.Week,
                _ => null,
            };
        }
    }
}