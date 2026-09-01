
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartConfigType
    {
        /// <summary>
        ///
        /// </summary>
        Bar,
        /// <summary>
        ///
        /// </summary>
        Column,
        /// <summary>
        ///
        /// </summary>
        Donut,
        /// <summary>
        ///
        /// </summary>
        Line,
        /// <summary>
        ///
        /// </summary>
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartConfigType value)
        {
            return value switch
            {
                ChartConfigType.Bar => "bar",
                ChartConfigType.Column => "column",
                ChartConfigType.Donut => "donut",
                ChartConfigType.Line => "line",
                ChartConfigType.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartConfigType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => ChartConfigType.Bar,
                "column" => ChartConfigType.Column,
                "donut" => ChartConfigType.Donut,
                "line" => ChartConfigType.Line,
                "number" => ChartConfigType.Number,
                _ => null,
            };
        }
    }
}