
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DeleteAppResponseStatus4
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteAppResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAppResponseStatus4 value)
        {
            return value switch
            {
                DeleteAppResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAppResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteAppResponseStatus4.Error,
                _ => null,
            };
        }
    }
}