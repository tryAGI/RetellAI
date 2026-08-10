
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatAgentRequestLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Multi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatAgentRequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatAgentRequestLanguage value)
        {
            return value switch
            {
                ChatAgentRequestLanguage.Multi => "multi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatAgentRequestLanguage? ToEnum(string value)
        {
            return value switch
            {
                "multi" => ChatAgentRequestLanguage.Multi,
                _ => null,
            };
        }
    }
}