#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace RetellAI.JsonConverters
{
    /// <inheritdoc />
    public class AuthConfigRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::RetellAI.AuthConfigRequest>
    {
        /// <inheritdoc />
        public override global::RetellAI.AuthConfigRequest Read(
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
            if (__jsonProps.Contains("client_id")) __score0++;
            if (__jsonProps.Contains("client_secret")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("api_key")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("access_token")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("password")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("username")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("refresh_token")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::RetellAI.OAuthConfigRequest? o = default;
            global::RetellAI.ApiKeyAuthConfigRequest? apiKey = default;
            global::RetellAI.AccessTokenAuthConfigRequest? accessToken = default;
            global::RetellAI.BasicAuthConfigRequest? basic = default;
            global::RetellAI.RefreshTokenAuthConfigRequest? refreshToken = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.OAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.OAuthConfigRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.OAuthConfigRequest).Name}");
                        o = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ApiKeyAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ApiKeyAuthConfigRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ApiKeyAuthConfigRequest).Name}");
                        apiKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.AccessTokenAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.AccessTokenAuthConfigRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.AccessTokenAuthConfigRequest).Name}");
                        accessToken = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BasicAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BasicAuthConfigRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BasicAuthConfigRequest).Name}");
                        basic = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.RefreshTokenAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.RefreshTokenAuthConfigRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.RefreshTokenAuthConfigRequest).Name}");
                        refreshToken = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (o == null && apiKey == null && accessToken == null && basic == null && refreshToken == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.OAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.OAuthConfigRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.OAuthConfigRequest).Name}");
                    o = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (o == null && apiKey == null && accessToken == null && basic == null && refreshToken == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ApiKeyAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ApiKeyAuthConfigRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ApiKeyAuthConfigRequest).Name}");
                    apiKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (o == null && apiKey == null && accessToken == null && basic == null && refreshToken == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.AccessTokenAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.AccessTokenAuthConfigRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.AccessTokenAuthConfigRequest).Name}");
                    accessToken = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (o == null && apiKey == null && accessToken == null && basic == null && refreshToken == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BasicAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BasicAuthConfigRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BasicAuthConfigRequest).Name}");
                    basic = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (o == null && apiKey == null && accessToken == null && basic == null && refreshToken == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.RefreshTokenAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.RefreshTokenAuthConfigRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.RefreshTokenAuthConfigRequest).Name}");
                    refreshToken = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::RetellAI.AuthConfigRequest(
                o,

                apiKey,

                accessToken,

                basic,

                refreshToken
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::RetellAI.AuthConfigRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsO)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.OAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.OAuthConfigRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.OAuthConfigRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.O!, typeInfo);
            }
            else if (value.IsApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.ApiKeyAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.ApiKeyAuthConfigRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.ApiKeyAuthConfigRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey!, typeInfo);
            }
            else if (value.IsAccessToken)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.AccessTokenAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.AccessTokenAuthConfigRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.AccessTokenAuthConfigRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AccessToken!, typeInfo);
            }
            else if (value.IsBasic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.BasicAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.BasicAuthConfigRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.BasicAuthConfigRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Basic!, typeInfo);
            }
            else if (value.IsRefreshToken)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::RetellAI.RefreshTokenAuthConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::RetellAI.RefreshTokenAuthConfigRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::RetellAI.RefreshTokenAuthConfigRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RefreshToken!, typeInfo);
            }
        }
    }
}