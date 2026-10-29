
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RefreshKnowledgeBaseResponseStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RefreshKnowledgeBaseResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefreshKnowledgeBaseResponseStatus2 value)
        {
            return value switch
            {
                RefreshKnowledgeBaseResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RefreshKnowledgeBaseResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => RefreshKnowledgeBaseResponseStatus2.Error,
                _ => null,
            };
        }
    }
}