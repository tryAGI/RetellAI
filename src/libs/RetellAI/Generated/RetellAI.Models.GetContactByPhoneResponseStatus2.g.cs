
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetContactByPhoneResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetContactByPhoneResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContactByPhoneResponseStatus2 value)
        {
            return value switch
            {
                GetContactByPhoneResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContactByPhoneResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetContactByPhoneResponseStatus2.Error,
                _ => null,
            };
        }
    }
}