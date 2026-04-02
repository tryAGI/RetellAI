#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class ConversationNodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.ConversationNode>
    {
        /// <inheritdoc />
        public override global::RetellAI.ConversationNode Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("interruption_sensitivity")) __score1++;
            if (__jsonProps.Contains("responsiveness")) __score1++;
            if (__jsonProps.Contains("voice_speed")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("always_edge")) __score2++;
            if (__jsonProps.Contains("edges")) __score2++;
            if (__jsonProps.Contains("finetune_conversation_examples")) __score2++;
            if (__jsonProps.Contains("finetune_transition_examples")) __score2++;
            if (__jsonProps.Contains("instruction")) __score2++;
            if (__jsonProps.Contains("knowledge_base_ids")) __score2++;
            if (__jsonProps.Contains("skip_response_edge")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::RetellAI.NodeBase? @base = default;
            global::RetellAI.AgentOverrideConfig? agentOverrideConfig = default;
            global::RetellAI.ConversationNodeVariant3? conversationNodeVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.NodeBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.NodeBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.NodeBase).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.AgentOverrideConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.AgentOverrideConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.AgentOverrideConfig).Name}");
                        agentOverrideConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ConversationNodeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ConversationNodeVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ConversationNodeVariant3).Name}");
                        conversationNodeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && agentOverrideConfig == null && conversationNodeVariant3 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.NodeBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.NodeBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.NodeBase).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.AgentOverrideConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.AgentOverrideConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.AgentOverrideConfig).Name}");
                    agentOverrideConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ConversationNodeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ConversationNodeVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ConversationNodeVariant3).Name}");
                    conversationNodeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::RetellAI.ConversationNode(
                @base,

                agentOverrideConfig,

                conversationNodeVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.ConversationNode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.NodeBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.NodeBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.NodeBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!.Value, typeInfo);
            }
            else if (value.IsAgentOverrideConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.AgentOverrideConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.AgentOverrideConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.AgentOverrideConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentOverrideConfig!, typeInfo);
            }
            else if (value.IsConversationNodeVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ConversationNodeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ConversationNodeVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ConversationNodeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationNodeVariant3!, typeInfo);
            }
        }
    }
}