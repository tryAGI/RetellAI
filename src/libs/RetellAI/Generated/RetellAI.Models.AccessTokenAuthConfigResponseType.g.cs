
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessTokenAuthConfigResponseType
    {
        /// <summary>
        ///
        /// </summary>
        AccessToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessTokenAuthConfigResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessTokenAuthConfigResponseType value)
        {
            return value switch
            {
                AccessTokenAuthConfigResponseType.AccessToken => "access_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessTokenAuthConfigResponseType? ToEnum(string value)
        {
            return value switch
            {
                "access_token" => AccessTokenAuthConfigResponseType.AccessToken,
                _ => null,
            };
        }
    }
}