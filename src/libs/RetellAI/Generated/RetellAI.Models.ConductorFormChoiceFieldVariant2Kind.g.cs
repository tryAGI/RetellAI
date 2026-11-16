
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConductorFormChoiceFieldVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorFormChoiceFieldVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorFormChoiceFieldVariant2Kind value)
        {
            return value switch
            {
                ConductorFormChoiceFieldVariant2Kind.Choice => "choice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorFormChoiceFieldVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "choice" => ConductorFormChoiceFieldVariant2Kind.Choice,
                _ => null,
            };
        }
    }
}