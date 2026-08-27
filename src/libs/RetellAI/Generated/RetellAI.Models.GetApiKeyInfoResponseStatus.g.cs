
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum GetApiKeyInfoResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetApiKeyInfoResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetApiKeyInfoResponseStatus value)
        {
            return value switch
            {
                GetApiKeyInfoResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetApiKeyInfoResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetApiKeyInfoResponseStatus.Error,
                _ => null,
            };
        }
    }
}