
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Balance between speed and accuracy. Fast optimizes for speed using the provider configuration, accurate optimizes for accuracy using the provider configuration, and custom uses custom_stt_config.
    /// </summary>
    public enum AgentOverrideConfigSttMode
    {
        /// <summary>
        ///
        /// </summary>
        Accurate,
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentOverrideConfigSttModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentOverrideConfigSttMode value)
        {
            return value switch
            {
                AgentOverrideConfigSttMode.Accurate => "accurate",
                AgentOverrideConfigSttMode.Custom => "custom",
                AgentOverrideConfigSttMode.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentOverrideConfigSttMode? ToEnum(string value)
        {
            return value switch
            {
                "accurate" => AgentOverrideConfigSttMode.Accurate,
                "custom" => AgentOverrideConfigSttMode.Custom,
                "fast" => AgentOverrideConfigSttMode.Fast,
                _ => null,
            };
        }
    }
}