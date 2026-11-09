
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RecordChatMessageRequestVariant2Role
    {
        /// <summary>
        ///
        /// </summary>
        TransferTarget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecordChatMessageRequestVariant2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordChatMessageRequestVariant2Role value)
        {
            return value switch
            {
                RecordChatMessageRequestVariant2Role.TransferTarget => "transfer_target",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordChatMessageRequestVariant2Role? ToEnum(string value)
        {
            return value switch
            {
                "transfer_target" => RecordChatMessageRequestVariant2Role.TransferTarget,
                _ => null,
            };
        }
    }
}