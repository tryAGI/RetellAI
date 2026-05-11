#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V3CallResponse : global::System.IEquatable<V3CallResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.V3WebCallResponse? Web { get; init; }
#else
        public global::RetellAI.V3WebCallResponse? Web { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Web))]
#endif
        public bool IsWeb => Web != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWeb(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.V3WebCallResponse? value)
        {
            value = Web;
            return IsWeb;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.V3WebCallResponse PickWeb() => IsWeb
            ? Web!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Web' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.V3PhoneCallResponse? Phone { get; init; }
#else
        public global::RetellAI.V3PhoneCallResponse? Phone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Phone))]
#endif
        public bool IsPhone => Phone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPhone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.V3PhoneCallResponse? value)
        {
            value = Phone;
            return IsPhone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.V3PhoneCallResponse PickPhone() => IsPhone
            ? Phone!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Phone' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V3CallResponse(global::RetellAI.V3WebCallResponse value) => new V3CallResponse((global::RetellAI.V3WebCallResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.V3WebCallResponse?(V3CallResponse @this) => @this.Web;

        /// <summary>
        /// 
        /// </summary>
        public V3CallResponse(global::RetellAI.V3WebCallResponse? value)
        {
            Web = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V3CallResponse FromWeb(global::RetellAI.V3WebCallResponse? value) => new V3CallResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V3CallResponse(global::RetellAI.V3PhoneCallResponse value) => new V3CallResponse((global::RetellAI.V3PhoneCallResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.V3PhoneCallResponse?(V3CallResponse @this) => @this.Phone;

        /// <summary>
        /// 
        /// </summary>
        public V3CallResponse(global::RetellAI.V3PhoneCallResponse? value)
        {
            Phone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V3CallResponse FromPhone(global::RetellAI.V3PhoneCallResponse? value) => new V3CallResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public V3CallResponse(
            global::RetellAI.V3WebCallResponse? web,
            global::RetellAI.V3PhoneCallResponse? phone
            )
        {
            Web = web;
            Phone = phone;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Phone as object ??
            Web as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Web?.ToString() ??
            Phone?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWeb && !IsPhone || !IsWeb && IsPhone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.V3WebCallResponse?, TResult>? web = null,
            global::System.Func<global::RetellAI.V3PhoneCallResponse?, TResult>? phone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWeb && web != null)
            {
                return web(Web!);
            }
            else if (IsPhone && phone != null)
            {
                return phone(Phone!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.V3WebCallResponse?>? web = null,

            global::System.Action<global::RetellAI.V3PhoneCallResponse?>? phone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWeb)
            {
                web?.Invoke(Web!);
            }
            else if (IsPhone)
            {
                phone?.Invoke(Phone!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.V3WebCallResponse?>? web = null,
            global::System.Action<global::RetellAI.V3PhoneCallResponse?>? phone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWeb)
            {
                web?.Invoke(Web!);
            }
            else if (IsPhone)
            {
                phone?.Invoke(Phone!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Web,
                typeof(global::RetellAI.V3WebCallResponse),
                Phone,
                typeof(global::RetellAI.V3PhoneCallResponse),
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
        public bool Equals(V3CallResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.V3WebCallResponse?>.Default.Equals(Web, other.Web) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.V3PhoneCallResponse?>.Default.Equals(Phone, other.Phone) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V3CallResponse obj1, V3CallResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V3CallResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V3CallResponse obj1, V3CallResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V3CallResponse o && Equals(o);
        }
    }
}
