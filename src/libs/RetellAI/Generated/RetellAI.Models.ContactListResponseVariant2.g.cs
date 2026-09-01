
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContactListResponseVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::RetellAI.Contact> Items { get; set; }

        /// <summary>
        /// Total count of contacts matching the filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public double? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListResponseVariant2" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="total">
        /// Total count of contacts matching the filter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactListResponseVariant2(
            global::System.Collections.Generic.IList<global::RetellAI.Contact> items,
            double? total)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListResponseVariant2" /> class.
        /// </summary>
        public ContactListResponseVariant2()
        {
        }

    }
}