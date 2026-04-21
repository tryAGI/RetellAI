
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Sort calls by `start_timestamp` in ascending or descending order.<br/>
    /// Default Value: descending
    /// </summary>
    public enum ListCallsV3RequestSortOrder
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
    public static class ListCallsV3RequestSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCallsV3RequestSortOrder value)
        {
            return value switch
            {
                ListCallsV3RequestSortOrder.Ascending => "ascending",
                ListCallsV3RequestSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCallsV3RequestSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListCallsV3RequestSortOrder.Ascending,
                "descending" => ListCallsV3RequestSortOrder.Descending,
                _ => null,
            };
        }
    }
}