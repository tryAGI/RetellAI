
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Filters for listing phone numbers. All provided filters are connected with AND.
    /// </summary>
    public sealed partial class PhoneNumberListFilter
    {
        /// <summary>
        /// Substring match against the phone number, pretty phone number, or nickname. The nickname match ignores case.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spam_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterSpamStatus>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterSpamStatus>? SpamStatus { get; set; }

        /// <summary>
        /// Matches numbers that have a custom SMS configuration or an approved A2P application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterSms>))]
        public global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterSms>? Sms { get; set; }

        /// <summary>
        /// Matches numbers that have an active phone verification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified_number")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterVerifiedNumber>))]
        public global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterVerifiedNumber>? VerifiedNumber { get; set; }

        /// <summary>
        /// Matches numbers that have an active branded call registration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branded_call")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterBrandedCall>))]
        public global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterBrandedCall>? BrandedCall { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterPhoneNumberType>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterPhoneNumberType>? PhoneNumberType { get; set; }

        /// <summary>
        /// Matches numbers with any listed agent among their inbound agents. For an agent with `version`, a number matches when it is bound to a listed version or to a tag in `inbound_agent_tags`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_agents")]
        public global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterInboundAgent>>? InboundAgents { get; set; }

        /// <summary>
        /// Agent version tags, such as `production`. Without `inbound_agents`, matches numbers whose inbound agent is bound through one of these tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_agent_tags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterInboundAgentTags>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterInboundAgentTags>? InboundAgentTags { get; set; }

        /// <summary>
        /// Matches numbers with any listed agent among their outbound agents. For an agent with `version`, a number matches when it is bound to a listed version or to a tag in `outbound_agent_tags`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound_agents")]
        public global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterOutboundAgent>>? OutboundAgents { get; set; }

        /// <summary>
        /// Agent version tags, such as `production`. Without `outbound_agents`, matches numbers whose outbound agent is bound through one of these tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound_agent_tags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::RetellAI.JsonConverters.AllOfJsonConverter<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterOutboundAgentTags>))]
        public global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterOutboundAgentTags>? OutboundAgentTags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberListFilter" /> class.
        /// </summary>
        /// <param name="query">
        /// Substring match against the phone number, pretty phone number, or nickname. The nickname match ignores case.
        /// </param>
        /// <param name="spamStatus"></param>
        /// <param name="sms">
        /// Matches numbers that have a custom SMS configuration or an approved A2P application.
        /// </param>
        /// <param name="verifiedNumber">
        /// Matches numbers that have an active phone verification.
        /// </param>
        /// <param name="brandedCall">
        /// Matches numbers that have an active branded call registration.
        /// </param>
        /// <param name="phoneNumberType"></param>
        /// <param name="inboundAgents">
        /// Matches numbers with any listed agent among their inbound agents. For an agent with `version`, a number matches when it is bound to a listed version or to a tag in `inbound_agent_tags`.
        /// </param>
        /// <param name="inboundAgentTags">
        /// Agent version tags, such as `production`. Without `inbound_agents`, matches numbers whose inbound agent is bound through one of these tags.
        /// </param>
        /// <param name="outboundAgents">
        /// Matches numbers with any listed agent among their outbound agents. For an agent with `version`, a number matches when it is bound to a listed version or to a tag in `outbound_agent_tags`.
        /// </param>
        /// <param name="outboundAgentTags">
        /// Agent version tags, such as `production`. Without `outbound_agents`, matches numbers whose outbound agent is bound through one of these tags.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberListFilter(
            string? query,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterSpamStatus>? spamStatus,
            global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterSms>? sms,
            global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterVerifiedNumber>? verifiedNumber,
            global::RetellAI.AllOf<global::RetellAI.BooleanFilter, global::RetellAI.PhoneNumberListFilterBrandedCall>? brandedCall,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterPhoneNumberType>? phoneNumberType,
            global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterInboundAgent>>? inboundAgents,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterInboundAgentTags>? inboundAgentTags,
            global::System.Collections.Generic.IList<global::RetellAI.AllOf<global::RetellAI.AgentFilter, global::RetellAI.PhoneNumberListFilterOutboundAgent>>? outboundAgents,
            global::RetellAI.AllOf<global::RetellAI.EnumFilter, global::RetellAI.PhoneNumberListFilterOutboundAgentTags>? outboundAgentTags)
        {
            this.Query = query;
            this.SpamStatus = spamStatus;
            this.Sms = sms;
            this.VerifiedNumber = verifiedNumber;
            this.BrandedCall = brandedCall;
            this.PhoneNumberType = phoneNumberType;
            this.InboundAgents = inboundAgents;
            this.InboundAgentTags = inboundAgentTags;
            this.OutboundAgents = outboundAgents;
            this.OutboundAgentTags = outboundAgentTags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberListFilter" /> class.
        /// </summary>
        public PhoneNumberListFilter()
        {
        }

    }
}