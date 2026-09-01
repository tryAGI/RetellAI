#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Caller-managed credentials. Providers using the OAuth callback reject auth_config and must be authorized through connect-app.
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
        public AuthConfigRequest(
            global::RetellAI.OAuthConfigRequest? o,
            global::RetellAI.ApiKeyAuthConfigRequest? apiKey,
            global::RetellAI.BasicAuthConfigRequest? basic
            )
        {
            O = o;
            ApiKey = apiKey;
            Basic = basic;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Basic as object ??
            ApiKey as object ??
            O as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            O?.ToString() ??
            ApiKey?.ToString() ??
            Basic?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsO && !IsApiKey && !IsBasic || !IsO && IsApiKey && !IsBasic || !IsO && !IsApiKey && IsBasic;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.OAuthConfigRequest, TResult>? o = null,
            global::System.Func<global::RetellAI.ApiKeyAuthConfigRequest, TResult>? apiKey = null,
            global::System.Func<global::RetellAI.BasicAuthConfigRequest, TResult>? basic = null,
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
            else if (IsBasic && basic != null)
            {
                return basic(Basic!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.OAuthConfigRequest>? o = null,

            global::System.Action<global::RetellAI.ApiKeyAuthConfigRequest>? apiKey = null,

            global::System.Action<global::RetellAI.BasicAuthConfigRequest>? basic = null,
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
            else if (IsBasic)
            {
                basic?.Invoke(Basic!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.OAuthConfigRequest>? o = null,
            global::System.Action<global::RetellAI.ApiKeyAuthConfigRequest>? apiKey = null,
            global::System.Action<global::RetellAI.BasicAuthConfigRequest>? basic = null,
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
            else if (IsBasic)
            {
                basic?.Invoke(Basic!);
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
                Basic,
                typeof(global::RetellAI.BasicAuthConfigRequest),
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
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.BasicAuthConfigRequest?>.Default.Equals(Basic, other.Basic)
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
