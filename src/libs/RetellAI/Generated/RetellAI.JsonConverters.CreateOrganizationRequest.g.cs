#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class CreateOrganizationRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.CreateOrganizationRequest>
    {
        /// <inheritdoc />
        public override global::RetellAI.CreateOrganizationRequest Read(
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
            if (__jsonProps.Contains("org_name")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("orgName")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::RetellAI.CreateOrganizationRequestNew? @new = default;
            global::RetellAI.CreateOrganizationRequestOld? old = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CreateOrganizationRequestNew), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CreateOrganizationRequestNew> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CreateOrganizationRequestNew).Name}");
                        @new = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CreateOrganizationRequestOld), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CreateOrganizationRequestOld> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CreateOrganizationRequestOld).Name}");
                        old = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@new == null && old == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CreateOrganizationRequestNew), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CreateOrganizationRequestNew> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CreateOrganizationRequestNew).Name}");
                    @new = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CreateOrganizationRequestOld), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CreateOrganizationRequestOld> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CreateOrganizationRequestOld).Name}");
                    old = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::RetellAI.CreateOrganizationRequest(
                @new,

                old
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.CreateOrganizationRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNew)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CreateOrganizationRequestNew), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CreateOrganizationRequestNew?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CreateOrganizationRequestNew).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.New, typeInfo);
            }
            else if (value.IsOld)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.CreateOrganizationRequestOld), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.CreateOrganizationRequestOld?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.CreateOrganizationRequestOld).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Old, typeInfo);
            }
        }
    }
}