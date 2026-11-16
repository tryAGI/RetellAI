
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConductorFormNumberFieldVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorFormNumberFieldVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorFormNumberFieldVariant2Kind value)
        {
            return value switch
            {
                ConductorFormNumberFieldVariant2Kind.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorFormNumberFieldVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "number" => ConductorFormNumberFieldVariant2Kind.Number,
                _ => null,
            };
        }
    }
}