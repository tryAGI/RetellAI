# CLAUDE.md -- RetellAI SDK

## Overview

Auto-generated C# SDK for [Retell AI](https://www.retellai.com/) -- voice AI agent platform for building, deploying, and managing AI phone agents with real-time voice conversations, call management, phone number provisioning, knowledge bases, and analytics.
OpenAPI spec resolved from the Retell Python SDK's `.stats.yml` (Stainless-hosted YAML).

## Build & Test

```bash
dotnet build RetellAI.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new RetellAiClient(apiKey); // RETELLAI_API_KEY env var
```

## Key Files

- `src/libs/RetellAI/openapi.yaml` -- OpenAPI spec (resolved from `RetellAI/retell-python-sdk/.stats.yml`)
- `src/libs/RetellAI/generate.sh` -- Resolves spec URL from Stainless, downloads, applies fixes, runs autosdk
- `src/libs/RetellAI/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/RetellAI/Extensions/RetellAiClient.AsTool.cs` -- MEAI `AIFunction` tools (agents, calls, phone numbers, phone call creation)
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

The `generate.sh` applies several fixes:

1. **Comparator enum dedup:** Removes symbol duplicates (`>`, `<`, `>=`, `<=`) from `AlertRuleResponse`, `AlertRuleRequest`, `AlertIncidentResponse` comparator enums since text versions (`gt`, `ge`, `lt`, `le`) already exist
2. **Equation operator rename:** Replaces symbols (`==`, `!=`, `>`, `>=`, `<`, `<=`) with descriptive names (`eq`, `ne`, `gt`, `ge`, `lt`, `le`) in `Equation` schema
3. **EquationCondition operator rename:** Replaces `||` and `&&` with `or` and `and` in `EquationCondition` schema
4. **SYSLIB1031 collision fix:** Renames `NullableLLMModel` to `LLMModelNullable` (collides with nullable variant of `LLMModel?` in System.Text.Json source generator)

Uses Python + `sed` for spec fixes (not `jq`/`yq`).
Uses `--exclude-deprecated-operations` flag.
No sub-client pattern -- all operations are on the flat `RetellAiClient`.

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsListAgentsTool(limit)` -- List all voice agents with IDs, names, versions, and published status
- `AsGetAgentTool()` -- Get agent details including voice settings and configuration
- `AsCreatePhoneCallTool()` -- Create an outbound phone call (E.164 format numbers)
- `AsListCallsTool(limit)` -- List recent calls with status, agent info, duration, and timestamps
- `AsGetCallTool()` -- Get call details including transcript, recording URL, and analysis
- `AsListPhoneNumbersTool()` -- List all phone numbers with types, nicknames, and bound agents

No MEAI interface (`IChatClient`, `IEmbeddingGenerator`, `ISpeechToTextClient`) is implemented -- Retell AI is a voice AI agent platform with no matching MEAI interface.
