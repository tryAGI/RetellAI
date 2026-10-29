
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RefreshKnowledgeBaseResponseStatus3
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RefreshKnowledgeBaseResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefreshKnowledgeBaseResponseStatus3 value)
        {
            return value switch
            {
                RefreshKnowledgeBaseResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RefreshKnowledgeBaseResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => RefreshKnowledgeBaseResponseStatus3.Error,
                _ => null,
            };
        }
    }
}