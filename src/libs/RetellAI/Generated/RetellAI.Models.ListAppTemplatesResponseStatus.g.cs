
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ListAppTemplatesResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAppTemplatesResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAppTemplatesResponseStatus value)
        {
            return value switch
            {
                ListAppTemplatesResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAppTemplatesResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListAppTemplatesResponseStatus.Error,
                _ => null,
            };
        }
    }
}