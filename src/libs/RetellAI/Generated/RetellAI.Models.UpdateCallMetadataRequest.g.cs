
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCallMetadataRequest
    {
        /// <summary>
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the call. Not used for processing. You can later get this field from the call object. Size limited to 50kB max.<br/>
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.UpdateCallMetadataRequestDataStorageSettingJsonConverter))]
        public global::RetellAI.UpdateCallMetadataRequestDataStorageSetting? DataStorageSetting { get; set; }

        /// <summary>
        /// Custom attributes for the call, as key-value pairs. Each attribute must first be defined for your organization in the Retell dashboard (Call History → Actions → Custom attributes) before it can be set here. The object key must match the id of an existing organization-level custom attribute; keys that do not match a defined attribute are ignored and will not be saved. Values must be a string, number, or boolean.<br/>
        /// Example: {"custom_attribute_1":"value1","custom_attribute_2":"value2"}
        /// </summary>
        /// <example>{"custom_attribute_1":"value1","custom_attribute_2":"value2"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_attributes")]
        public object? CustomAttributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCallMetadataRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the call. Not used for processing. You can later get this field from the call object. Size limited to 50kB max.<br/>
        /// Example: {"customer_id":"cust_123","notes":"Follow-up required"}
        /// </param>
        /// <param name="dataStorageSetting">
        /// Data storage setting for this call. Overrides the agent's default setting. "everything" stores all data, "everything_except_pii" excludes PII when possible, "basic_attributes_only" stores only metadata. Cannot be downgraded from more restrictive to less restrictive settings.<br/>
        /// Example: everything_except_pii
        /// </param>
        /// <param name="customAttributes">
        /// Custom attributes for the call, as key-value pairs. Each attribute must first be defined for your organization in the Retell dashboard (Call History → Actions → Custom attributes) before it can be set here. The object key must match the id of an existing organization-level custom attribute; keys that do not match a defined attribute are ignored and will not be saved. Values must be a string, number, or boolean.<br/>
        /// Example: {"custom_attribute_1":"value1","custom_attribute_2":"value2"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCallMetadataRequest(
            object? metadata,
            global::RetellAI.UpdateCallMetadataRequestDataStorageSetting? dataStorageSetting,
            object? customAttributes)
        {
            this.Metadata = metadata;
            this.DataStorageSetting = dataStorageSetting;
            this.CustomAttributes = customAttributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCallMetadataRequest" /> class.
        /// </summary>
        public UpdateCallMetadataRequest()
        {
        }

    }
}