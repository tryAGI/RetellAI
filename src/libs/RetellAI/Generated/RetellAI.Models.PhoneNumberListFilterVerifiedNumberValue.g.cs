
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PhoneNumberListFilterVerifiedNumberValue
    {
        /// <summary>
        ///
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberListFilterVerifiedNumberValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberListFilterVerifiedNumberValue value)
        {
            return value switch
            {
                PhoneNumberListFilterVerifiedNumberValue.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberListFilterVerifiedNumberValue? ToEnum(string value)
        {
            return value switch
            {
                "true" => PhoneNumberListFilterVerifiedNumberValue.True,
                _ => null,
            };
        }
    }
}