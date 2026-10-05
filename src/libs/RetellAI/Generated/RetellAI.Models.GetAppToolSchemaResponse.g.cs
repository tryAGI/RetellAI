
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAppToolSchemaResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Complete { get; set; }

        /// <summary>
        /// The parameters the functions accepts, described as a JSON Schema object. See [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. Omitting parameters defines a function with an empty parameter list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        public global::RetellAI.ToolParameter? InputSchema { get; set; }

        /// <summary>
        /// The parameters the functions accepts, described as a JSON Schema object. See [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. Omitting parameters defines a function with an empty parameter list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_schema")]
        public global::RetellAI.ToolParameter? ResponseSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAppToolSchemaResponse" /> class.
        /// </summary>
        /// <param name="complete"></param>
        /// <param name="inputSchema">
        /// The parameters the functions accepts, described as a JSON Schema object. See [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. Omitting parameters defines a function with an empty parameter list.
        /// </param>
        /// <param name="responseSchema">
        /// The parameters the functions accepts, described as a JSON Schema object. See [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. Omitting parameters defines a function with an empty parameter list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAppToolSchemaResponse(
            bool complete,
            global::RetellAI.ToolParameter? inputSchema,
            global::RetellAI.ToolParameter? responseSchema)
        {
            this.Complete = complete;
            this.InputSchema = inputSchema;
            this.ResponseSchema = responseSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAppToolSchemaResponse" /> class.
        /// </summary>
        public GetAppToolSchemaResponse()
        {
        }

    }
}