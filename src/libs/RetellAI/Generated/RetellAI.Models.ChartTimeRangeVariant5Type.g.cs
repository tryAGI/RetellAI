
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartTimeRangeVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartTimeRangeVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartTimeRangeVariant5Type value)
        {
            return value switch
            {
                ChartTimeRangeVariant5Type.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartTimeRangeVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "all" => ChartTimeRangeVariant5Type.All,
                _ => null,
            };
        }
    }
}