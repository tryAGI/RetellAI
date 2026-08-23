
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CRMCustomFieldSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Display label for the field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.CRMCustomFieldSchemaTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.CRMCustomFieldSchemaType Type { get; set; }

        /// <summary>
        /// Allowed values. Required when `type` is `enum`, where a value is rejected unless it appears here; ignored for every other type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<string>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CRMCustomFieldSchema" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="label">
        /// Display label for the field.
        /// </param>
        /// <param name="description"></param>
        /// <param name="options">
        /// Allowed values. Required when `type` is `enum`, where a value is rejected unless it appears here; ignored for every other type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CRMCustomFieldSchema(
            string name,
            global::RetellAI.CRMCustomFieldSchemaType type,
            string? label,
            string? description,
            global::System.Collections.Generic.IList<string>? options)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Label = label;
            this.Description = description;
            this.Type = type;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CRMCustomFieldSchema" /> class.
        /// </summary>
        public CRMCustomFieldSchema()
        {
        }

    }
}