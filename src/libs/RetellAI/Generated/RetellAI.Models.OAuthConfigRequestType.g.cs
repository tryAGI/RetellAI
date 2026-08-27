
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum OAuthConfigRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuthConfigRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuthConfigRequestType value)
        {
            return value switch
            {
                OAuthConfigRequestType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuthConfigRequestType? ToEnum(string value)
        {
            return value switch
            {
                "oauth2" => OAuthConfigRequestType.Oauth2,
                _ => null,
            };
        }
    }
}