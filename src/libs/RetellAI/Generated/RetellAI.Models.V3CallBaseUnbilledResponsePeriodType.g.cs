
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The engine that ran during the span. A span is split where an agent swap changes the engine. `cascading` credits LLM and TTS time, `s2s` credits the realtime model's time, and `duplex` credits only the backend model's time, because the duplex voice model is still billed in full. Absent when the engine is not known.<br/>
    /// Example: cascading
    /// </summary>
    public enum V3CallBaseUnbilledResponsePeriodType
    {
        /// <summary>
        ///
        /// </summary>
        Cascading,
        /// <summary>
        ///
        /// </summary>
        Duplex,
        /// <summary>
        ///
        /// </summary>
        S2s,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V3CallBaseUnbilledResponsePeriodTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V3CallBaseUnbilledResponsePeriodType value)
        {
            return value switch
            {
                V3CallBaseUnbilledResponsePeriodType.Cascading => "cascading",
                V3CallBaseUnbilledResponsePeriodType.Duplex => "duplex",
                V3CallBaseUnbilledResponsePeriodType.S2s => "s2s",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V3CallBaseUnbilledResponsePeriodType? ToEnum(string value)
        {
            return value switch
            {
                "cascading" => V3CallBaseUnbilledResponsePeriodType.Cascading,
                "duplex" => V3CallBaseUnbilledResponsePeriodType.Duplex,
                "s2s" => V3CallBaseUnbilledResponsePeriodType.S2s,
                _ => null,
            };
        }
    }
}