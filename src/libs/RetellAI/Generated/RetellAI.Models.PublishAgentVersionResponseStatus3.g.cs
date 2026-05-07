
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublishAgentVersionResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishAgentVersionResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishAgentVersionResponseStatus3 value)
        {
            return value switch
            {
                PublishAgentVersionResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishAgentVersionResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => PublishAgentVersionResponseStatus3.Error,
                _ => null,
            };
        }
    }
}