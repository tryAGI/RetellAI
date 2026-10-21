
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Runs a text LLM with a separate voice. This is the default type.
    /// </summary>
    public enum CascadingModelConfigType
    {
        /// <summary>
        ///
        /// </summary>
        Cascading,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CascadingModelConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CascadingModelConfigType value)
        {
            return value switch
            {
                CascadingModelConfigType.Cascading => "cascading",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CascadingModelConfigType? ToEnum(string value)
        {
            return value switch
            {
                "cascading" => CascadingModelConfigType.Cascading,
                _ => null,
            };
        }
    }
}