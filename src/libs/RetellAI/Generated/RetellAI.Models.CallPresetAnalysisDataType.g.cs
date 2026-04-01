
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Identifies this item as a system preset.
    /// </summary>
    public enum CallPresetAnalysisDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SystemPresets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallPresetAnalysisDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallPresetAnalysisDataType value)
        {
            return value switch
            {
                CallPresetAnalysisDataType.SystemPresets => "system-presets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallPresetAnalysisDataType? ToEnum(string value)
        {
            return value switch
            {
                "system-presets" => CallPresetAnalysisDataType.SystemPresets,
                _ => null,
            };
        }
    }
}