
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The speech-to-speech model to use
    /// </summary>
    public enum NullableS2SModel
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
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NullableS2SModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableS2SModel value)
        {
            return value switch
            {
                NullableS2SModel.GptRealtime => "gpt-realtime",
                NullableS2SModel.GptRealtime15 => "gpt-realtime-1.5",
                NullableS2SModel.GptRealtime2 => "gpt-realtime-2",
                NullableS2SModel.GptRealtime21 => "gpt-realtime-2.1",
                NullableS2SModel.GptRealtime21Mini => "gpt-realtime-2.1-mini",
                NullableS2SModel.GptRealtimeMini => "gpt-realtime-mini",
                NullableS2SModel.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableS2SModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-realtime" => NullableS2SModel.GptRealtime,
                "gpt-realtime-1.5" => NullableS2SModel.GptRealtime15,
                "gpt-realtime-2" => NullableS2SModel.GptRealtime2,
                "gpt-realtime-2.1" => NullableS2SModel.GptRealtime21,
                "gpt-realtime-2.1-mini" => NullableS2SModel.GptRealtime21Mini,
                "gpt-realtime-mini" => NullableS2SModel.GptRealtimeMini,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => NullableS2SModel.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}