#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class ChatMessageInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.ChatMessageInput>
    {
        /// <inheritdoc />
        public override global::RetellAI.ChatMessageInput Read(
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
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("created_timestamp")) __score0++;
            if (__jsonProps.Contains("message_id")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("arguments")) __score1++;
            if (__jsonProps.Contains("created_timestamp")) __score1++;
            if (__jsonProps.Contains("message_id")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("thought_signature")) __score1++;
            if (__jsonProps.Contains("tool_call_id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("created_timestamp")) __score2++;
            if (__jsonProps.Contains("message_id")) __score2++;
            if (__jsonProps.Contains("role")) __score2++;
            if (__jsonProps.Contains("successful")) __score2++;
            if (__jsonProps.Contains("tool_call_id")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("created_timestamp")) __score3++;
            if (__jsonProps.Contains("former_node_id")) __score3++;
            if (__jsonProps.Contains("former_node_name")) __score3++;
            if (__jsonProps.Contains("message_id")) __score3++;
            if (__jsonProps.Contains("new_node_id")) __score3++;
            if (__jsonProps.Contains("new_node_name")) __score3++;
            if (__jsonProps.Contains("role")) __score3++;
            if (__jsonProps.Contains("transition_type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("created_timestamp")) __score4++;
            if (__jsonProps.Contains("former_state_name")) __score4++;
            if (__jsonProps.Contains("message_id")) __score4++;
            if (__jsonProps.Contains("new_state_name")) __score4++;
            if (__jsonProps.Contains("role")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::RetellAI.MessageBase? @base = default;
            global::RetellAI.ToolCallInvocationMessageBase? toolCallInvocationBase = default;
            global::RetellAI.ToolCallResultMessageBase? toolCallResultBase = default;
            global::RetellAI.NodeTransitionMessageBase? nodeTransitionBase = default;
            global::RetellAI.StateTransitionMessageBase? stateTransitionBase = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.MessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.MessageBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.MessageBase).Name}");
                        @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ToolCallInvocationMessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ToolCallInvocationMessageBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ToolCallInvocationMessageBase).Name}");
                        toolCallInvocationBase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ToolCallResultMessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ToolCallResultMessageBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ToolCallResultMessageBase).Name}");
                        toolCallResultBase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.NodeTransitionMessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.NodeTransitionMessageBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.NodeTransitionMessageBase).Name}");
                        nodeTransitionBase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.StateTransitionMessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.StateTransitionMessageBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.StateTransitionMessageBase).Name}");
                        stateTransitionBase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && toolCallInvocationBase == null && toolCallResultBase == null && nodeTransitionBase == null && stateTransitionBase == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.MessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.MessageBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.MessageBase).Name}");
                    @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ToolCallInvocationMessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ToolCallInvocationMessageBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ToolCallInvocationMessageBase).Name}");
                    toolCallInvocationBase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ToolCallResultMessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ToolCallResultMessageBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ToolCallResultMessageBase).Name}");
                    toolCallResultBase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.NodeTransitionMessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.NodeTransitionMessageBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.NodeTransitionMessageBase).Name}");
                    nodeTransitionBase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.StateTransitionMessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.StateTransitionMessageBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.StateTransitionMessageBase).Name}");
                    stateTransitionBase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::RetellAI.ChatMessageInput(
                @base,

                toolCallInvocationBase,

                toolCallResultBase,

                nodeTransitionBase,

                stateTransitionBase
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.ChatMessageInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.MessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.MessageBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.MessageBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!, typeInfo);
            }
            else if (value.IsToolCallInvocationBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ToolCallInvocationMessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ToolCallInvocationMessageBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ToolCallInvocationMessageBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallInvocationBase!, typeInfo);
            }
            else if (value.IsToolCallResultBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ToolCallResultMessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ToolCallResultMessageBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ToolCallResultMessageBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallResultBase!, typeInfo);
            }
            else if (value.IsNodeTransitionBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.NodeTransitionMessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.NodeTransitionMessageBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.NodeTransitionMessageBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeTransitionBase!, typeInfo);
            }
            else if (value.IsStateTransitionBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.StateTransitionMessageBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.StateTransitionMessageBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.StateTransitionMessageBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StateTransitionBase!, typeInfo);
            }
        }
    }
}