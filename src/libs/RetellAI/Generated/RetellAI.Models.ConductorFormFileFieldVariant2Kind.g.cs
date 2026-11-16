
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConductorFormFileFieldVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorFormFileFieldVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorFormFileFieldVariant2Kind value)
        {
            return value switch
            {
                ConductorFormFileFieldVariant2Kind.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorFormFileFieldVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "file" => ConductorFormFileFieldVariant2Kind.File,
                _ => null,
            };
        }
    }
}