
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListExportRequestsSortOrder
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
    public static class ListExportRequestsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExportRequestsSortOrder value)
        {
            return value switch
            {
                ListExportRequestsSortOrder.Ascending => "ascending",
                ListExportRequestsSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExportRequestsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListExportRequestsSortOrder.Ascending,
                "descending" => ListExportRequestsSortOrder.Descending,
                _ => null,
            };
        }
    }
}