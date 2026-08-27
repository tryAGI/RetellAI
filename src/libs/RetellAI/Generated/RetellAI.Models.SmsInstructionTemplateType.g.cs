
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Type of instruction
    /// </summary>
    public enum SmsInstructionTemplateType
    {
        /// <summary>
        ///
        /// </summary>
        Template,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsInstructionTemplateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsInstructionTemplateType value)
        {
            return value switch
            {
                SmsInstructionTemplateType.Template => "template",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsInstructionTemplateType? ToEnum(string value)
        {
            return value switch
            {
                "template" => SmsInstructionTemplateType.Template,
                _ => null,
            };
        }
    }
}