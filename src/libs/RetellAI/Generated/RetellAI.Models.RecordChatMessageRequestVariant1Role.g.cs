
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RecordChatMessageRequestVariant1Role
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecordChatMessageRequestVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordChatMessageRequestVariant1Role value)
        {
            return value switch
            {
                RecordChatMessageRequestVariant1Role.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordChatMessageRequestVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "user" => RecordChatMessageRequestVariant1Role.User,
                _ => null,
            };
        }
    }
}