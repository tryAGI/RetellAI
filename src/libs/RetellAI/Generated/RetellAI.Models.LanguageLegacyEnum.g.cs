
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum LanguageLegacyEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Multi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageLegacyEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageLegacyEnum value)
        {
            return value switch
            {
                LanguageLegacyEnum.Multi => "multi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageLegacyEnum? ToEnum(string value)
        {
            return value switch
            {
                "multi" => LanguageLegacyEnum.Multi,
                _ => null,
            };
        }
    }
}