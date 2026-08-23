
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// App integration category.
    /// </summary>
    public enum AppType
    {
        /// <summary>
        /// 
        /// </summary>
        Calendar,
        /// <summary>
        /// 
        /// </summary>
        Communication,
        /// <summary>
        /// 
        /// </summary>
        Crm,
        /// <summary>
        /// 
        /// </summary>
        KnowledgeBase,
        /// <summary>
        /// 
        /// </summary>
        Support,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppType value)
        {
            return value switch
            {
                AppType.Calendar => "calendar",
                AppType.Communication => "communication",
                AppType.Crm => "crm",
                AppType.KnowledgeBase => "knowledge_base",
                AppType.Support => "support",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppType? ToEnum(string value)
        {
            return value switch
            {
                "calendar" => AppType.Calendar,
                "communication" => AppType.Communication,
                "crm" => AppType.Crm,
                "knowledge_base" => AppType.KnowledgeBase,
                "support" => AppType.Support,
                _ => null,
            };
        }
    }
}