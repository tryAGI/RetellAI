
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// A filter value, not a stored value. It maps to the `spam_check_enabled` and `spam_status` fields of PhoneNumberResponse. clean / spam: enrolled, and `spam_status` equals the value. unknown: enrolled, and `spam_status` is absent. not_enrolled: `spam_check_enabled` is false or absent.
    /// </summary>
    public enum PhoneNumberSpamStatus
    {
        /// <summary>
        /// enrolled, and `spam_status` equals the value. unknown: enrolled, and `spam_status` is absent. not_enrolled: `spam_check_enabled` is false or absent.
        /// </summary>
        Clean,
        /// <summary>
        /// enrolled, and `spam_status` equals the value. unknown: enrolled, and `spam_status` is absent. not_enrolled: `spam_check_enabled` is false or absent.
        /// </summary>
        NotEnrolled,
        /// <summary>
        /// enrolled, and `spam_status` equals the value. unknown: enrolled, and `spam_status` is absent. not_enrolled: `spam_check_enabled` is false or absent.
        /// </summary>
        Spam,
        /// <summary>
        /// enrolled, and `spam_status` equals the value. unknown: enrolled, and `spam_status` is absent. not_enrolled: `spam_check_enabled` is false or absent.
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberSpamStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberSpamStatus value)
        {
            return value switch
            {
                PhoneNumberSpamStatus.Clean => "clean",
                PhoneNumberSpamStatus.NotEnrolled => "not_enrolled",
                PhoneNumberSpamStatus.Spam => "spam",
                PhoneNumberSpamStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberSpamStatus? ToEnum(string value)
        {
            return value switch
            {
                "clean" => PhoneNumberSpamStatus.Clean,
                "not_enrolled" => PhoneNumberSpamStatus.NotEnrolled,
                "spam" => PhoneNumberSpamStatus.Spam,
                "unknown" => PhoneNumberSpamStatus.Unknown,
                _ => null,
            };
        }
    }
}