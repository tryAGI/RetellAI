
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ConductorFormTextBlockVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        TextBlock,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConductorFormTextBlockVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConductorFormTextBlockVariant2Kind value)
        {
            return value switch
            {
                ConductorFormTextBlockVariant2Kind.TextBlock => "textBlock",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConductorFormTextBlockVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "textBlock" => ConductorFormTextBlockVariant2Kind.TextBlock,
                _ => null,
            };
        }
    }
}