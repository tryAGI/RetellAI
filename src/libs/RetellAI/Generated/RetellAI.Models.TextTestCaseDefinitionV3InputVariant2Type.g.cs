
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The agent and the simulated caller talk in text.
    /// </summary>
    public enum TextTestCaseDefinitionV3InputVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextTestCaseDefinitionV3InputVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextTestCaseDefinitionV3InputVariant2Type value)
        {
            return value switch
            {
                TextTestCaseDefinitionV3InputVariant2Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextTestCaseDefinitionV3InputVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => TextTestCaseDefinitionV3InputVariant2Type.Text,
                _ => null,
            };
        }
    }
}