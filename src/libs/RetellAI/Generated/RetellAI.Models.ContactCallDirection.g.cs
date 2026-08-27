
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Direction of the call.
    /// </summary>
    public enum ContactCallDirection
    {
        /// <summary>
        ///
        /// </summary>
        Inbound,
        /// <summary>
        ///
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContactCallDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContactCallDirection value)
        {
            return value switch
            {
                ContactCallDirection.Inbound => "inbound",
                ContactCallDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContactCallDirection? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => ContactCallDirection.Inbound,
                "outbound" => ContactCallDirection.Outbound,
                _ => null,
            };
        }
    }
}