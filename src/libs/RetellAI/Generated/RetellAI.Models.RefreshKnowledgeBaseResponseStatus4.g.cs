
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RefreshKnowledgeBaseResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RefreshKnowledgeBaseResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefreshKnowledgeBaseResponseStatus4 value)
        {
            return value switch
            {
                RefreshKnowledgeBaseResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RefreshKnowledgeBaseResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => RefreshKnowledgeBaseResponseStatus4.Error,
                _ => null,
            };
        }
    }
}