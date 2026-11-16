
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConductorFormSelectFieldVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Select,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorFormSelectFieldVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorFormSelectFieldVariant2Kind value)
        {
            return value switch
            {
                ConductorFormSelectFieldVariant2Kind.Select => "select",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorFormSelectFieldVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "select" => ConductorFormSelectFieldVariant2Kind.Select,
                _ => null,
            };
        }
    }
}