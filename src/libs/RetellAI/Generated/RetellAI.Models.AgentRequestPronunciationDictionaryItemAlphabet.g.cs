
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The phonetic alphabet to use. MiniMax speech-02-turbo supports IPA and Pinyin. MiniMax speech-2.8-turbo also supports Jyutping. Support for other alphabets depends on the selected voice provider and model.<br/>
    /// Example: ipa
    /// </summary>
    public enum AgentRequestPronunciationDictionaryItemAlphabet
    {
        /// <summary>
        /// 
        /// </summary>
        Cmu,
        /// <summary>
        /// 
        /// </summary>
        Ipa,
        /// <summary>
        /// 
        /// </summary>
        Jyutping,
        /// <summary>
        /// 
        /// </summary>
        Pinyin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRequestPronunciationDictionaryItemAlphabetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestPronunciationDictionaryItemAlphabet value)
        {
            return value switch
            {
                AgentRequestPronunciationDictionaryItemAlphabet.Cmu => "cmu",
                AgentRequestPronunciationDictionaryItemAlphabet.Ipa => "ipa",
                AgentRequestPronunciationDictionaryItemAlphabet.Jyutping => "jyutping",
                AgentRequestPronunciationDictionaryItemAlphabet.Pinyin => "pinyin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestPronunciationDictionaryItemAlphabet? ToEnum(string value)
        {
            return value switch
            {
                "cmu" => AgentRequestPronunciationDictionaryItemAlphabet.Cmu,
                "ipa" => AgentRequestPronunciationDictionaryItemAlphabet.Ipa,
                "jyutping" => AgentRequestPronunciationDictionaryItemAlphabet.Jyutping,
                "pinyin" => AgentRequestPronunciationDictionaryItemAlphabet.Pinyin,
                _ => null,
            };
        }
    }
}