
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BackupModelRef
    {
        /// <summary>
        /// Available LLM models for agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.LLMModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::RetellAI.LLMModel Model { get; set; }

        /// <summary>
        /// Capacity tier for a model. standard is always available. fast draws from dedicated capacity for lower, steadier latency, and ultrafast is faster still on voice agents; faster tiers cost more. Each model offers its own set of tiers, and a tier the model does not offer is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.ServiceTierJsonConverter))]
        public global::RetellAI.ServiceTier? Tier { get; set; }

        /// <summary>
        /// How long to prefer the primary model's output while both models run, in milliseconds. Defaults to 1500.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kick_in_timeout_ms")]
        public int? KickInTimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupModelRef" /> class.
        /// </summary>
        /// <param name="model">
        /// Available LLM models for agents.
        /// </param>
        /// <param name="tier">
        /// Capacity tier for a model. standard is always available. fast draws from dedicated capacity for lower, steadier latency, and ultrafast is faster still on voice agents; faster tiers cost more. Each model offers its own set of tiers, and a tier the model does not offer is rejected.
        /// </param>
        /// <param name="kickInTimeoutMs">
        /// How long to prefer the primary model's output while both models run, in milliseconds. Defaults to 1500.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupModelRef(
            global::RetellAI.LLMModel model,
            global::RetellAI.ServiceTier? tier,
            int? kickInTimeoutMs)
        {
            this.Model = model;
            this.Tier = tier;
            this.KickInTimeoutMs = kickInTimeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupModelRef" /> class.
        /// </summary>
        public BackupModelRef()
        {
        }

    }
}