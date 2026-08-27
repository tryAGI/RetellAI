
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The template to use for the instruction. "info_collection" sends a predefined message requesting information from the user.
    /// </summary>
    public enum SmsInstructionTemplateTemplate
    {
        /// <summary>
        ///
        /// </summary>
        InfoCollection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsInstructionTemplateTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsInstructionTemplateTemplate value)
        {
            return value switch
            {
                SmsInstructionTemplateTemplate.InfoCollection => "info_collection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsInstructionTemplateTemplate? ToEnum(string value)
        {
            return value switch
            {
                "info_collection" => SmsInstructionTemplateTemplate.InfoCollection,
                _ => null,
            };
        }
    }
}