
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Runs a speech-to-speech model.
    /// </summary>
    public enum S2SModelConfigType
    {
        /// <summary>
        ///
        /// </summary>
        S2s,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class S2SModelConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this S2SModelConfigType value)
        {
            return value switch
            {
                S2SModelConfigType.S2s => "s2s",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static S2SModelConfigType? ToEnum(string value)
        {
            return value switch
            {
                "s2s" => S2SModelConfigType.S2s,
                _ => null,
            };
        }
    }
}