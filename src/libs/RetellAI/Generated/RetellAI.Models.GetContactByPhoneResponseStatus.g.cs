
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetContactByPhoneResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetContactByPhoneResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContactByPhoneResponseStatus value)
        {
            return value switch
            {
                GetContactByPhoneResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContactByPhoneResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetContactByPhoneResponseStatus.Error,
                _ => null,
            };
        }
    }
}