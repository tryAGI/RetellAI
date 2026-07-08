
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Call fields to override on the running call. Each field is applied to the live call immediately; omitted fields are left unchanged.
    /// </summary>
    public sealed partial class UpdateLiveCallRequestFieldsToOverride
    {
        /// <summary>
        /// Override dynamic variables represented as key-value pairs of strings. Setting this will override or add the dynamic variables set in the agent during the call. Only need to set the delta where you want to override, no need to set the entire dynamic variables object. Setting this to null will remove any existing override.<br/>
        /// Example: {"additional_discount":"15%"}
        /// </summary>
        /// <example>{"additional_discount":"15%"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("override_dynamic_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? OverrideDynamicVariables { get; set; }

        /// <summary>
        /// An arbitrary object for storage purpose only. Overrides the metadata on the call. Size limited to 50kB max.<br/>
        /// Example: {"customer_id":"cust_123","notes":"Follow-up required"}
        /// </summary>
        /// <example>{"customer_id":"cust_123","notes":"Follow-up required"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Data storage setting for this call. Overrides the agent's default setting. "everything" stores all data, "everything_except_pii" excludes PII when possible, "basic_attributes_only" stores only metadata. Cannot be downgraded from more restrictive to less restrictive settings.<br/>
        /// Example: everything_except_pii
        /// </summary>
        /// <example>everything_except_pii</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_storage_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.UpdateLiveCallRequestFieldsToOverrideDataStorageSettingJsonConverter))]
        public global::RetellAI.UpdateLiveCallRequestFieldsToOverrideDataStorageSetting? DataStorageSetting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLiveCallRequestFieldsToOverride" /> class.
        /// </summary>
        /// <param name="overrideDynamicVariables">
        /// Override dynamic variables represented as key-value pairs of strings. Setting this will override or add the dynamic variables set in the agent during the call. Only need to set the delta where you want to override, no need to set the entire dynamic variables object. Setting this to null will remove any existing override.<br/>
        /// Example: {"additional_discount":"15%"}
        /// </param>
        /// <param name="metadata">
        /// An arbitrary object for storage purpose only. Overrides the metadata on the call. Size limited to 50kB max.<br/>
        /// Example: {"customer_id":"cust_123","notes":"Follow-up required"}
        /// </param>
        /// <param name="dataStorageSetting">
        /// Data storage setting for this call. Overrides the agent's default setting. "everything" stores all data, "everything_except_pii" excludes PII when possible, "basic_attributes_only" stores only metadata. Cannot be downgraded from more restrictive to less restrictive settings.<br/>
        /// Example: everything_except_pii
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateLiveCallRequestFieldsToOverride(
            global::System.Collections.Generic.Dictionary<string, string>? overrideDynamicVariables,
            object? metadata,
            global::RetellAI.UpdateLiveCallRequestFieldsToOverrideDataStorageSetting? dataStorageSetting)
        {
            this.OverrideDynamicVariables = overrideDynamicVariables;
            this.Metadata = metadata;
            this.DataStorageSetting = dataStorageSetting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLiveCallRequestFieldsToOverride" /> class.
        /// </summary>
        public UpdateLiveCallRequestFieldsToOverride()
        {
        }

    }
}