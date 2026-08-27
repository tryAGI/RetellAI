
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// How the tool's `parameters` are authored and shown in the dashboard editor — "form" for the visual parameter builder, "json" for a raw JSON Schema. Both produce the same `parameters` schema; this does not change how the request body is encoded (see `args_at_root`).
    /// </summary>
    public enum CustomToolParameterType
    {
        /// <summary>
        ///
        /// </summary>
        Form,
        /// <summary>
        ///
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolParameterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolParameterType value)
        {
            return value switch
            {
                CustomToolParameterType.Form => "form",
                CustomToolParameterType.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolParameterType? ToEnum(string value)
        {
            return value switch
            {
                "form" => CustomToolParameterType.Form,
                "json" => CustomToolParameterType.Json,
                _ => null,
            };
        }
    }
}