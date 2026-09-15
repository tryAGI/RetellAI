
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatFilterDataStorageSettingValueItem
    {
        /// <summary>
        ///
        /// </summary>
        BasicAttributesOnly,
        /// <summary>
        ///
        /// </summary>
        Everything,
        /// <summary>
        ///
        /// </summary>
        EverythingExceptPii,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFilterDataStorageSettingValueItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFilterDataStorageSettingValueItem value)
        {
            return value switch
            {
                ChatFilterDataStorageSettingValueItem.BasicAttributesOnly => "basic_attributes_only",
                ChatFilterDataStorageSettingValueItem.Everything => "everything",
                ChatFilterDataStorageSettingValueItem.EverythingExceptPii => "everything_except_pii",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFilterDataStorageSettingValueItem? ToEnum(string value)
        {
            return value switch
            {
                "basic_attributes_only" => ChatFilterDataStorageSettingValueItem.BasicAttributesOnly,
                "everything" => ChatFilterDataStorageSettingValueItem.Everything,
                "everything_except_pii" => ChatFilterDataStorageSettingValueItem.EverythingExceptPii,
                _ => null,
            };
        }
    }
}