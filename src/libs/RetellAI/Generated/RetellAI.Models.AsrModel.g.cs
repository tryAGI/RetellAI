
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// STT model to pin for the custom provider. Deepgram offers nova-3 (Nova 3); vocab_specialization medical still selects Deepgram's medical model for English. Soniox offers stt-rt-v6 (Soniox v6) and stt-rt-v5 (Soniox v5). AssemblyAI offers universal-3-6-pro (Universal 3.6 Pro) and assemblyai-stt-3-7-realtime-agent (AssemblyAI 3.7 Agent). Azure offers azure-speech (Azure AI Speech). Omit to use the provider's default model.
    /// </summary>
    public enum AsrModel
    {
        /// <summary>
        ///
        /// </summary>
        AssemblyaiStt37RealtimeAgent,
        /// <summary>
        ///
        /// </summary>
        AzureSpeech,
        /// <summary>
        ///
        /// </summary>
        Nova3,
        /// <summary>
        ///
        /// </summary>
        SttRtV5,
        /// <summary>
        ///
        /// </summary>
        SttRtV6,
        /// <summary>
        ///
        /// </summary>
        Universal36Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsrModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsrModel value)
        {
            return value switch
            {
                AsrModel.AssemblyaiStt37RealtimeAgent => "assemblyai-stt-3-7-realtime-agent",
                AsrModel.AzureSpeech => "azure-speech",
                AsrModel.Nova3 => "nova-3",
                AsrModel.SttRtV5 => "stt-rt-v5",
                AsrModel.SttRtV6 => "stt-rt-v6",
                AsrModel.Universal36Pro => "universal-3-6-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsrModel? ToEnum(string value)
        {
            return value switch
            {
                "assemblyai-stt-3-7-realtime-agent" => AsrModel.AssemblyaiStt37RealtimeAgent,
                "azure-speech" => AsrModel.AzureSpeech,
                "nova-3" => AsrModel.Nova3,
                "stt-rt-v5" => AsrModel.SttRtV5,
                "stt-rt-v6" => AsrModel.SttRtV6,
                "universal-3-6-pro" => AsrModel.Universal36Pro,
                _ => null,
            };
        }
    }
}