
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PhoneNumberListFilterBrandedCallValue
    {
        /// <summary>
        ///
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberListFilterBrandedCallValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberListFilterBrandedCallValue value)
        {
            return value switch
            {
                PhoneNumberListFilterBrandedCallValue.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberListFilterBrandedCallValue? ToEnum(string value)
        {
            return value switch
            {
                "true" => PhoneNumberListFilterBrandedCallValue.True,
                _ => null,
            };
        }
    }
}