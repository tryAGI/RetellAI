
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConductorOverageConfigVariant2Mode
    {
        /// <summary>
        ///
        /// </summary>
        Unlimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorOverageConfigVariant2ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorOverageConfigVariant2Mode value)
        {
            return value switch
            {
                ConductorOverageConfigVariant2Mode.Unlimited => "unlimited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorOverageConfigVariant2Mode? ToEnum(string value)
        {
            return value switch
            {
                "unlimited" => ConductorOverageConfigVariant2Mode.Unlimited,
                _ => null,
            };
        }
    }
}