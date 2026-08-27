
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Connection health of the App, server-managed. `not_connected` after create or a credential / tenant URL change; `connected` once verified via OAuth connect, an auth test, or a successful live tool call; `error` when the provider rejects the credentials (on connect, an auth test, or a live tool call).
    /// </summary>
    public enum AppConnectionStatus
    {
        /// <summary>
        ///
        /// </summary>
        Connected,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        NotConnected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppConnectionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppConnectionStatus value)
        {
            return value switch
            {
                AppConnectionStatus.Connected => "connected",
                AppConnectionStatus.Error => "error",
                AppConnectionStatus.NotConnected => "not_connected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppConnectionStatus? ToEnum(string value)
        {
            return value switch
            {
                "connected" => AppConnectionStatus.Connected,
                "error" => AppConnectionStatus.Error,
                "not_connected" => AppConnectionStatus.NotConnected,
                _ => null,
            };
        }
    }
}