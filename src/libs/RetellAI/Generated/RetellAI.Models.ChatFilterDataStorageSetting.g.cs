
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Filter by data storage setting.
    /// </summary>
    public sealed partial class ChatFilterDataStorageSetting
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::System.Collections.Generic.IList<global::RetellAI.ChatFilterDataStorageSettingValueItem>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFilterDataStorageSetting" /> class.
        /// </summary>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatFilterDataStorageSetting(
            global::System.Collections.Generic.IList<global::RetellAI.ChatFilterDataStorageSettingValueItem>? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFilterDataStorageSetting" /> class.
        /// </summary>
        public ChatFilterDataStorageSetting()
        {
        }

    }
}