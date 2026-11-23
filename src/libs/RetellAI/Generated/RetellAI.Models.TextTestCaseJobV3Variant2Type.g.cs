
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TextTestCaseJobV3Variant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextTestCaseJobV3Variant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextTestCaseJobV3Variant2Type value)
        {
            return value switch
            {
                TextTestCaseJobV3Variant2Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextTestCaseJobV3Variant2Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => TextTestCaseJobV3Variant2Type.Text,
                _ => null,
            };
        }
    }
}