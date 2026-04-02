#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class ConversationFlowNodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.ConversationFlowNode>
    {
        /// <inheritdoc />
        public override global::RetellAI.ConversationFlowNode Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ConversationNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SubagentNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.EndNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __score3 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.FunctionNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score3++;
                    }
                }
            }
            var __score4 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CodeNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score4++;
                    }
                }
            }
            var __score5 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.TransferCallNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score5++;
                    }
                }
            }
            var __score6 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.PressDigitNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score6++;
                    }
                }
            }
            var __score7 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BranchNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score7++;
                    }
                }
            }
            var __score8 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SmsNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score8++;
                    }
                }
            }
            var __score9 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ExtractDynamicVariablesNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score9++;
                    }
                }
            }
            var __score10 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.AgentSwapNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score10++;
                    }
                }
            }
            var __score11 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.MCPNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score11++;
                    }
                }
            }
            var __score12 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ComponentNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score12++;
                    }
                }
            }
            var __score13 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BridgeTransferNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score13++;
                    }
                }
            }
            var __score14 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CancelTransferNode), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score14++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }

            global::RetellAI.ConversationNode? conversationNode = default;
            global::RetellAI.SubagentNode? subagent = default;
            global::RetellAI.EndNode? end = default;
            global::RetellAI.FunctionNode? function = default;
            global::RetellAI.CodeNode? code = default;
            global::RetellAI.TransferCallNode? transferCall = default;
            global::RetellAI.PressDigitNode? pressDigit = default;
            global::RetellAI.BranchNode? branch = default;
            global::RetellAI.SmsNode? sms = default;
            global::RetellAI.ExtractDynamicVariablesNode? extractDynamicVariables = default;
            global::RetellAI.AgentSwapNode? agentSwap = default;
            global::RetellAI.MCPNode? mcp = default;
            global::RetellAI.ComponentNode? component = default;
            global::RetellAI.BridgeTransferNode? bridgeTransfer = default;
            global::RetellAI.CancelTransferNode? cancelTransfer = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ConversationNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ConversationNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ConversationNode).Name}");
                        conversationNode = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SubagentNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SubagentNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SubagentNode).Name}");
                        subagent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.EndNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.EndNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.EndNode).Name}");
                        end = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.FunctionNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.FunctionNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.FunctionNode).Name}");
                        function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 4)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CodeNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CodeNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CodeNode).Name}");
                        code = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 5)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.TransferCallNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.TransferCallNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.TransferCallNode).Name}");
                        transferCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 6)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.PressDigitNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.PressDigitNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.PressDigitNode).Name}");
                        pressDigit = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 7)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BranchNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BranchNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BranchNode).Name}");
                        branch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 8)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SmsNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SmsNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SmsNode).Name}");
                        sms = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 9)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ExtractDynamicVariablesNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ExtractDynamicVariablesNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ExtractDynamicVariablesNode).Name}");
                        extractDynamicVariables = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 10)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.AgentSwapNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.AgentSwapNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.AgentSwapNode).Name}");
                        agentSwap = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 11)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.MCPNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.MCPNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.MCPNode).Name}");
                        mcp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 12)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ComponentNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ComponentNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ComponentNode).Name}");
                        component = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 13)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BridgeTransferNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BridgeTransferNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BridgeTransferNode).Name}");
                        bridgeTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 14)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CancelTransferNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CancelTransferNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CancelTransferNode).Name}");
                        cancelTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (conversationNode == null && subagent == null && end == null && function == null && code == null && transferCall == null && pressDigit == null && branch == null && sms == null && extractDynamicVariables == null && agentSwap == null && mcp == null && component == null && bridgeTransfer == null && cancelTransfer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ConversationNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ConversationNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ConversationNode).Name}");
                    conversationNode = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SubagentNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SubagentNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SubagentNode).Name}");
                    subagent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.EndNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.EndNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.EndNode).Name}");
                    end = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.FunctionNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.FunctionNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.FunctionNode).Name}");
                    function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CodeNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CodeNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CodeNode).Name}");
                    code = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.TransferCallNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.TransferCallNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.TransferCallNode).Name}");
                    transferCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.PressDigitNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.PressDigitNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.PressDigitNode).Name}");
                    pressDigit = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BranchNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BranchNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BranchNode).Name}");
                    branch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SmsNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SmsNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SmsNode).Name}");
                    sms = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ExtractDynamicVariablesNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ExtractDynamicVariablesNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ExtractDynamicVariablesNode).Name}");
                    extractDynamicVariables = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.AgentSwapNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.AgentSwapNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.AgentSwapNode).Name}");
                    agentSwap = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.MCPNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.MCPNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.MCPNode).Name}");
                    mcp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ComponentNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ComponentNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ComponentNode).Name}");
                    component = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BridgeTransferNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BridgeTransferNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BridgeTransferNode).Name}");
                    bridgeTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CancelTransferNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CancelTransferNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CancelTransferNode).Name}");
                    cancelTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::RetellAI.ConversationFlowNode(
                conversationNode,

                subagent,

                end,

                function,

                code,

                transferCall,

                pressDigit,

                branch,

                sms,

                extractDynamicVariables,

                agentSwap,

                mcp,

                component,

                bridgeTransfer,

                cancelTransfer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.ConversationFlowNode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConversationNode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ConversationNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ConversationNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ConversationNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationNode!.Value, typeInfo);
            }
            else if (value.IsSubagent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SubagentNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SubagentNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SubagentNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Subagent!.Value, typeInfo);
            }
            else if (value.IsEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.EndNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.EndNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.EndNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.End!.Value, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.FunctionNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.FunctionNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.FunctionNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function!.Value, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CodeNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CodeNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CodeNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code!.Value, typeInfo);
            }
            else if (value.IsTransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.TransferCallNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.TransferCallNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.TransferCallNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall!.Value, typeInfo);
            }
            else if (value.IsPressDigit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.PressDigitNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.PressDigitNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.PressDigitNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PressDigit!.Value, typeInfo);
            }
            else if (value.IsBranch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BranchNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BranchNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BranchNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Branch!.Value, typeInfo);
            }
            else if (value.IsSms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SmsNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SmsNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SmsNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms!.Value, typeInfo);
            }
            else if (value.IsExtractDynamicVariables)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ExtractDynamicVariablesNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ExtractDynamicVariablesNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ExtractDynamicVariablesNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExtractDynamicVariables!.Value, typeInfo);
            }
            else if (value.IsAgentSwap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.AgentSwapNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.AgentSwapNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.AgentSwapNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSwap!.Value, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.MCPNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.MCPNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.MCPNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp!.Value, typeInfo);
            }
            else if (value.IsComponent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ComponentNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ComponentNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ComponentNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Component!.Value, typeInfo);
            }
            else if (value.IsBridgeTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BridgeTransferNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BridgeTransferNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BridgeTransferNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BridgeTransfer!.Value, typeInfo);
            }
            else if (value.IsCancelTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CancelTransferNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CancelTransferNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CancelTransferNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CancelTransfer!.Value, typeInfo);
            }
        }
    }
}