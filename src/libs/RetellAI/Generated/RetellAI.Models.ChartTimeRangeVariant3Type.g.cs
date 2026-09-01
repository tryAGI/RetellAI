
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartTimeRangeVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        ToDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartTimeRangeVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartTimeRangeVariant3Type value)
        {
            return value switch
            {
                ChartTimeRangeVariant3Type.ToDate => "to_date",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartTimeRangeVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "to_date" => ChartTimeRangeVariant3Type.ToDate,
                _ => null,
            };
        }
    }
}