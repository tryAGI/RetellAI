
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Microsoft OneDrive account type discovered during OAuth.
    /// </summary>
    public enum AppResponseTenantType
    {
        /// <summary>
        ///
        /// </summary>
        Business,
        /// <summary>
        ///
        /// </summary>
        Personal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppResponseTenantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppResponseTenantType value)
        {
            return value switch
            {
                AppResponseTenantType.Business => "business",
                AppResponseTenantType.Personal => "personal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppResponseTenantType? ToEnum(string value)
        {
            return value switch
            {
                "business" => AppResponseTenantType.Business,
                "personal" => AppResponseTenantType.Personal,
                _ => null,
            };
        }
    }
}