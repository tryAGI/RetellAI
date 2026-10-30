
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DuplexModelRefModel
    {
        /// <summary>
        ///
        /// </summary>
        GptLive1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DuplexModelRefModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DuplexModelRefModel value)
        {
            return value switch
            {
                DuplexModelRefModel.GptLive1 => "gpt-live-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DuplexModelRefModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-live-1" => DuplexModelRefModel.GptLive1,
                _ => null,
            };
        }
    }
}