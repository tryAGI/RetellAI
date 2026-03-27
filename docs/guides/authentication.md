# Authentication

The RetellAI SDK uses **Bearer token authentication** with your Retell AI API key.

## Getting Your API Key

1. Sign in to the [Retell AI Dashboard](https://dashboard.retellai.com/)
2. Navigate to **Settings** > **API Keys**
3. Copy your API key

## Basic Usage

```csharp
using RetellAI;

var client = new RetellAiClient(apiKey: "your-api-key");
```

## Using Environment Variables

Store your API key in an environment variable for security:

```csharp
var apiKey = Environment.GetEnvironmentVariable("RETELLAI_API_KEY")
    ?? throw new InvalidOperationException("RETELLAI_API_KEY not set");

var client = new RetellAiClient(apiKey: apiKey);
```

## API Key Format

Retell AI API keys use the `Bearer` authentication scheme. The SDK handles the `Authorization: Bearer <key>` header automatically.
