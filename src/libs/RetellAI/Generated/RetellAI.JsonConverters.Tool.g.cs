#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class ToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.Tool>
    {
        /// <inheritdoc />
        public override global::RetellAI.Tool Read(
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
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("execution_message_description")) __score0++;
            if (__jsonProps.Contains("execution_message_type")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("speak_during_execution")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("custom_sip_headers")) __score1++;
            if (__jsonProps.Contains("description")) __score1++;
            if (__jsonProps.Contains("execution_message_description")) __score1++;
            if (__jsonProps.Contains("execution_message_type")) __score1++;
            if (__jsonProps.Contains("ignore_e164_validation")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("speak_during_execution")) __score1++;
            if (__jsonProps.Contains("transfer_destination")) __score1++;
            if (__jsonProps.Contains("transfer_option")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("cal_api_key")) __score2++;
            if (__jsonProps.Contains("description")) __score2++;
            if (__jsonProps.Contains("event_type_id")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("timezone")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("cal_api_key")) __score3++;
            if (__jsonProps.Contains("description")) __score3++;
            if (__jsonProps.Contains("event_type_id")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("timezone")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("agent_id")) __score4++;
            if (__jsonProps.Contains("agent_version")) __score4++;
            if (__jsonProps.Contains("description")) __score4++;
            if (__jsonProps.Contains("execution_message_description")) __score4++;
            if (__jsonProps.Contains("execution_message_type")) __score4++;
            if (__jsonProps.Contains("keep_current_language")) __score4++;
            if (__jsonProps.Contains("keep_current_voice")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("post_call_analysis_setting")) __score4++;
            if (__jsonProps.Contains("speak_during_execution")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("webhook_setting")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("delay_ms")) __score5++;
            if (__jsonProps.Contains("description")) __score5++;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("description")) __score6++;
            if (__jsonProps.Contains("execution_message_description")) __score6++;
            if (__jsonProps.Contains("execution_message_type")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("sms_content")) __score6++;
            if (__jsonProps.Contains("speak_during_execution")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("args_at_root")) __score7++;
            if (__jsonProps.Contains("description")) __score7++;
            if (__jsonProps.Contains("execution_message_description")) __score7++;
            if (__jsonProps.Contains("execution_message_type")) __score7++;
            if (__jsonProps.Contains("headers")) __score7++;
            if (__jsonProps.Contains("method")) __score7++;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("parameters")) __score7++;
            if (__jsonProps.Contains("query_params")) __score7++;
            if (__jsonProps.Contains("response_variables")) __score7++;
            if (__jsonProps.Contains("speak_after_execution")) __score7++;
            if (__jsonProps.Contains("speak_during_execution")) __score7++;
            if (__jsonProps.Contains("timeout_ms")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("url")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("code")) __score8++;
            if (__jsonProps.Contains("description")) __score8++;
            if (__jsonProps.Contains("execution_message_description")) __score8++;
            if (__jsonProps.Contains("execution_message_type")) __score8++;
            if (__jsonProps.Contains("name")) __score8++;
            if (__jsonProps.Contains("response_variables")) __score8++;
            if (__jsonProps.Contains("speak_after_execution")) __score8++;
            if (__jsonProps.Contains("speak_during_execution")) __score8++;
            if (__jsonProps.Contains("timeout_ms")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("description")) __score9++;
            if (__jsonProps.Contains("name")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            if (__jsonProps.Contains("variables")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("description")) __score10++;
            if (__jsonProps.Contains("execution_message_description")) __score10++;
            if (__jsonProps.Contains("execution_message_type")) __score10++;
            if (__jsonProps.Contains("name")) __score10++;
            if (__jsonProps.Contains("speak_during_execution")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("description")) __score11++;
            if (__jsonProps.Contains("execution_message_description")) __score11++;
            if (__jsonProps.Contains("execution_message_type")) __score11++;
            if (__jsonProps.Contains("name")) __score11++;
            if (__jsonProps.Contains("speak_during_execution")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("description")) __score12++;
            if (__jsonProps.Contains("execution_message_description")) __score12++;
            if (__jsonProps.Contains("execution_message_type")) __score12++;
            if (__jsonProps.Contains("input_schema")) __score12++;
            if (__jsonProps.Contains("mcp_id")) __score12++;
            if (__jsonProps.Contains("name")) __score12++;
            if (__jsonProps.Contains("response_variables")) __score12++;
            if (__jsonProps.Contains("speak_after_execution")) __score12++;
            if (__jsonProps.Contains("speak_during_execution")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
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

            global::RetellAI.EndCallTool? endCall = default;
            global::RetellAI.TransferCallTool? transferCall = default;
            global::RetellAI.CheckAvailabilityCalTool? checkAvailabilityCal = default;
            global::RetellAI.BookAppointmentCalTool? bookAppointmentCal = default;
            global::RetellAI.AgentSwapTool? agentSwap = default;
            global::RetellAI.PressDigitTool? pressDigit = default;
            global::RetellAI.SendSMSTool? sendSM = default;
            global::RetellAI.CustomTool? custom = default;
            global::RetellAI.CodeTool? code = default;
            global::RetellAI.ExtractDynamicVariableTool? extractDynamicVariable = default;
            global::RetellAI.BridgeTransferTool? bridgeTransfer = default;
            global::RetellAI.CancelTransferTool? cancelTransfer = default;
            global::RetellAI.MCPTool? mcp = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.EndCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.EndCallTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.EndCallTool).Name}");
                        endCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.TransferCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.TransferCallTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.TransferCallTool).Name}");
                        transferCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CheckAvailabilityCalTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CheckAvailabilityCalTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CheckAvailabilityCalTool).Name}");
                        checkAvailabilityCal = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BookAppointmentCalTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BookAppointmentCalTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BookAppointmentCalTool).Name}");
                        bookAppointmentCal = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.AgentSwapTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.AgentSwapTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.AgentSwapTool).Name}");
                        agentSwap = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.PressDigitTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.PressDigitTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.PressDigitTool).Name}");
                        pressDigit = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SendSMSTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SendSMSTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SendSMSTool).Name}");
                        sendSM = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CustomTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CustomTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CustomTool).Name}");
                        custom = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CodeTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CodeTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CodeTool).Name}");
                        code = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ExtractDynamicVariableTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ExtractDynamicVariableTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ExtractDynamicVariableTool).Name}");
                        extractDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BridgeTransferTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BridgeTransferTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BridgeTransferTool).Name}");
                        bridgeTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CancelTransferTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CancelTransferTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CancelTransferTool).Name}");
                        cancelTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.MCPTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.MCPTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.MCPTool).Name}");
                        mcp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (endCall == null && transferCall == null && checkAvailabilityCal == null && bookAppointmentCal == null && agentSwap == null && pressDigit == null && sendSM == null && custom == null && code == null && extractDynamicVariable == null && bridgeTransfer == null && cancelTransfer == null && mcp == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.EndCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.EndCallTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.EndCallTool).Name}");
                    endCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.TransferCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.TransferCallTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.TransferCallTool).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CheckAvailabilityCalTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CheckAvailabilityCalTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CheckAvailabilityCalTool).Name}");
                    checkAvailabilityCal = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BookAppointmentCalTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BookAppointmentCalTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BookAppointmentCalTool).Name}");
                    bookAppointmentCal = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.AgentSwapTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.AgentSwapTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.AgentSwapTool).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.PressDigitTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.PressDigitTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.PressDigitTool).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SendSMSTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SendSMSTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SendSMSTool).Name}");
                    sendSM = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CustomTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CustomTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CustomTool).Name}");
                    custom = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CodeTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CodeTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CodeTool).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ExtractDynamicVariableTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ExtractDynamicVariableTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ExtractDynamicVariableTool).Name}");
                    extractDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BridgeTransferTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BridgeTransferTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BridgeTransferTool).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CancelTransferTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CancelTransferTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CancelTransferTool).Name}");
                    cancelTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.MCPTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.MCPTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.MCPTool).Name}");
                    mcp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::RetellAI.Tool(
                endCall,

                transferCall,

                checkAvailabilityCal,

                bookAppointmentCal,

                agentSwap,

                pressDigit,

                sendSM,

                custom,

                code,

                extractDynamicVariable,

                bridgeTransfer,

                cancelTransfer,

                mcp
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.Tool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.EndCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.EndCallTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.EndCallTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall!, typeInfo);
            }
            else if (value.IsTransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.TransferCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.TransferCallTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.TransferCallTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall!, typeInfo);
            }
            else if (value.IsCheckAvailabilityCal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CheckAvailabilityCalTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CheckAvailabilityCalTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CheckAvailabilityCalTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CheckAvailabilityCal!, typeInfo);
            }
            else if (value.IsBookAppointmentCal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BookAppointmentCalTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BookAppointmentCalTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BookAppointmentCalTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BookAppointmentCal!, typeInfo);
            }
            else if (value.IsAgentSwap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.AgentSwapTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.AgentSwapTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.AgentSwapTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSwap!, typeInfo);
            }
            else if (value.IsPressDigit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.PressDigitTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.PressDigitTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.PressDigitTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PressDigit!, typeInfo);
            }
            else if (value.IsSendSM)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.SendSMSTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.SendSMSTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.SendSMSTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SendSM!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CustomTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CustomTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CustomTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CodeTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CodeTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CodeTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code!, typeInfo);
            }
            else if (value.IsExtractDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ExtractDynamicVariableTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ExtractDynamicVariableTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ExtractDynamicVariableTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExtractDynamicVariable!, typeInfo);
            }
            else if (value.IsBridgeTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BridgeTransferTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BridgeTransferTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BridgeTransferTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BridgeTransfer!, typeInfo);
            }
            else if (value.IsCancelTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CancelTransferTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CancelTransferTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CancelTransferTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CancelTransfer!, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.MCPTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.MCPTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.MCPTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp!, typeInfo);
            }
        }
    }
}