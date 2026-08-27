
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// SMS message exchanged during the call (for example received from the user). Woven into the transcript and shown to the agent, but not part of the spoken conversation.
    /// </summary>
    public enum SmsMessageBaseRole
    {
        /// <summary>
        ///
        /// </summary>
        Sms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsMessageBaseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsMessageBaseRole value)
        {
            return value switch
            {
                SmsMessageBaseRole.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsMessageBaseRole? ToEnum(string value)
        {
            return value switch
            {
                "sms" => SmsMessageBaseRole.Sms,
                _ => null,
            };
        }
    }
}