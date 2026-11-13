
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PhoneNumberListFilterPhoneNumberTypeValueItem
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        RetellBandwidth,
        /// <summary>
        ///
        /// </summary>
        RetellTelnyx,
        /// <summary>
        ///
        /// </summary>
        RetellTwilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberListFilterPhoneNumberTypeValueItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberListFilterPhoneNumberTypeValueItem value)
        {
            return value switch
            {
                PhoneNumberListFilterPhoneNumberTypeValueItem.Custom => "custom",
                PhoneNumberListFilterPhoneNumberTypeValueItem.RetellBandwidth => "retell-bandwidth",
                PhoneNumberListFilterPhoneNumberTypeValueItem.RetellTelnyx => "retell-telnyx",
                PhoneNumberListFilterPhoneNumberTypeValueItem.RetellTwilio => "retell-twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberListFilterPhoneNumberTypeValueItem? ToEnum(string value)
        {
            return value switch
            {
                "custom" => PhoneNumberListFilterPhoneNumberTypeValueItem.Custom,
                "retell-bandwidth" => PhoneNumberListFilterPhoneNumberTypeValueItem.RetellBandwidth,
                "retell-telnyx" => PhoneNumberListFilterPhoneNumberTypeValueItem.RetellTelnyx,
                "retell-twilio" => PhoneNumberListFilterPhoneNumberTypeValueItem.RetellTwilio,
                _ => null,
            };
        }
    }
}