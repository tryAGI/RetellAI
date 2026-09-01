
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartConfigSizeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Large,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Small,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartConfigSizeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartConfigSizeEnum value)
        {
            return value switch
            {
                ChartConfigSizeEnum.Large => "large",
                ChartConfigSizeEnum.Medium => "medium",
                ChartConfigSizeEnum.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartConfigSizeEnum? ToEnum(string value)
        {
            return value switch
            {
                "large" => ChartConfigSizeEnum.Large,
                "medium" => ChartConfigSizeEnum.Medium,
                "small" => ChartConfigSizeEnum.Small,
                _ => null,
            };
        }
    }
}