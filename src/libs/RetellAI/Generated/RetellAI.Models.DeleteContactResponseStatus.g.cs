
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DeleteContactResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteContactResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteContactResponseStatus value)
        {
            return value switch
            {
                DeleteContactResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteContactResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteContactResponseStatus.Error,
                _ => null,
            };
        }
    }
}