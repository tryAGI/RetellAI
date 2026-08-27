
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Sort calls by `start_timestamp` in ascending or descending order.<br/>
    /// Default Value: descending
    /// </summary>
    public enum V3ListCallsRequestSortOrder
    {
        /// <summary>
        ///
        /// </summary>
        Ascending,
        /// <summary>
        ///
        /// </summary>
        Descending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V3ListCallsRequestSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V3ListCallsRequestSortOrder value)
        {
            return value switch
            {
                V3ListCallsRequestSortOrder.Ascending => "ascending",
                V3ListCallsRequestSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V3ListCallsRequestSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => V3ListCallsRequestSortOrder.Ascending,
                "descending" => V3ListCallsRequestSortOrder.Descending,
                _ => null,
            };
        }
    }
}