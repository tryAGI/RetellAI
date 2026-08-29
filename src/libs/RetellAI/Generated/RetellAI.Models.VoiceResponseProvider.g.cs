
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Indicates the provider of voice.<br/>
    /// Example: elevenlabs
    /// </summary>
    public enum VoiceResponseProvider
    {
        /// <summary>
        ///
        /// </summary>
        Cartesia,
        /// <summary>
        ///
        /// </summary>
        Elevenlabs,
        /// <summary>
        ///
        /// </summary>
        FishAudio,
        /// <summary>
        ///
        /// </summary>
        Inworld,
        /// <summary>
        ///
        /// </summary>
        Minimax,
        /// <summary>
        ///
        /// </summary>
        Openai,
        /// <summary>
        ///
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceResponseProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceResponseProvider value)
        {
            return value switch
            {
                VoiceResponseProvider.Cartesia => "cartesia",
                VoiceResponseProvider.Elevenlabs => "elevenlabs",
                VoiceResponseProvider.FishAudio => "fish_audio",
                VoiceResponseProvider.Inworld => "inworld",
                VoiceResponseProvider.Minimax => "minimax",
                VoiceResponseProvider.Openai => "openai",
                VoiceResponseProvider.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceResponseProvider? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => VoiceResponseProvider.Cartesia,
                "elevenlabs" => VoiceResponseProvider.Elevenlabs,
                "fish_audio" => VoiceResponseProvider.FishAudio,
                "inworld" => VoiceResponseProvider.Inworld,
                "minimax" => VoiceResponseProvider.Minimax,
                "openai" => VoiceResponseProvider.Openai,
                "platform" => VoiceResponseProvider.Platform,
                _ => null,
            };
        }
    }
}