#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V3PhoneCallResponse : global::System.IEquatable<V3PhoneCallResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.V3PhoneCallResponseVariant1? V3PhoneCallResponseVariant1 { get; init; }
#else
        public global::RetellAI.V3PhoneCallResponseVariant1? V3PhoneCallResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V3PhoneCallResponseVariant1))]
#endif
        public bool IsV3PhoneCallResponseVariant1 => V3PhoneCallResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV3PhoneCallResponseVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.V3PhoneCallResponseVariant1? value)
        {
            value = V3PhoneCallResponseVariant1;
            return IsV3PhoneCallResponseVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.V3PhoneCallResponseVariant1 PickV3PhoneCallResponseVariant1() => IsV3PhoneCallResponseVariant1
            ? V3PhoneCallResponseVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V3PhoneCallResponseVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.V3CallBase? Base { get; init; }
#else
        public global::RetellAI.V3CallBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.V3CallBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::RetellAI.V3CallBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V3PhoneCallResponse(global::RetellAI.V3PhoneCallResponseVariant1 value) => new V3PhoneCallResponse((global::RetellAI.V3PhoneCallResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.V3PhoneCallResponseVariant1?(V3PhoneCallResponse @this) => @this.V3PhoneCallResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V3PhoneCallResponse(global::RetellAI.V3PhoneCallResponseVariant1? value)
        {
            V3PhoneCallResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V3PhoneCallResponse FromV3PhoneCallResponseVariant1(global::RetellAI.V3PhoneCallResponseVariant1? value) => new V3PhoneCallResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V3PhoneCallResponse(global::RetellAI.V3CallBase value) => new V3PhoneCallResponse((global::RetellAI.V3CallBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.V3CallBase?(V3PhoneCallResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public V3PhoneCallResponse(global::RetellAI.V3CallBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V3PhoneCallResponse FromBase(global::RetellAI.V3CallBase? value) => new V3PhoneCallResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public V3PhoneCallResponse(
            global::RetellAI.V3PhoneCallResponseVariant1? v3PhoneCallResponseVariant1,
            global::RetellAI.V3CallBase? @base
            )
        {
            V3PhoneCallResponseVariant1 = v3PhoneCallResponseVariant1;
            Base = @base;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Base as object ??
            V3PhoneCallResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V3PhoneCallResponseVariant1?.ToString() ??
            Base?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV3PhoneCallResponseVariant1 && IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.V3PhoneCallResponseVariant1, TResult>? v3PhoneCallResponseVariant1 = null,
            global::System.Func<global::RetellAI.V3CallBase, TResult>? @base = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV3PhoneCallResponseVariant1 && v3PhoneCallResponseVariant1 != null)
            {
                return v3PhoneCallResponseVariant1(V3PhoneCallResponseVariant1!);
            }
            else if (IsBase && @base != null)
            {
                return @base(Base!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.V3PhoneCallResponseVariant1>? v3PhoneCallResponseVariant1 = null,

            global::System.Action<global::RetellAI.V3CallBase>? @base = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV3PhoneCallResponseVariant1)
            {
                v3PhoneCallResponseVariant1?.Invoke(V3PhoneCallResponseVariant1!);
            }
            else if (IsBase)
            {
                @base?.Invoke(Base!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.V3PhoneCallResponseVariant1>? v3PhoneCallResponseVariant1 = null,
            global::System.Action<global::RetellAI.V3CallBase>? @base = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV3PhoneCallResponseVariant1)
            {
                v3PhoneCallResponseVariant1?.Invoke(V3PhoneCallResponseVariant1!);
            }
            else if (IsBase)
            {
                @base?.Invoke(Base!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V3PhoneCallResponseVariant1,
                typeof(global::RetellAI.V3PhoneCallResponseVariant1),
                Base,
                typeof(global::RetellAI.V3CallBase),
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
        public bool Equals(V3PhoneCallResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.V3PhoneCallResponseVariant1?>.Default.Equals(V3PhoneCallResponseVariant1, other.V3PhoneCallResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.V3CallBase?>.Default.Equals(Base, other.Base) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V3PhoneCallResponse obj1, V3PhoneCallResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V3PhoneCallResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V3PhoneCallResponse obj1, V3PhoneCallResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V3PhoneCallResponse o && Equals(o);
        }
    }
}
