
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SmsContentTemplateType
    {
        /// <summary>
        /// 
        /// </summary>
        Template,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsContentTemplateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsContentTemplateType value)
        {
            return value switch
            {
                SmsContentTemplateType.Template => "template",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsContentTemplateType? ToEnum(string value)
        {
            return value switch
            {
                "template" => SmsContentTemplateType.Template,
                _ => null,
            };
        }
    }
}