
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RefreshTokenAuthConfigResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        RefreshToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RefreshTokenAuthConfigResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefreshTokenAuthConfigResponseType value)
        {
            return value switch
            {
                RefreshTokenAuthConfigResponseType.RefreshToken => "refresh_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RefreshTokenAuthConfigResponseType? ToEnum(string value)
        {
            return value switch
            {
                "refresh_token" => RefreshTokenAuthConfigResponseType.RefreshToken,
                _ => null,
            };
        }
    }
}