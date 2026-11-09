
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum EscalationDestinationDestinationMethod
    {
        /// <summary>
        ///
        /// </summary>
        Post,
        /// <summary>
        ///
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EscalationDestinationDestinationMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EscalationDestinationDestinationMethod value)
        {
            return value switch
            {
                EscalationDestinationDestinationMethod.Post => "POST",
                EscalationDestinationDestinationMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EscalationDestinationDestinationMethod? ToEnum(string value)
        {
            return value switch
            {
                "POST" => EscalationDestinationDestinationMethod.Post,
                "PUT" => EscalationDestinationDestinationMethod.Put,
                _ => null,
            };
        }
    }
}