
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Identifies this item as a system preset.
    /// </summary>
    public enum ChatPresetAnalysisDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SystemPresets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatPresetAnalysisDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatPresetAnalysisDataType value)
        {
            return value switch
            {
                ChatPresetAnalysisDataType.SystemPresets => "system-presets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatPresetAnalysisDataType? ToEnum(string value)
        {
            return value switch
            {
                "system-presets" => ChatPresetAnalysisDataType.SystemPresets,
                _ => null,
            };
        }
    }
}