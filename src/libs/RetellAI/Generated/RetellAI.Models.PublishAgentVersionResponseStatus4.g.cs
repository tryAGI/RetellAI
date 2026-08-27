
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PublishAgentVersionResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishAgentVersionResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishAgentVersionResponseStatus4 value)
        {
            return value switch
            {
                PublishAgentVersionResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishAgentVersionResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => PublishAgentVersionResponseStatus4.Error,
                _ => null,
            };
        }
    }
}