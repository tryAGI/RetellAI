#nullable enable
#pragma warning disable CS1591

namespace RetellAI;

public readonly partial struct AgentResponse
{
    public AgentResponseVariant1? Value1 => AgentResponseVariant1;

    public AgentRequest? Value2 => Request;
}

public readonly partial struct V2PhoneCallResponse
{
    public V2PhoneCallResponseVariant1? Value1 => V2PhoneCallResponseVariant1;

    public V2CallBase? Value2 => Base;
}

public readonly partial struct V2WebCallResponse
{
    public V2WebCallResponseVariant1? Value1 => V2WebCallResponseVariant1;

    public V2CallBase? Value2 => Base;
}
