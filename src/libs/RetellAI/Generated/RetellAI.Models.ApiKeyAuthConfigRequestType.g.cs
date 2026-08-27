
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ApiKeyAuthConfigRequestType
    {
        /// <summary>
        ///
        /// </summary>
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiKeyAuthConfigRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyAuthConfigRequestType value)
        {
            return value switch
            {
                ApiKeyAuthConfigRequestType.ApiKey => "api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyAuthConfigRequestType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => ApiKeyAuthConfigRequestType.ApiKey,
                _ => null,
            };
        }
    }
}