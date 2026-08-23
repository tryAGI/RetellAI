
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeBaseAppUsageType
    {
        /// <summary>
        /// 
        /// </summary>
        KnowledgeBase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseAppUsageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseAppUsageType value)
        {
            return value switch
            {
                KnowledgeBaseAppUsageType.KnowledgeBase => "knowledge_base",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseAppUsageType? ToEnum(string value)
        {
            return value switch
            {
                "knowledge_base" => KnowledgeBaseAppUsageType.KnowledgeBase,
                _ => null,
            };
        }
    }
}