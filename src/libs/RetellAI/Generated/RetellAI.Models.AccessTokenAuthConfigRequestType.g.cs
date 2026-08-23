
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AccessTokenAuthConfigRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        AccessToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessTokenAuthConfigRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessTokenAuthConfigRequestType value)
        {
            return value switch
            {
                AccessTokenAuthConfigRequestType.AccessToken => "access_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessTokenAuthConfigRequestType? ToEnum(string value)
        {
            return value switch
            {
                "access_token" => AccessTokenAuthConfigRequestType.AccessToken,
                _ => null,
            };
        }
    }
}