
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetApiKeyInfoResponse
    {
        /// <summary>
        /// Display name of the org.<br/>
        /// Example: Acme Inc
        /// </summary>
        /// <example>Acme Inc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgName { get; set; }

        /// <summary>
        /// Display name of the API key used, if it has one.<br/>
        /// Example: My API Key
        /// </summary>
        /// <example>My API Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_name")]
        public string? ApiKeyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyInfoResponse" /> class.
        /// </summary>
        /// <param name="orgName">
        /// Display name of the org.<br/>
        /// Example: Acme Inc
        /// </param>
        /// <param name="apiKeyName">
        /// Display name of the API key used, if it has one.<br/>
        /// Example: My API Key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiKeyInfoResponse(
            string orgName,
            string? apiKeyName)
        {
            this.OrgName = orgName ?? throw new global::System.ArgumentNullException(nameof(orgName));
            this.ApiKeyName = apiKeyName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyInfoResponse" /> class.
        /// </summary>
        public GetApiKeyInfoResponse()
        {
        }

    }
}