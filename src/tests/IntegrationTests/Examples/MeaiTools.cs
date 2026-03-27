/*
order: 20
title: MEAI Tools
slug: meai-tools

Shows how to create MEAI AIFunction tools from the RetellAI client
for use with any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace RetellAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ToolsAreCreatedSuccessfully()
    {
        //// Create a RetellAI client with a test API key.
        var client = new RetellAiClient(apiKey: "test-key");

        //// Create AIFunction tools from the client.
        var tools = new AIFunction[]
        {
            client.AsListAgentsTool(),
            client.AsGetAgentTool(),
            client.AsCreatePhoneCallTool(),
            client.AsListCallsTool(),
            client.AsGetCallTool(),
            client.AsListPhoneNumbersTool(),
        };

        //// Verify all tools are created with valid names and descriptions.
        foreach (var tool in tools)
        {
            tool.Should().NotBeNull();
            tool.Name.Should().NotBeNullOrEmpty();
            tool.Description.Should().NotBeNullOrEmpty();
        }

        tools.Should().HaveCount(6);
    }
}
