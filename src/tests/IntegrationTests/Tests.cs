namespace RetellAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static RetellAiClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("RETELLAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("RETELLAI_API_KEY environment variable is not found.");

        var client = new RetellAiClient(apiKey);
        
        return client;
    }
}
