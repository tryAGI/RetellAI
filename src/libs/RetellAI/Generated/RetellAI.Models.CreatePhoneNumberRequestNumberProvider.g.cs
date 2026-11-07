
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// The provider to purchase the phone number from. Default to twilio. Bandwidth numbers only support UDP transport.<br/>
    /// Example: twilio
    /// </summary>
    public enum CreatePhoneNumberRequestNumberProvider
    {
        /// <summary>
        ///
        /// </summary>
        Bandwidth,
        /// <summary>
        ///
        /// </summary>
        Telnyx,
        /// <summary>
        ///
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePhoneNumberRequestNumberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePhoneNumberRequestNumberProvider value)
        {
            return value switch
            {
                CreatePhoneNumberRequestNumberProvider.Bandwidth => "bandwidth",
                CreatePhoneNumberRequestNumberProvider.Telnyx => "telnyx",
                CreatePhoneNumberRequestNumberProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePhoneNumberRequestNumberProvider? ToEnum(string value)
        {
            return value switch
            {
                "bandwidth" => CreatePhoneNumberRequestNumberProvider.Bandwidth,
                "telnyx" => CreatePhoneNumberRequestNumberProvider.Telnyx,
                "twilio" => CreatePhoneNumberRequestNumberProvider.Twilio,
                _ => null,
            };
        }
    }
}