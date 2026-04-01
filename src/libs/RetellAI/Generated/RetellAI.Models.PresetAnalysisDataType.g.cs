
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Identifies this item as a system preset.
    /// </summary>
    public enum PresetAnalysisDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SystemPresets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PresetAnalysisDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PresetAnalysisDataType value)
        {
            return value switch
            {
                PresetAnalysisDataType.SystemPresets => "system-presets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PresetAnalysisDataType? ToEnum(string value)
        {
            return value switch
            {
                "system-presets" => PresetAnalysisDataType.SystemPresets,
                _ => null,
            };
        }
    }
}