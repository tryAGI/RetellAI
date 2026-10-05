
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AppToolType
    {
        /// <summary>
        ///
        /// </summary>
        IntegrationApp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppToolType value)
        {
            return value switch
            {
                AppToolType.IntegrationApp => "integration_app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppToolType? ToEnum(string value)
        {
            return value switch
            {
                "integration_app" => AppToolType.IntegrationApp,
                _ => null,
            };
        }
    }
}