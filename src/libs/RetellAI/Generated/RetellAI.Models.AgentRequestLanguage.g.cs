
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentRequestLanguage
    {
        /// <summary>
        ///
        /// </summary>
        Multi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestLanguage value)
        {
            return value switch
            {
                AgentRequestLanguage.Multi => "multi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestLanguage? ToEnum(string value)
        {
            return value switch
            {
                "multi" => AgentRequestLanguage.Multi,
                _ => null,
            };
        }
    }
}