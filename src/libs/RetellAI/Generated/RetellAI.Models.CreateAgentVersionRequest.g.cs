
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentVersionRequest
    {
        /// <summary>
        /// Existing version used as the base when creating a new draft.<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BaseVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentVersionRequest" /> class.
        /// </summary>
        /// <param name="baseVersion">
        /// Existing version used as the base when creating a new draft.<br/>
        /// Example: 12
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentVersionRequest(
            int baseVersion)
        {
            this.BaseVersion = baseVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentVersionRequest" /> class.
        /// </summary>
        public CreateAgentVersionRequest()
        {
        }

    }
}