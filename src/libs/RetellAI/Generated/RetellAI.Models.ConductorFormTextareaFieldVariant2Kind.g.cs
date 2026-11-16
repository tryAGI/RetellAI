
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConductorFormTextareaFieldVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Textarea,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorFormTextareaFieldVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorFormTextareaFieldVariant2Kind value)
        {
            return value switch
            {
                ConductorFormTextareaFieldVariant2Kind.Textarea => "textarea",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorFormTextareaFieldVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "textarea" => ConductorFormTextareaFieldVariant2Kind.Textarea,
                _ => null,
            };
        }
    }
}