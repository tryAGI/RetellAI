
#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationResponseVariant2
    {
        /// <summary>
        /// Unique identifier of the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Contract end date (YYYY-MM-DD) of the org's enterprise plan, if it belongs to one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_plan_end")]
        public string? EnterprisePlanEnd { get; set; }

        /// <summary>
        /// Lifecycle status of the org's enterprise plan, if it belongs to one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_plan_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.OrganizationResponseVariant2EnterprisePlanStatusJsonConverter))]
        public global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus? EnterprisePlanStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationResponseVariant2" /> class.
        /// </summary>
        /// <param name="orgId">
        /// Unique identifier of the organization
        /// </param>
        /// <param name="enterprisePlanEnd">
        /// Contract end date (YYYY-MM-DD) of the org's enterprise plan, if it belongs to one.
        /// </param>
        /// <param name="enterprisePlanStatus">
        /// Lifecycle status of the org's enterprise plan, if it belongs to one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationResponseVariant2(
            string? orgId,
            string? enterprisePlanEnd,
            global::RetellAI.OrganizationResponseVariant2EnterprisePlanStatus? enterprisePlanStatus)
        {
            this.OrgId = orgId;
            this.EnterprisePlanEnd = enterprisePlanEnd;
            this.EnterprisePlanStatus = enterprisePlanStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationResponseVariant2" /> class.
        /// </summary>
        public OrganizationResponseVariant2()
        {
        }

    }
}