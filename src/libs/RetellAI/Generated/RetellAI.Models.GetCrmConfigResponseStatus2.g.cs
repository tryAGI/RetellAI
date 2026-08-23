
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCrmConfigResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCrmConfigResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCrmConfigResponseStatus2 value)
        {
            return value switch
            {
                GetCrmConfigResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCrmConfigResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetCrmConfigResponseStatus2.Error,
                _ => null,
            };
        }
    }
}