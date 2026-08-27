
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListAgentsSortOrder
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
    public static class ListAgentsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentsSortOrder value)
        {
            return value switch
            {
                ListAgentsSortOrder.Ascending => "ascending",
                ListAgentsSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListAgentsSortOrder.Ascending,
                "descending" => ListAgentsSortOrder.Descending,
                _ => null,
            };
        }
    }
}