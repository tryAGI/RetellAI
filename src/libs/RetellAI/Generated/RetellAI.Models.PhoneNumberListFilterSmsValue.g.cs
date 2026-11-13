
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PhoneNumberListFilterSmsValue
    {
        /// <summary>
        ///
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberListFilterSmsValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberListFilterSmsValue value)
        {
            return value switch
            {
                PhoneNumberListFilterSmsValue.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberListFilterSmsValue? ToEnum(string value)
        {
            return value switch
            {
                "true" => PhoneNumberListFilterSmsValue.True,
                _ => null,
            };
        }
    }
}