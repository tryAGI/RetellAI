# RetellAI

[![Nuget package](https://img.shields.io/nuget/vpre/RetellAI)](https://www.nuget.org/packages/RetellAI/)
[![dotnet](https://github.com/tryAGI/RetellAI/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/RetellAI/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/RetellAI)](https://github.com/tryAGI/RetellAI/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official RetellAI OpenAPI specification](https://storage.googleapis.com/stainless-sdk-openapi-specs/retell%2Fretell-3aa6f6e028ef4d49bed8719dd097acb4c8d9d6afa27a499faa2e9d02782ac2bd.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Supports .NET 10.0

### Usage
```csharp
using RetellAI;

using var client = new RetellAiClient(apiKey);
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/RetellAI/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/RetellAI/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
