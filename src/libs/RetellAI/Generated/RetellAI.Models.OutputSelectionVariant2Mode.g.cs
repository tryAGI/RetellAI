
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputSelectionVariant2Mode
    {
        /// <summary>
        ///
        /// </summary>
        Subset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputSelectionVariant2ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputSelectionVariant2Mode value)
        {
            return value switch
            {
                OutputSelectionVariant2Mode.Subset => "subset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputSelectionVariant2Mode? ToEnum(string value)
        {
            return value switch
            {
                "subset" => OutputSelectionVariant2Mode.Subset,
                _ => null,
            };
        }
    }
}