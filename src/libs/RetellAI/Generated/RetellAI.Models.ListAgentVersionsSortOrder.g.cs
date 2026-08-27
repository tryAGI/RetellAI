
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListAgentVersionsSortOrder
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
    public static class ListAgentVersionsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentVersionsSortOrder value)
        {
            return value switch
            {
                ListAgentVersionsSortOrder.Ascending => "ascending",
                ListAgentVersionsSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentVersionsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListAgentVersionsSortOrder.Ascending,
                "descending" => ListAgentVersionsSortOrder.Descending,
                _ => null,
            };
        }
    }
}