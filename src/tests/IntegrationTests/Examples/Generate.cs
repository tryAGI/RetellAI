/*
order: 10
title: List Agents
slug: list-agents

Basic example showing how to create a client and list agents.
*/

namespace RetellAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListAgents()
    {
        //// Create a client with your Retell AI API key.
        using var client = GetAuthenticatedClient();

        //// List all agents in your account.
        var agents = await client.ListAgentsAsync();

        agents.Should().NotBeNull();
    }
}
