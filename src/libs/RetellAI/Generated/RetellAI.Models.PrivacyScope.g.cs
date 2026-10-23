
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Privacy scope of an integration function.
    /// </summary>
    public enum PrivacyScope
    {
        /// <summary>
        ///
        /// </summary>
        Pci,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivacyScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivacyScope value)
        {
            return value switch
            {
                PrivacyScope.Pci => "pci",
                PrivacyScope.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivacyScope? ToEnum(string value)
        {
            return value switch
            {
                "pci" => PrivacyScope.Pci,
                "standard" => PrivacyScope.Standard,
                _ => null,
            };
        }
    }
}