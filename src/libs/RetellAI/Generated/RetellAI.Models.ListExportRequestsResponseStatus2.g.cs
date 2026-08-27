
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListExportRequestsResponseStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListExportRequestsResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExportRequestsResponseStatus2 value)
        {
            return value switch
            {
                ListExportRequestsResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExportRequestsResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListExportRequestsResponseStatus2.Error,
                _ => null,
            };
        }
    }
}