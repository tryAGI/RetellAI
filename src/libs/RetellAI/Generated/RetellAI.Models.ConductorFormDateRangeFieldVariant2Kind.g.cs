
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConductorFormDateRangeFieldVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        DateRange,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorFormDateRangeFieldVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorFormDateRangeFieldVariant2Kind value)
        {
            return value switch
            {
                ConductorFormDateRangeFieldVariant2Kind.DateRange => "dateRange",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorFormDateRangeFieldVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "dateRange" => ConductorFormDateRangeFieldVariant2Kind.DateRange,
                _ => null,
            };
        }
    }
}