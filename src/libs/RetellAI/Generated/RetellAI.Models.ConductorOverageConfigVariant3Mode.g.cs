
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConductorOverageConfigVariant3Mode
    {
        /// <summary>
        ///
        /// </summary>
        Limited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorOverageConfigVariant3ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorOverageConfigVariant3Mode value)
        {
            return value switch
            {
                ConductorOverageConfigVariant3Mode.Limited => "limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorOverageConfigVariant3Mode? ToEnum(string value)
        {
            return value switch
            {
                "limited" => ConductorOverageConfigVariant3Mode.Limited,
                _ => null,
            };
        }
    }
}