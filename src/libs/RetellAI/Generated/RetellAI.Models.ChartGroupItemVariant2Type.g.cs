
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartGroupItemVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        CustomAnalysisData,
        /// <summary>
        ///
        /// </summary>
        CustomAttribute,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartGroupItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartGroupItemVariant2Type value)
        {
            return value switch
            {
                ChartGroupItemVariant2Type.CustomAnalysisData => "custom_analysis_data",
                ChartGroupItemVariant2Type.CustomAttribute => "custom_attribute",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartGroupItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom_analysis_data" => ChartGroupItemVariant2Type.CustomAnalysisData,
                "custom_attribute" => ChartGroupItemVariant2Type.CustomAttribute,
                _ => null,
            };
        }
    }
}