#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct V2CallResponse : global::System.IEquatable<V2CallResponse>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.V2WebCallResponse? Web { get; init; }
#else
        public global::RetellAI.V2WebCallResponse? Web { get; }
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
            out global::RetellAI.V2WebCallResponse? value)
        {
            value = Web;
            return IsWeb;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2WebCallResponse PickWeb() => Web is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Web' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.V2PhoneCallResponse? Phone { get; init; }
#else
        public global::RetellAI.V2PhoneCallResponse? Phone { get; }
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
            out global::RetellAI.V2PhoneCallResponse? value)
        {
            value = Phone;
            return IsPhone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.V2PhoneCallResponse PickPhone() => Phone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Phone' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator V2CallResponse(global::RetellAI.V2WebCallResponse value) => new V2CallResponse((global::RetellAI.V2WebCallResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.V2WebCallResponse?(V2CallResponse @this) => @this.Web;

        /// <summary>
        ///
        /// </summary>
        public V2CallResponse(global::RetellAI.V2WebCallResponse? value)
        {
            Web = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static V2CallResponse FromWeb(global::RetellAI.V2WebCallResponse? value) => new V2CallResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator V2CallResponse(global::RetellAI.V2PhoneCallResponse value) => new V2CallResponse((global::RetellAI.V2PhoneCallResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.V2PhoneCallResponse?(V2CallResponse @this) => @this.Phone;

        /// <summary>
        ///
        /// </summary>
        public V2CallResponse(global::RetellAI.V2PhoneCallResponse? value)
        {
            Phone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static V2CallResponse FromPhone(global::RetellAI.V2PhoneCallResponse? value) => new V2CallResponse(value);

        /// <summary>
        ///
        /// </summary>
        public V2CallResponse(
            global::RetellAI.V2WebCallResponse? web,
            global::RetellAI.V2PhoneCallResponse? phone
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
            global::System.Func<global::RetellAI.V2WebCallResponse?, TResult>? web = null,
            global::System.Func<global::RetellAI.V2PhoneCallResponse?, TResult>? phone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Web is { } __value0 && web != null)
            {
                return web(__value0);
            }
            else if (Phone is { } __value1 && phone != null)
            {
                return phone(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.V2WebCallResponse?>? web = null,

            global::System.Action<global::RetellAI.V2PhoneCallResponse?>? phone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Web is { } __value0)
            {
                web?.Invoke(__value0);
            }
            else if (Phone is { } __value1)
            {
                phone?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.V2WebCallResponse?>? web = null,
            global::System.Action<global::RetellAI.V2PhoneCallResponse?>? phone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Web is { } __value0)
            {
                web?.Invoke(__value0);
            }
            else if (Phone is { } __value1)
            {
                phone?.Invoke(__value1);
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
                typeof(global::RetellAI.V2WebCallResponse),
                Phone,
                typeof(global::RetellAI.V2PhoneCallResponse),
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
        public bool Equals(V2CallResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.V2WebCallResponse?>.Default.Equals(Web, other.Web) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.V2PhoneCallResponse?>.Default.Equals(Phone, other.Phone)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(V2CallResponse obj1, V2CallResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V2CallResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(V2CallResponse obj1, V2CallResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V2CallResponse o && Equals(o);
        }
    }
}
