
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConductorFormTimeFieldVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Time,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorFormTimeFieldVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorFormTimeFieldVariant2Kind value)
        {
            return value switch
            {
                ConductorFormTimeFieldVariant2Kind.Time => "time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorFormTimeFieldVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "time" => ConductorFormTimeFieldVariant2Kind.Time,
                _ => null,
            };
        }
    }
}