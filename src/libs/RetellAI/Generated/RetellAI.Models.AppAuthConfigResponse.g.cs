#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Non-secret auth metadata. Encrypted secret fields are never returned by the API.
    /// </summary>
    public readonly partial struct AppAuthConfigResponse : global::System.IEquatable<AppAuthConfigResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.OAuthConfigResponse? O { get; init; }
#else
        public global::RetellAI.OAuthConfigResponse? O { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(O))]
#endif
        public bool IsO => O != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickO(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.OAuthConfigResponse? value)
        {
            value = O;
            return IsO;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.OAuthConfigResponse PickO() => IsO
            ? O!
            : throw new global::System.InvalidOperationException($"Expected union variant 'O' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ApiKeyAuthConfigResponse? ApiKey { get; init; }
#else
        public global::RetellAI.ApiKeyAuthConfigResponse? ApiKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKey))]
#endif
        public bool IsApiKey => ApiKey != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApiKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.ApiKeyAuthConfigResponse? value)
        {
            value = ApiKey;
            return IsApiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.ApiKeyAuthConfigResponse PickApiKey() => IsApiKey
            ? ApiKey!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiKey' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AccessTokenAuthConfigResponse? AccessToken { get; init; }
#else
        public global::RetellAI.AccessTokenAuthConfigResponse? AccessToken { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AccessToken))]
#endif
        public bool IsAccessToken => AccessToken != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAccessToken(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.AccessTokenAuthConfigResponse? value)
        {
            value = AccessToken;
            return IsAccessToken;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.AccessTokenAuthConfigResponse PickAccessToken() => IsAccessToken
            ? AccessToken!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AccessToken' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.BasicAuthConfigResponse? Basic { get; init; }
#else
        public global::RetellAI.BasicAuthConfigResponse? Basic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Basic))]
#endif
        public bool IsBasic => Basic != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBasic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.BasicAuthConfigResponse? value)
        {
            value = Basic;
            return IsBasic;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.BasicAuthConfigResponse PickBasic() => IsBasic
            ? Basic!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Basic' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.RefreshTokenAuthConfigResponse? RefreshToken { get; init; }
#else
        public global::RetellAI.RefreshTokenAuthConfigResponse? RefreshToken { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefreshToken))]
