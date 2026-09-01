
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChartShowItemCustomFieldSourceSourceType
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
    public static class ChartShowItemCustomFieldSourceSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartShowItemCustomFieldSourceSourceType value)
        {
            return value switch
            {
                ChartShowItemCustomFieldSourceSourceType.CustomAnalysisData => "custom_analysis_data",
                ChartShowItemCustomFieldSourceSourceType.CustomAttribute => "custom_attribute",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartShowItemCustomFieldSourceSourceType? ToEnum(string value)
        {
            return value switch
            {
                "custom_analysis_data" => ChartShowItemCustomFieldSourceSourceType.CustomAnalysisData,
                "custom_attribute" => ChartShowItemCustomFieldSourceSourceType.CustomAttribute,
                _ => null,
            };
        }
    }
}