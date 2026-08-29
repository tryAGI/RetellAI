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

            global::RetellAI.NodeBase? @base = default;
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

            global::RetellAI.AgentOverrideConfig? agentOverrideConfig = default;
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

            global::RetellAI.ConversationNodeVariant3? conversationNodeVariant3 = default;
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


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.NodeBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.NodeBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.NodeBase).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Base!.Value, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsAgentOverrideConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.AgentOverrideConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.AgentOverrideConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.AgentOverrideConfig).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.AgentOverrideConfig!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsConversationNodeVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ConversationNodeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ConversationNodeVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ConversationNodeVariant3).Name}");
                var __element2 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.ConversationNodeVariant3!, typeInfo);
                if (__element2.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element2.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}