#endif
        public bool IsRefreshToken => RefreshToken != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRefreshToken(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.RefreshTokenAuthConfigResponse? value)
        {
            value = RefreshToken;
            return IsRefreshToken;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.RefreshTokenAuthConfigResponse PickRefreshToken() => IsRefreshToken
            ? RefreshToken!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RefreshToken' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AppAuthConfigResponse(global::RetellAI.OAuthConfigResponse value) => new AppAuthConfigResponse((global::RetellAI.OAuthConfigResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.OAuthConfigResponse?(AppAuthConfigResponse @this) => @this.O;

        /// <summary>
        /// 
        /// </summary>
        public AppAuthConfigResponse(global::RetellAI.OAuthConfigResponse? value)
        {
            O = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AppAuthConfigResponse FromO(global::RetellAI.OAuthConfigResponse? value) => new AppAuthConfigResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AppAuthConfigResponse(global::RetellAI.ApiKeyAuthConfigResponse value) => new AppAuthConfigResponse((global::RetellAI.ApiKeyAuthConfigResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ApiKeyAuthConfigResponse?(AppAuthConfigResponse @this) => @this.ApiKey;

        /// <summary>
        /// 
        /// </summary>
        public AppAuthConfigResponse(global::RetellAI.ApiKeyAuthConfigResponse? value)
        {
            ApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AppAuthConfigResponse FromApiKey(global::RetellAI.ApiKeyAuthConfigResponse? value) => new AppAuthConfigResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AppAuthConfigResponse(global::RetellAI.AccessTokenAuthConfigResponse value) => new AppAuthConfigResponse((global::RetellAI.AccessTokenAuthConfigResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.AccessTokenAuthConfigResponse?(AppAuthConfigResponse @this) => @this.AccessToken;

        /// <summary>
        /// 
        /// </summary>
        public AppAuthConfigResponse(global::RetellAI.AccessTokenAuthConfigResponse? value)
        {
            AccessToken = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AppAuthConfigResponse FromAccessToken(global::RetellAI.AccessTokenAuthConfigResponse? value) => new AppAuthConfigResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AppAuthConfigResponse(global::RetellAI.BasicAuthConfigResponse value) => new AppAuthConfigResponse((global::RetellAI.BasicAuthConfigResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.BasicAuthConfigResponse?(AppAuthConfigResponse @this) => @this.Basic;

        /// <summary>
        /// 
        /// </summary>
        public AppAuthConfigResponse(global::RetellAI.BasicAuthConfigResponse? value)
        {
            Basic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AppAuthConfigResponse FromBasic(global::RetellAI.BasicAuthConfigResponse? value) => new AppAuthConfigResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AppAuthConfigResponse(global::RetellAI.RefreshTokenAuthConfigResponse value) => new AppAuthConfigResponse((global::RetellAI.RefreshTokenAuthConfigResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.RefreshTokenAuthConfigResponse?(AppAuthConfigResponse @this) => @this.RefreshToken;

        /// <summary>
        /// 
        /// </summary>
        public AppAuthConfigResponse(global::RetellAI.RefreshTokenAuthConfigResponse? value)
        {
            RefreshToken = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AppAuthConfigResponse FromRefreshToken(global::RetellAI.RefreshTokenAuthConfigResponse? value) => new AppAuthConfigResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public AppAuthConfigResponse(
            global::RetellAI.OAuthConfigResponse? o,
            global::RetellAI.ApiKeyAuthConfigResponse? apiKey,
            global::RetellAI.AccessTokenAuthConfigResponse? accessToken,
            global::RetellAI.BasicAuthConfigResponse? basic,
            global::RetellAI.RefreshTokenAuthConfigResponse? refreshToken
            )
        {
            O = o;
            ApiKey = apiKey;
            AccessToken = accessToken;
            Basic = basic;
            RefreshToken = refreshToken;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RefreshToken as object ??
            Basic as object ??
            AccessToken as object ??
            ApiKey as object ??
            O as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            O?.ToString() ??
            ApiKey?.ToString() ??
            AccessToken?.ToString() ??
            Basic?.ToString() ??
            RefreshToken?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsO && !IsApiKey && !IsAccessToken && !IsBasic && !IsRefreshToken || !IsO && IsApiKey && !IsAccessToken && !IsBasic && !IsRefreshToken || !IsO && !IsApiKey && IsAccessToken && !IsBasic && !IsRefreshToken || !IsO && !IsApiKey && !IsAccessToken && IsBasic && !IsRefreshToken || !IsO && !IsApiKey && !IsAccessToken && !IsBasic && IsRefreshToken;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.OAuthConfigResponse, TResult>? o = null,
            global::System.Func<global::RetellAI.ApiKeyAuthConfigResponse, TResult>? apiKey = null,
            global::System.Func<global::RetellAI.AccessTokenAuthConfigResponse, TResult>? accessToken = null,
            global::System.Func<global::RetellAI.BasicAuthConfigResponse, TResult>? basic = null,
            global::System.Func<global::RetellAI.RefreshTokenAuthConfigResponse, TResult>? refreshToken = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsO && o != null)
            {
                return o(O!);
            }
            else if (IsApiKey && apiKey != null)
            {
                return apiKey(ApiKey!);
            }
            else if (IsAccessToken && accessToken != null)
            {
                return accessToken(AccessToken!);
            }
            else if (IsBasic && basic != null)
            {
                return basic(Basic!);
            }
            else if (IsRefreshToken && refreshToken != null)
            {
                return refreshToken(RefreshToken!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.OAuthConfigResponse>? o = null,

            global::System.Action<global::RetellAI.ApiKeyAuthConfigResponse>? apiKey = null,

            global::System.Action<global::RetellAI.AccessTokenAuthConfigResponse>? accessToken = null,

            global::System.Action<global::RetellAI.BasicAuthConfigResponse>? basic = null,

            global::System.Action<global::RetellAI.RefreshTokenAuthConfigResponse>? refreshToken = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsO)
            {
                o?.Invoke(O!);
            }
            else if (IsApiKey)
            {
                apiKey?.Invoke(ApiKey!);
            }
            else if (IsAccessToken)
            {
                accessToken?.Invoke(AccessToken!);
            }
            else if (IsBasic)
            {
                basic?.Invoke(Basic!);
            }
            else if (IsRefreshToken)
            {
                refreshToken?.Invoke(RefreshToken!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.OAuthConfigResponse>? o = null,
            global::System.Action<global::RetellAI.ApiKeyAuthConfigResponse>? apiKey = null,
            global::System.Action<global::RetellAI.AccessTokenAuthConfigResponse>? accessToken = null,
            global::System.Action<global::RetellAI.BasicAuthConfigResponse>? basic = null,
            global::System.Action<global::RetellAI.RefreshTokenAuthConfigResponse>? refreshToken = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsO)
            {
                o?.Invoke(O!);
            }
            else if (IsApiKey)
            {
                apiKey?.Invoke(ApiKey!);
            }
            else if (IsAccessToken)
            {
                accessToken?.Invoke(AccessToken!);
            }
            else if (IsBasic)
            {
                basic?.Invoke(Basic!);
            }
            else if (IsRefreshToken)
            {
                refreshToken?.Invoke(RefreshToken!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                O,
                typeof(global::RetellAI.OAuthConfigResponse),
                ApiKey,
                typeof(global::RetellAI.ApiKeyAuthConfigResponse),
                AccessToken,
                typeof(global::RetellAI.AccessTokenAuthConfigResponse),
                Basic,
                typeof(global::RetellAI.BasicAuthConfigResponse),
                RefreshToken,
                typeof(global::RetellAI.RefreshTokenAuthConfigResponse),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(AppAuthConfigResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.OAuthConfigResponse?>.Default.Equals(O, other.O) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ApiKeyAuthConfigResponse?>.Default.Equals(ApiKey, other.ApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AccessTokenAuthConfigResponse?>.Default.Equals(AccessToken, other.AccessToken) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.BasicAuthConfigResponse?>.Default.Equals(Basic, other.Basic) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.RefreshTokenAuthConfigResponse?>.Default.Equals(RefreshToken, other.RefreshToken) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AppAuthConfigResponse obj1, AppAuthConfigResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAuthConfigResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AppAuthConfigResponse obj1, AppAuthConfigResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAuthConfigResponse o && Equals(o);
        }
    }
}
