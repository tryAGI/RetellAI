
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Checks that the answer is a valid email or URL.
    /// </summary>
    public enum ConductorFormTextFieldVariant2Format
    {
        /// <summary>
        ///
        /// </summary>
        Email,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorFormTextFieldVariant2FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorFormTextFieldVariant2Format value)
        {
            return value switch
            {
                ConductorFormTextFieldVariant2Format.Email => "email",
                ConductorFormTextFieldVariant2Format.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorFormTextFieldVariant2Format? ToEnum(string value)
        {
            return value switch
            {
                "email" => ConductorFormTextFieldVariant2Format.Email,
                "url" => ConductorFormTextFieldVariant2Format.Url,
                _ => null,
            };
        }
    }
}