
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConductorFormSwitchFieldVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Switch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorFormSwitchFieldVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorFormSwitchFieldVariant2Kind value)
        {
            return value switch
            {
                ConductorFormSwitchFieldVariant2Kind.Switch => "switch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorFormSwitchFieldVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "switch" => ConductorFormSwitchFieldVariant2Kind.Switch,
                _ => null,
            };
        }
    }
}