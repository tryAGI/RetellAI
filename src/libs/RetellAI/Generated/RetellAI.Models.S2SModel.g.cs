
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The speech-to-speech model to use
    /// </summary>
    public enum S2SModel
    {
        /// <summary>
        ///
        /// </summary>
        GptRealtime,
        /// <summary>
        ///
        /// </summary>
        GptRealtime15,
        /// <summary>
        ///
        /// </summary>
        GptRealtime2,
        /// <summary>
        ///
        /// </summary>
        GptRealtime21,
        /// <summary>
        ///
        /// </summary>
        GptRealtime21Mini,
        /// <summary>
        ///
        /// </summary>
        GptRealtimeMini,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class S2SModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this S2SModel value)
        {
            return value switch
            {
                S2SModel.GptRealtime => "gpt-realtime",
                S2SModel.GptRealtime15 => "gpt-realtime-1.5",
                S2SModel.GptRealtime2 => "gpt-realtime-2",
                S2SModel.GptRealtime21 => "gpt-realtime-2.1",
                S2SModel.GptRealtime21Mini => "gpt-realtime-2.1-mini",
                S2SModel.GptRealtimeMini => "gpt-realtime-mini",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static S2SModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-realtime" => S2SModel.GptRealtime,
                "gpt-realtime-1.5" => S2SModel.GptRealtime15,
                "gpt-realtime-2" => S2SModel.GptRealtime2,
                "gpt-realtime-2.1" => S2SModel.GptRealtime21,
                "gpt-realtime-2.1-mini" => S2SModel.GptRealtime21Mini,
                "gpt-realtime-mini" => S2SModel.GptRealtimeMini,
                _ => null,
            };
        }
    }
}