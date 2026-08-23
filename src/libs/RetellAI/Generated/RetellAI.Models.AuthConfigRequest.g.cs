#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AuthConfigRequest : global::System.IEquatable<AuthConfigRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.OAuthConfigRequest? O { get; init; }
#else
        public global::RetellAI.OAuthConfigRequest? O { get; }
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
            out global::RetellAI.OAuthConfigRequest? value)
        {
            value = O;
            return IsO;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.OAuthConfigRequest PickO() => IsO
            ? O!
            : throw new global::System.InvalidOperationException($"Expected union variant 'O' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ApiKeyAuthConfigRequest? ApiKey { get; init; }
#else
        public global::RetellAI.ApiKeyAuthConfigRequest? ApiKey { get; }
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
            out global::RetellAI.ApiKeyAuthConfigRequest? value)
        {
            value = ApiKey;
            return IsApiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.ApiKeyAuthConfigRequest PickApiKey() => IsApiKey
            ? ApiKey!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiKey' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.AccessTokenAuthConfigRequest? AccessToken { get; init; }
#else
        public global::RetellAI.AccessTokenAuthConfigRequest? AccessToken { get; }
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
            out global::RetellAI.AccessTokenAuthConfigRequest? value)
        {
            value = AccessToken;
            return IsAccessToken;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.AccessTokenAuthConfigRequest PickAccessToken() => IsAccessToken
            ? AccessToken!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AccessToken' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.BasicAuthConfigRequest? Basic { get; init; }
#else
        public global::RetellAI.BasicAuthConfigRequest? Basic { get; }
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
            out global::RetellAI.BasicAuthConfigRequest? value)
        {
            value = Basic;
            return IsBasic;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.BasicAuthConfigRequest PickBasic() => IsBasic
            ? Basic!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Basic' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.RefreshTokenAuthConfigRequest? RefreshToken { get; init; }
#else
        public global::RetellAI.RefreshTokenAuthConfigRequest? RefreshToken { get; }
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
            out global::RetellAI.RefreshTokenAuthConfigRequest? value)
        {
            value = RefreshToken;
            return IsRefreshToken;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.RefreshTokenAuthConfigRequest PickRefreshToken() => IsRefreshToken
            ? RefreshToken!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RefreshToken' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfigRequest(global::RetellAI.OAuthConfigRequest value) => new AuthConfigRequest((global::RetellAI.OAuthConfigRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.OAuthConfigRequest?(AuthConfigRequest @this) => @this.O;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfigRequest(global::RetellAI.OAuthConfigRequest? value)
        {
            O = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfigRequest FromO(global::RetellAI.OAuthConfigRequest? value) => new AuthConfigRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfigRequest(global::RetellAI.ApiKeyAuthConfigRequest value) => new AuthConfigRequest((global::RetellAI.ApiKeyAuthConfigRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ApiKeyAuthConfigRequest?(AuthConfigRequest @this) => @this.ApiKey;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfigRequest(global::RetellAI.ApiKeyAuthConfigRequest? value)
        {
            ApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfigRequest FromApiKey(global::RetellAI.ApiKeyAuthConfigRequest? value) => new AuthConfigRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfigRequest(global::RetellAI.AccessTokenAuthConfigRequest value) => new AuthConfigRequest((global::RetellAI.AccessTokenAuthConfigRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.AccessTokenAuthConfigRequest?(AuthConfigRequest @this) => @this.AccessToken;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfigRequest(global::RetellAI.AccessTokenAuthConfigRequest? value)
        {
            AccessToken = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfigRequest FromAccessToken(global::RetellAI.AccessTokenAuthConfigRequest? value) => new AuthConfigRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfigRequest(global::RetellAI.BasicAuthConfigRequest value) => new AuthConfigRequest((global::RetellAI.BasicAuthConfigRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.BasicAuthConfigRequest?(AuthConfigRequest @this) => @this.Basic;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfigRequest(global::RetellAI.BasicAuthConfigRequest? value)
        {
            Basic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfigRequest FromBasic(global::RetellAI.BasicAuthConfigRequest? value) => new AuthConfigRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfigRequest(global::RetellAI.RefreshTokenAuthConfigRequest value) => new AuthConfigRequest((global::RetellAI.RefreshTokenAuthConfigRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.RefreshTokenAuthConfigRequest?(AuthConfigRequest @this) => @this.RefreshToken;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfigRequest(global::RetellAI.RefreshTokenAuthConfigRequest? value)
        {
            RefreshToken = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AuthConfigRequest FromRefreshToken(global::RetellAI.RefreshTokenAuthConfigRequest? value) => new AuthConfigRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public AuthConfigRequest(
            global::RetellAI.OAuthConfigRequest? o,
            global::RetellAI.ApiKeyAuthConfigRequest? apiKey,
            global::RetellAI.AccessTokenAuthConfigRequest? accessToken,
            global::RetellAI.BasicAuthConfigRequest? basic,
            global::RetellAI.RefreshTokenAuthConfigRequest? refreshToken
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
            global::System.Func<global::RetellAI.OAuthConfigRequest, TResult>? o = null,
            global::System.Func<global::RetellAI.ApiKeyAuthConfigRequest, TResult>? apiKey = null,
            global::System.Func<global::RetellAI.AccessTokenAuthConfigRequest, TResult>? accessToken = null,
            global::System.Func<global::RetellAI.BasicAuthConfigRequest, TResult>? basic = null,
            global::System.Func<global::RetellAI.RefreshTokenAuthConfigRequest, TResult>? refreshToken = null,
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
            global::System.Action<global::RetellAI.OAuthConfigRequest>? o = null,

            global::System.Action<global::RetellAI.ApiKeyAuthConfigRequest>? apiKey = null,

            global::System.Action<global::RetellAI.AccessTokenAuthConfigRequest>? accessToken = null,

            global::System.Action<global::RetellAI.BasicAuthConfigRequest>? basic = null,

            global::System.Action<global::RetellAI.RefreshTokenAuthConfigRequest>? refreshToken = null,
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
            global::System.Action<global::RetellAI.OAuthConfigRequest>? o = null,
            global::System.Action<global::RetellAI.ApiKeyAuthConfigRequest>? apiKey = null,
            global::System.Action<global::RetellAI.AccessTokenAuthConfigRequest>? accessToken = null,
            global::System.Action<global::RetellAI.BasicAuthConfigRequest>? basic = null,
            global::System.Action<global::RetellAI.RefreshTokenAuthConfigRequest>? refreshToken = null,
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
                typeof(global::RetellAI.OAuthConfigRequest),
                ApiKey,
                typeof(global::RetellAI.ApiKeyAuthConfigRequest),
                AccessToken,
                typeof(global::RetellAI.AccessTokenAuthConfigRequest),
                Basic,
                typeof(global::RetellAI.BasicAuthConfigRequest),
                RefreshToken,
                typeof(global::RetellAI.RefreshTokenAuthConfigRequest),
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
        public bool Equals(AuthConfigRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.OAuthConfigRequest?>.Default.Equals(O, other.O) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ApiKeyAuthConfigRequest?>.Default.Equals(ApiKey, other.ApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.AccessTokenAuthConfigRequest?>.Default.Equals(AccessToken, other.AccessToken) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.BasicAuthConfigRequest?>.Default.Equals(Basic, other.Basic) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.RefreshTokenAuthConfigRequest?>.Default.Equals(RefreshToken, other.RefreshToken) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AuthConfigRequest obj1, AuthConfigRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AuthConfigRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AuthConfigRequest obj1, AuthConfigRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AuthConfigRequest o && Equals(o);
        }
    }
}
