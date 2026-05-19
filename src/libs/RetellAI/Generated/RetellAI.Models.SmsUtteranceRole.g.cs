
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// SMS message received from the user during the call (for example while the agent is leaving a voicemail). Not part of the spoken conversation.
    /// </summary>
    public enum SmsUtteranceRole
    {
        /// <summary>
        /// 
        /// </summary>
        Sms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsUtteranceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsUtteranceRole value)
        {
            return value switch
            {
                SmsUtteranceRole.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsUtteranceRole? ToEnum(string value)
        {
            return value switch
            {
                "sms" => SmsUtteranceRole.Sms,
                _ => null,
            };
        }
    }
}