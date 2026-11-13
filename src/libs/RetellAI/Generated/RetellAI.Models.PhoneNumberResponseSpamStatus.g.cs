
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Latest spam test result for this number. Absent until the first vendor result arrives.<br/>
    /// Example: clean
    /// </summary>
    public enum PhoneNumberResponseSpamStatus
    {
        /// <summary>
        ///
        /// </summary>
        Clean,
        /// <summary>
        ///
        /// </summary>
        Spam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberResponseSpamStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberResponseSpamStatus value)
        {
            return value switch
            {
                PhoneNumberResponseSpamStatus.Clean => "clean",
                PhoneNumberResponseSpamStatus.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberResponseSpamStatus? ToEnum(string value)
        {
            return value switch
            {
                "clean" => PhoneNumberResponseSpamStatus.Clean,
                "spam" => PhoneNumberResponseSpamStatus.Spam,
                _ => null,
            };
        }
    }
}