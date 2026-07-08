
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// ASR provider name.
    /// </summary>
    public enum AsrProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Assemblyai,
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        Deepgram,
        /// <summary>
        /// 
        /// </summary>
        Soniox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsrProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsrProvider value)
        {
            return value switch
            {
                AsrProvider.Assemblyai => "assemblyai",
                AsrProvider.Azure => "azure",
                AsrProvider.Deepgram => "deepgram",
                AsrProvider.Soniox => "soniox",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsrProvider? ToEnum(string value)
        {
            return value switch
            {
                "assemblyai" => AsrProvider.Assemblyai,
                "azure" => AsrProvider.Azure,
                "deepgram" => AsrProvider.Deepgram,
                "soniox" => AsrProvider.Soniox,
                _ => null,
            };
        }
    }
}