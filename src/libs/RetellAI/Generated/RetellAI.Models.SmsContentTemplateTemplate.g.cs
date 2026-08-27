
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The template to use for the SMS content. "info_collection" sends a predefined message requesting information from the user.
    /// </summary>
    public enum SmsContentTemplateTemplate
    {
        /// <summary>
        ///
        /// </summary>
        InfoCollection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsContentTemplateTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsContentTemplateTemplate value)
        {
            return value switch
            {
                SmsContentTemplateTemplate.InfoCollection => "info_collection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsContentTemplateTemplate? ToEnum(string value)
        {
            return value switch
            {
                "info_collection" => SmsContentTemplateTemplate.InfoCollection,
                _ => null,
            };
        }
    }
}