
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum DashboardSource
    {
        /// <summary>
        /// 
        /// </summary>
        Call,
        /// <summary>
        /// 
        /// </summary>
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DashboardSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DashboardSource value)
        {
            return value switch
            {
                DashboardSource.Call => "call",
                DashboardSource.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DashboardSource? ToEnum(string value)
        {
            return value switch
            {
                "call" => DashboardSource.Call,
                "chat" => DashboardSource.Chat,
                _ => null,
            };
        }
    }
}