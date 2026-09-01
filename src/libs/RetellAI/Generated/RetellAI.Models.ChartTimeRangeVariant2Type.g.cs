
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartTimeRangeVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Since,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartTimeRangeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartTimeRangeVariant2Type value)
        {
            return value switch
            {
                ChartTimeRangeVariant2Type.Since => "since",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartTimeRangeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "since" => ChartTimeRangeVariant2Type.Since,
                _ => null,
            };
        }
    }
}