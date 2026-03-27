using System.Text.Json;
using Microsoft.Extensions.AI;

namespace RetellAI;

/// <summary>
/// Extensions for using RetellAiClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class RetellAiToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists Retell AI voice agents.
    /// </summary>
    /// <param name="client">The Retell AI client.</param>
    /// <param name="limit">Maximum number of agents to return.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListAgentsTool(
        this RetellAiClient client,
        int limit = 50)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var agents = await client.ListAgentsAsync(
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatAgentList(agents);
            },
            name: "ListRetellAgents",
            description: "Lists all Retell AI voice agents. Returns agent IDs, names, versions, and published status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets details of a specific Retell AI agent by ID.
    /// </summary>
    /// <param name="client">The Retell AI client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetAgentTool(this RetellAiClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [System.ComponentModel.Description("The unique identifier of the agent to retrieve.")]
                string agentId,
                CancellationToken cancellationToken) =>
            {
                var agent = await client.GetAgentAsync(
                    agentId: agentId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatAgent(agent);
            },
            name: "GetRetellAgent",
            description: "Gets details of a specific Retell AI voice agent by its ID. Returns the agent's name, version, voice settings, and configuration.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that creates a new outbound phone call via Retell AI.
    /// </summary>
    /// <param name="client">The Retell AI client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsCreatePhoneCallTool(this RetellAiClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [System.ComponentModel.Description("The phone number to call from in E.164 format (e.g. +14157774444). Must be a number purchased from or imported to Retell.")]
                string fromNumber,
                [System.ComponentModel.Description("The phone number to call in E.164 format (e.g. +12137774445).")]
                string toNumber,
                [System.ComponentModel.Description("Optional agent ID to override the default agent for this call.")]
                string? overrideAgentId,
                CancellationToken cancellationToken) =>
            {
                var call = await client.CreatePhoneCallAsync(
                    fromNumber: fromNumber,
                    toNumber: toNumber,
                    overrideAgentId: overrideAgentId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatPhoneCallResponse(call);
            },
            name: "CreateRetellPhoneCall",
            description: "Creates a new outbound phone call using a Retell AI voice agent. Requires from and to phone numbers in E.164 format. Returns the call ID and status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists Retell AI calls with optional limit.
    /// </summary>
    /// <param name="client">The Retell AI client.</param>
    /// <param name="limit">Maximum number of calls to return.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListCallsTool(
        this RetellAiClient client,
        int limit = 50)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var calls = await client.ListCallsAsync(
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCallList(calls);
            },
            name: "ListRetellCalls",
            description: "Lists recent Retell AI voice calls. Returns call IDs, statuses, agent info, durations, and timestamps.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets details of a specific Retell AI call by ID.
    /// </summary>
    /// <param name="client">The Retell AI client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetCallTool(this RetellAiClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [System.ComponentModel.Description("The unique identifier of the call to retrieve.")]
                string callId,
                CancellationToken cancellationToken) =>
            {
                var call = await client.GetCallAsync(
                    callId: callId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCallResponse(call);
            },
            name: "GetRetellCall",
            description: "Gets details of a specific Retell AI voice call by its ID. Returns call status, agent info, duration, transcript, recording URL, and analysis.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists Retell AI phone numbers.
    /// </summary>
    /// <param name="client">The Retell AI client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListPhoneNumbersTool(this RetellAiClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var phoneNumbers = await client.ListPhoneNumbersAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatPhoneNumberList(phoneNumbers);
            },
            name: "ListRetellPhoneNumbers",
            description: "Lists all Retell AI phone numbers. Returns phone numbers, types, nicknames, and bound agent configurations.");
    }

    private static string FormatAgentList(IList<AgentResponse> agents)
    {
        return JsonSerializer.Serialize(agents.Select(a =>
        {
            var agentId = a.Value1?.AgentId;
            var name = a.Value2?.AgentName;
            var version = a.Value1?.Version;
            var isPublished = a.Value1?.IsPublished;
            var voiceId = a.Value2?.VoiceId;

            return new
            {
                agentId,
                name,
                version,
                isPublished,
                voiceId,
            };
        }));
    }

    private static string FormatAgent(AgentResponse agent)
    {
        return JsonSerializer.Serialize(new
        {
            agentId = agent.Value1?.AgentId,
            name = agent.Value2?.AgentName,
            version = agent.Value1?.Version,
            isPublished = agent.Value1?.IsPublished,
            voiceId = agent.Value2?.VoiceId,
            versionDescription = agent.Value2?.VersionDescription,
        });
    }

    private static string FormatPhoneCallResponse(V2PhoneCallResponse call)
    {
        return JsonSerializer.Serialize(new
        {
            callId = call.Value2?.CallId,
            callStatus = call.Value2?.CallStatus.ToString(),
            agentId = call.Value2?.AgentId,
            agentName = call.Value2?.AgentName,
            callType = call.Value1?.CallType.ToString(),
            fromNumber = call.Value1?.FromNumber,
            toNumber = call.Value1?.ToNumber,
            direction = call.Value1?.Direction.ToString(),
        });
    }

    private static string FormatCallList(IList<V2CallResponse> calls)
    {
        return JsonSerializer.Serialize(calls.Select(c =>
        {
            var callBase = c.Phone?.Value2 ?? c.Web?.Value2;
            var phoneInfo = c.Phone?.Value1;

            return new
            {
                callId = callBase?.CallId,
                callStatus = callBase?.CallStatus.ToString(),
                agentId = callBase?.AgentId,
                agentName = callBase?.AgentName,
                durationMs = callBase?.DurationMs,
                startTimestamp = callBase?.StartTimestamp,
                endTimestamp = callBase?.EndTimestamp,
                callType = c.IsPhone ? "phone_call" : c.IsWeb ? "web_call" : null,
                fromNumber = phoneInfo?.FromNumber,
                toNumber = phoneInfo?.ToNumber,
                direction = phoneInfo?.Direction.ToString(),
            };
        }));
    }

    private static string FormatCallResponse(V2CallResponse call)
    {
        var callBase = call.Phone?.Value2 ?? call.Web?.Value2;
        var phoneInfo = call.Phone?.Value1;

        return JsonSerializer.Serialize(new
        {
            callId = callBase?.CallId,
            callStatus = callBase?.CallStatus.ToString(),
            agentId = callBase?.AgentId,
            agentName = callBase?.AgentName,
            agentVersion = callBase?.AgentVersion,
            durationMs = callBase?.DurationMs,
            startTimestamp = callBase?.StartTimestamp,
            endTimestamp = callBase?.EndTimestamp,
            transcript = callBase?.Transcript,
            recordingUrl = callBase?.RecordingUrl,
            publicLogUrl = callBase?.PublicLogUrl,
            disconnectionReason = callBase?.DisconnectionReason?.ToString(),
            callType = call.IsPhone ? "phone_call" : call.IsWeb ? "web_call" : null,
            fromNumber = phoneInfo?.FromNumber,
            toNumber = phoneInfo?.ToNumber,
            direction = phoneInfo?.Direction.ToString(),
        });
    }

    private static string FormatPhoneNumberList(IList<PhoneNumberResponse> phoneNumbers)
    {
        return JsonSerializer.Serialize(phoneNumbers.Select(p => new
        {
            phoneNumber = p.PhoneNumber,
            phoneNumberPretty = p.PhoneNumberPretty,
            phoneNumberType = p.PhoneNumberType.ToString(),
            nickname = p.Nickname,
            areaCode = p.AreaCode,
        }));
    }
}
