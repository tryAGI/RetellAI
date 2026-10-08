
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Type of model choice
    /// </summary>
    public enum ModelChoiceS2SType
    {
        /// <summary>
        ///
        /// </summary>
        S2s,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelChoiceS2STypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelChoiceS2SType value)
        {
            return value switch
            {
                ModelChoiceS2SType.S2s => "s2s",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelChoiceS2SType? ToEnum(string value)
        {
            return value switch
            {
                "s2s" => ModelChoiceS2SType.S2s,
                _ => null,
            };
        }
    }
}