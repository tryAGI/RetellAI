
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SmsSenderVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        RetellLongCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsSenderVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsSenderVariant2Type value)
        {
            return value switch
            {
                SmsSenderVariant2Type.RetellLongCode => "retell_long_code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsSenderVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "retell_long_code" => SmsSenderVariant2Type.RetellLongCode,
                _ => null,
            };
        }
    }
}