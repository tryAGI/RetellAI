
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConductorOverageConfigVariant1Mode
    {
        /// <summary>
        ///
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorOverageConfigVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorOverageConfigVariant1Mode value)
        {
            return value switch
            {
                ConductorOverageConfigVariant1Mode.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorOverageConfigVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "off" => ConductorOverageConfigVariant1Mode.Off,
                _ => null,
            };
        }
    }
}