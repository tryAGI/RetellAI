
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PublishAgentVersionResponseStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishAgentVersionResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishAgentVersionResponseStatus2 value)
        {
            return value switch
            {
                PublishAgentVersionResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishAgentVersionResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => PublishAgentVersionResponseStatus2.Error,
                _ => null,
            };
        }
    }
}