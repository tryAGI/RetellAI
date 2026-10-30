
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Runs a full-duplex voice model with a cascading backend.
    /// </summary>
    public enum DuplexModelConfigType
    {
        /// <summary>
        ///
        /// </summary>
        Duplex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DuplexModelConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DuplexModelConfigType value)
        {
            return value switch
            {
                DuplexModelConfigType.Duplex => "duplex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DuplexModelConfigType? ToEnum(string value)
        {
            return value switch
            {
                "duplex" => DuplexModelConfigType.Duplex,
                _ => null,
            };
        }
    }
}