
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Org feature gates. Includes Dynamo-stored buckets plus computed Redis rollout flags marked exposeToApi; computed flags win on name collision.
    /// </summary>
    public sealed partial class OrganizationFeatureBucket
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}