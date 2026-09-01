
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartShowItemCustomFieldSourceSourceCast
    {
        /// <summary>
        ///
        /// </summary>
        Bool,
        /// <summary>
        ///
        /// </summary>
        Float,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartShowItemCustomFieldSourceSourceCastExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartShowItemCustomFieldSourceSourceCast value)
        {
            return value switch
            {
                ChartShowItemCustomFieldSourceSourceCast.Bool => "bool",
                ChartShowItemCustomFieldSourceSourceCast.Float => "float",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartShowItemCustomFieldSourceSourceCast? ToEnum(string value)
        {
            return value switch
            {
                "bool" => ChartShowItemCustomFieldSourceSourceCast.Bool,
                "float" => ChartShowItemCustomFieldSourceSourceCast.Float,
                _ => null,
            };
        }
    }
}