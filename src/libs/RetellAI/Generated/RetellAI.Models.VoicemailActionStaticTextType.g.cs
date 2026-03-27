
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Example: static_text
    /// </summary>
    public enum VoicemailActionStaticTextType
    {
        /// <summary>
        /// 
        /// </summary>
        StaticText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicemailActionStaticTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicemailActionStaticTextType value)
        {
            return value switch
            {
                VoicemailActionStaticTextType.StaticText => "static_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicemailActionStaticTextType? ToEnum(string value)
        {
            return value switch
            {
                "static_text" => VoicemailActionStaticTextType.StaticText,
                _ => null,
            };
        }
    }
}