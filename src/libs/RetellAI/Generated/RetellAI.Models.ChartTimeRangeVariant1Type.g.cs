
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartTimeRangeVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Last,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartTimeRangeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartTimeRangeVariant1Type value)
        {
            return value switch
            {
                ChartTimeRangeVariant1Type.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartTimeRangeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "last" => ChartTimeRangeVariant1Type.Last,
                _ => null,
            };
        }
    }
}