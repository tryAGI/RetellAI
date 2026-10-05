
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputSelectionVariant1Mode
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputSelectionVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputSelectionVariant1Mode value)
        {
            return value switch
            {
                OutputSelectionVariant1Mode.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputSelectionVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "all" => OutputSelectionVariant1Mode.All,
                _ => null,
            };
        }
    }
}