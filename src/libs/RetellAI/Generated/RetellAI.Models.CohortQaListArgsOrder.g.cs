
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Sort order. Defaults to "desc".
    /// </summary>
    public enum CohortQaListArgsOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CohortQaListArgsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CohortQaListArgsOrder value)
        {
            return value switch
            {
                CohortQaListArgsOrder.Asc => "asc",
                CohortQaListArgsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CohortQaListArgsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => CohortQaListArgsOrder.Asc,
                "desc" => CohortQaListArgsOrder.Desc,
                _ => null,
            };
        }
    }
}