
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetContactByPhoneResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetContactByPhoneResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContactByPhoneResponseStatus4 value)
        {
            return value switch
            {
                GetContactByPhoneResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContactByPhoneResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetContactByPhoneResponseStatus4.Error,
                _ => null,
            };
        }
    }
}