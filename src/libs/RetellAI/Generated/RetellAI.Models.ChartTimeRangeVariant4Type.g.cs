
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartTimeRangeVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartTimeRangeVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartTimeRangeVariant4Type value)
        {
            return value switch
            {
                ChartTimeRangeVariant4Type.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartTimeRangeVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => ChartTimeRangeVariant4Type.Fixed,
                _ => null,
            };
        }
    }
}