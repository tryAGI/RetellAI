#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI
{
    public partial interface IRetellAiClient
    {
        /// <summary>
        /// Update an existing chat agent
        /// </summary>
        /// <param name="agentId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="version">
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). The string "latest" resolves to the most recently created version (the largest version number), and "latest_published" resolves to the most recently published version. When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version, latest, or latest_published is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.ChatAgentResponse> UpdateChatAgentAsync(
            string agentId,

            global::RetellAI.ChatAgentRequest request,
            global::RetellAI.AgentVersionReference? version = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing chat agent
        /// </summary>
        /// <param name="agentId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="version">
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). The string "latest" resolves to the most recently created version (the largest version number), and "latest_published" resolves to the most recently published version. When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version, latest, or latest_published is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::RetellAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.AutoSDKHttpResponse<global::RetellAI.ChatAgentResponse>> UpdateChatAgentAsResponseAsync(
            string agentId,

            global::RetellAI.ChatAgentRequest request,
            global::RetellAI.AgentVersionReference? version = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing chat agent
        /// </summary>
        /// <param name="agentId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="version">
        /// Agent version reference. Supports a numeric version (for example 3) or a tag/environment name (for example "prod"). The string "latest" resolves to the most recently created version (the largest version number), and "latest_published" resolves to the most recently published version. When a tag is provided, resolution uses that exact tag assignment (including its dynamic variables). If the tag exists but is currently unassigned, it resolves to latest. When a numeric version, latest, or latest_published is provided, resolution applies dynamic variables from the preferred tag for that resolved version (most recently assigned), if any.
        /// </param>
        /// <param name="responseEngine"></param>
        /// <param name="agentName">
        /// The name of the chat agent. Only used for your own reference.<br/>
        /// Example: Jarvis
        /// </param>
        /// <param name="versionTitle">
        /// Optional title of the chat agent version. Used for your own reference.<br/>
        /// Example: Production hotfix
        /// </param>
        /// <param name="autoCloseMessage">
        /// Message to display when the chat is automatically closed.<br/>
        /// Example: Thank you for chatting. The conversation has ended.
        /// </param>
        /// <param name="endChatAfterSilenceMs">
        /// If users stay silent for a period after agent speech, end the chat. The minimum value allowed is 120,000 ms (2 minutes). The maximum value allowed is 259,200,000 ms (72 hours). By default, this is set to 3,600,000 (1 hour).<br/>
        /// Example: 3600000
        /// </param>
        /// <param name="language">
        /// Specifies what language(s) the agent will operate in. Accepts either a single locale (e.g. `en-US`) or an array of locales for multilingual agents (e.g. `["en-US","es-ES"]`). The scalar value `multi` is deprecated but still accepted as a scalar, and is stored and returned as the ten locales it used to mean. It must not appear inside the array form. Send an explicit locale array instead. If unset, defaults to `en-US`.
        /// </param>
        /// <param name="webhookUrl">
        /// The webhook for agent to listen to chat events. See what events it would get at [webhook doc](/features/webhook). If set, will bind webhook events for this agent to the specified url, and will ignore the account level webhook for this agent. Set to `null` to remove webhook url from this agent.<br/>
        /// Example: https://webhook-url-here
        /// </param>
        /// <param name="webhookEvents">
        /// Which webhook events this agent should receive. If not set, defaults to chat_started, chat_ended, chat_analyzed.
        /// </param>
        /// <param name="webhookTimeoutMs">
        /// The timeout for the webhook in milliseconds. If not set, default value of 10000 will apply.<br/>
        /// Example: 10000
        /// </param>
        /// <param name="dataStorageSetting">
        /// Controls what data is stored for this agent. "everything" stores all data including transcripts and recordings. "everything_except_pii" stores data but excludes PII when possible based on PII configuration. "basic_attributes_only" stores only basic metadata. If not set, defaults to "everything".<br/>
        /// Example: everything
        /// </param>
        /// <param name="dataStorageRetentionDays">
        /// Number of days to retain call/chat data before automatic deletion. Must be between 1 and 730 days. If not set, data is retained forever (no automatic deletion).<br/>
        /// Example: 30
        /// </param>
        /// <param name="optInSignedUrl">
        /// Whether this agent opts in to signed url for public log. If not set, default value of false will apply.<br/>
        /// Example: true
        /// </param>
        /// <param name="signedUrlExpirationMs">
        /// The expiration time for the signed url in milliseconds. Only applicable when opt_in_signed_url is true. If not set, default value of 86400000 (24 hours) will apply.<br/>
        /// Example: 86400000
        /// </param>
        /// <param name="postChatAnalysisData">
        /// Post chat analysis data to extract from the chat. This data will augment the pre-defined variables extracted in the chat analysis. This will be available after the chat ends.
        /// </param>
        /// <param name="postChatAnalysisModel">
        /// Available LLM models for agents.
        /// </param>
        /// <param name="piiConfig"></param>
        /// <param name="guardrailConfig"></param>
        /// <param name="handbookConfig">
        /// Behavior presets for chat agents. Voice-only presets are excluded.
        /// </param>
        /// <param name="timezone">
        /// IANA timezone for the agent (e.g. America/New_York). Defaults to America/Los_Angeles if not set.<br/>
        /// Example: America/New_York
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::RetellAI.ChatAgentResponse> UpdateChatAgentAsync(
            string agentId,
            global::RetellAI.AgentVersionReference? version = default,
            global::RetellAI.ResponseEngine? responseEngine = default,
            string? agentName = default,
            string? versionTitle = default,
            string? autoCloseMessage = default,
            int? endChatAfterSilenceMs = default,
#pragma warning disable CS0618 // Type or member is obsolete
            global::RetellAI.OneOf<global::RetellAI.Language3?, global::System.Collections.Generic.IList<global::RetellAI.Language3>, global::RetellAI.ChatAgentRequestLanguage?>? language = default,
#pragma warning disable CS0618 // Type or member is obsolete
            string? webhookUrl = default,
            global::System.Collections.Generic.IList<global::RetellAI.ChatAgentRequestWebhookEvent>? webhookEvents = default,
            int? webhookTimeoutMs = default,
            global::RetellAI.ChatAgentRequestDataStorageSetting? dataStorageSetting = default,
            int? dataStorageRetentionDays = default,
            bool? optInSignedUrl = default,
            int? signedUrlExpirationMs = default,
            global::System.Collections.Generic.IList<global::RetellAI.PostChatAnalysisData>? postChatAnalysisData = default,
            global::RetellAI.NullableLLMModel? postChatAnalysisModel = default,
            global::RetellAI.PIIConfig? piiConfig = default,
            global::RetellAI.GuardrailConfig? guardrailConfig = default,
            global::RetellAI.ChatHandbookConfig? handbookConfig = default,
            string? timezone = default,
            global::RetellAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}