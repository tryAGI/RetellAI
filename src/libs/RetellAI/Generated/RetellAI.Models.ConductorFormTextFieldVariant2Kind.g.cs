
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConductorFormTextFieldVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorFormTextFieldVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorFormTextFieldVariant2Kind value)
        {
            return value switch
            {
                ConductorFormTextFieldVariant2Kind.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorFormTextFieldVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "text" => ConductorFormTextFieldVariant2Kind.Text,
                _ => null,
            };
        }
    }
}