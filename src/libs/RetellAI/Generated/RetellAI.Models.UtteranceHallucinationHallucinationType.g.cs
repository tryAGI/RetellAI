
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Type of hallucination detected.
    /// </summary>
    public enum UtteranceHallucinationHallucinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Confusion,
        /// <summary>
        /// 
        /// </summary>
        Contradiction,
        /// <summary>
        /// 
        /// </summary>
        Fabrication,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UtteranceHallucinationHallucinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UtteranceHallucinationHallucinationType value)
        {
            return value switch
            {
                UtteranceHallucinationHallucinationType.Confusion => "Confusion",
                UtteranceHallucinationHallucinationType.Contradiction => "Contradiction",
                UtteranceHallucinationHallucinationType.Fabrication => "Fabrication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UtteranceHallucinationHallucinationType? ToEnum(string value)
        {
            return value switch
            {
                "Confusion" => UtteranceHallucinationHallucinationType.Confusion,
                "Contradiction" => UtteranceHallucinationHallucinationType.Contradiction,
                "Fabrication" => UtteranceHallucinationHallucinationType.Fabrication,
                _ => null,
            };
        }
    }
}