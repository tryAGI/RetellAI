# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The RetellAI SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models the ability to manage Retell AI voice agents, phone calls, and phone numbers.

## Installation

```bash
dotnet add package RetellAI
```

## List Agents Tool

Use `AsListAgentsTool()` to create an `AIFunction` that lists all Retell AI voice agents.

```csharp
using Microsoft.Extensions.AI;
using RetellAI;

var retellClient = new RetellAiClient(
    apiKey: Environment.GetEnvironmentVariable("RETELLAI_API_KEY")!);

AIFunction listAgentsTool = retellClient.AsListAgentsTool(limit: 20);

// Use with any IChatClient (OpenAI, Anthropic, Ollama, etc.)
IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [listAgentsTool],
};

var response = await chatClient.GetResponseAsync(
    "What voice agents do I have configured?",
    options);

Console.WriteLine(response.Text);
```

## Get Agent Tool

Use `AsGetAgentTool()` to create an `AIFunction` that retrieves details of a specific agent.

```csharp
using Microsoft.Extensions.AI;
using RetellAI;

var retellClient = new RetellAiClient(
    apiKey: Environment.GetEnvironmentVariable("RETELLAI_API_KEY")!);

AIFunction getAgentTool = retellClient.AsGetAgentTool();

IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [getAgentTool],
};

var response = await chatClient.GetResponseAsync(
    "Get the details of agent oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD",
    options);

Console.WriteLine(response.Text);
```

## Create Phone Call Tool

Use `AsCreatePhoneCallTool()` to create an `AIFunction` that initiates outbound phone calls.

```csharp
using Microsoft.Extensions.AI;
using RetellAI;

var retellClient = new RetellAiClient(
    apiKey: Environment.GetEnvironmentVariable("RETELLAI_API_KEY")!);

AIFunction createCallTool = retellClient.AsCreatePhoneCallTool();

IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [createCallTool],
};

var messages = new List<ChatMessage>
{
    new(ChatRole.User,
        "Call +12137774445 from +14157774444 using my support agent."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## List Calls Tool

Use `AsListCallsTool()` to create an `AIFunction` that lists recent voice calls.

```csharp
using Microsoft.Extensions.AI;
using RetellAI;

var retellClient = new RetellAiClient(
    apiKey: Environment.GetEnvironmentVariable("RETELLAI_API_KEY")!);

AIFunction listCallsTool = retellClient.AsListCallsTool(limit: 20);

IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [listCallsTool],
};

var response = await chatClient.GetResponseAsync(
    "Show me the most recent voice calls.",
    options);

Console.WriteLine(response.Text);
```

## Get Call Details Tool

Use `AsGetCallTool()` to create an `AIFunction` that retrieves details of a specific call, including its transcript.

```csharp
using Microsoft.Extensions.AI;
using RetellAI;

var retellClient = new RetellAiClient(
    apiKey: Environment.GetEnvironmentVariable("RETELLAI_API_KEY")!);

AIFunction getCallTool = retellClient.AsGetCallTool();

IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [getCallTool],
};

var response = await chatClient.GetResponseAsync(
    "Get the transcript and details for call Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6",
    options);

Console.WriteLine(response.Text);
```

## List Phone Numbers Tool

Use `AsListPhoneNumbersTool()` to create an `AIFunction` that lists all configured phone numbers.

```csharp
using Microsoft.Extensions.AI;
using RetellAI;

var retellClient = new RetellAiClient(
    apiKey: Environment.GetEnvironmentVariable("RETELLAI_API_KEY")!);

AIFunction listPhoneNumbersTool = retellClient.AsListPhoneNumbersTool();

IChatClient chatClient = /* your chat client */;

var options = new ChatOptions
{
    Tools = [listPhoneNumbersTool],
};

var response = await chatClient.GetResponseAsync(
    "What phone numbers do I have available?",
    options);

Console.WriteLine(response.Text);
```

## Combining All Tools

You can provide all six tools simultaneously, letting the model decide which to use.

```csharp
using Microsoft.Extensions.AI;
using RetellAI;

var retellClient = new RetellAiClient(
    apiKey: Environment.GetEnvironmentVariable("RETELLAI_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        retellClient.AsListAgentsTool(),
        retellClient.AsGetAgentTool(),
        retellClient.AsCreatePhoneCallTool(),
        retellClient.AsListCallsTool(),
        retellClient.AsGetCallTool(),
        retellClient.AsListPhoneNumbersTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User,
        "Check what phone numbers I have, then list my agents. " +
        "If I have both, make a call from the first number to +12025551234."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## Tool Details

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListAgentsTool()` | `ListRetellAgents` | Lists all voice agents with IDs, names, and status |
| `AsGetAgentTool()` | `GetRetellAgent` | Gets details of a specific agent by ID |
| `AsCreatePhoneCallTool()` | `CreateRetellPhoneCall` | Creates an outbound phone call |
| `AsListCallsTool()` | `ListRetellCalls` | Lists recent voice calls with status and duration |
| `AsGetCallTool()` | `GetRetellCall` | Gets call details including transcript and recording |
| `AsListPhoneNumbersTool()` | `ListRetellPhoneNumbers` | Lists all configured phone numbers |

### AsListAgentsTool Parameters

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `limit` | `int` | `50` | Maximum number of agents to return |

### AsListCallsTool Parameters

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `limit` | `int` | `50` | Maximum number of calls to return |
