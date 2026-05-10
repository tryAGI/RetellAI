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
        public global::RetellAI.V2CallResponse? V2 { get; init; }
#else
        public global::RetellAI.V2CallResponse? V2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2))]
#endif
        public bool IsV2 => V2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.V2CallResponse? value)
        {
            value = V2;
            return IsV2;
        }

        /// <summary>
        /// V3 list calls response. Transcript fields are intentionally omitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public object? V3CallResponseVariant2 { get; init; }
#else
        public object? V3CallResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V3CallResponseVariant2))]
#endif
        public bool IsV3CallResponseVariant2 => V3CallResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV3CallResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = V3CallResponseVariant2;
            return IsV3CallResponseVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V3CallResponse(global::RetellAI.V2CallResponse value) => new V3CallResponse((global::RetellAI.V2CallResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.V2CallResponse?(V3CallResponse @this) => @this.V2;

        /// <summary>
        /// 
        /// </summary>
        public V3CallResponse(global::RetellAI.V2CallResponse? value)
        {
            V2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V3CallResponse FromV2(global::RetellAI.V2CallResponse? value) => new V3CallResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public V3CallResponse(
            global::RetellAI.V2CallResponse? v2,
            object? v3CallResponseVariant2
            )
        {
            V2 = v2;
            V3CallResponseVariant2 = v3CallResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V3CallResponseVariant2 as object ??
            V2 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V2?.ToString() ??
            V3CallResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV2 && IsV3CallResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.V2CallResponse?, TResult>? v2 = null,
            global::System.Func<object, TResult>? v3CallResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2 && v2 != null)
            {
                return v2(V2!);
            }
            else if (IsV3CallResponseVariant2 && v3CallResponseVariant2 != null)
            {
                return v3CallResponseVariant2(V3CallResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.V2CallResponse?>? v2 = null,

            global::System.Action<object>? v3CallResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2)
            {
                v2?.Invoke(V2!);
            }
            else if (IsV3CallResponseVariant2)
            {
                v3CallResponseVariant2?.Invoke(V3CallResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.V2CallResponse?>? v2 = null,
            global::System.Action<object>? v3CallResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2)
            {
                v2?.Invoke(V2!);
            }
            else if (IsV3CallResponseVariant2)
            {
                v3CallResponseVariant2?.Invoke(V3CallResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V2,
                typeof(global::RetellAI.V2CallResponse),
                V3CallResponseVariant2,
                typeof(object),
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
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.V2CallResponse?>.Default.Equals(V2, other.V2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(V3CallResponseVariant2, other.V3CallResponseVariant2) 
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
