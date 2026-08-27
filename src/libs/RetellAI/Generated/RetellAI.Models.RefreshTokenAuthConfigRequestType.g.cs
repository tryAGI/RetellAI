
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RefreshTokenAuthConfigRequestType
    {
        /// <summary>
        ///
        /// </summary>
        RefreshToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RefreshTokenAuthConfigRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefreshTokenAuthConfigRequestType value)
        {
            return value switch
            {
                RefreshTokenAuthConfigRequestType.RefreshToken => "refresh_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RefreshTokenAuthConfigRequestType? ToEnum(string value)
        {
            return value switch
            {
                "refresh_token" => RefreshTokenAuthConfigRequestType.RefreshToken,
                _ => null,
            };
        }
    }
}