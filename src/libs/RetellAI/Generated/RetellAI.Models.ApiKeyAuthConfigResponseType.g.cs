
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiKeyAuthConfigResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiKeyAuthConfigResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyAuthConfigResponseType value)
        {
            return value switch
            {
                ApiKeyAuthConfigResponseType.ApiKey => "api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyAuthConfigResponseType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => ApiKeyAuthConfigResponseType.ApiKey,
                _ => null,
            };
        }
    }
}