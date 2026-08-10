
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetApiKeyInfoResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetApiKeyInfoResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetApiKeyInfoResponseStatus2 value)
        {
            return value switch
            {
                GetApiKeyInfoResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetApiKeyInfoResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetApiKeyInfoResponseStatus2.Error,
                _ => null,
            };
        }
    }
}