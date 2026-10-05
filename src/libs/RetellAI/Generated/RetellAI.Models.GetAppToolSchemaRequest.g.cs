
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAppToolSchemaRequest
    {
        /// <summary>
        /// The app tool template name (the provider's catalog tool name).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_tool_template_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppToolTemplateName { get; set; }

        /// <summary>
        /// The input parameters resolved so far; empty on the first call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.IList<global::RetellAI.ToolParameter>? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAppToolSchemaRequest" /> class.
        /// </summary>
        /// <param name="appToolTemplateName">
        /// The app tool template name (the provider's catalog tool name).
        /// </param>
        /// <param name="parameters">
        /// The input parameters resolved so far; empty on the first call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAppToolSchemaRequest(
            string appToolTemplateName,
            global::System.Collections.Generic.IList<global::RetellAI.ToolParameter>? parameters)
        {
            this.AppToolTemplateName = appToolTemplateName ?? throw new global::System.ArgumentNullException(nameof(appToolTemplateName));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAppToolSchemaRequest" /> class.
        /// </summary>
        public GetAppToolSchemaRequest()
        {
        }

    }
}