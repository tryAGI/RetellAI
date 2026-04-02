#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ComponentNode : global::System.IEquatable<ComponentNode>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeBaseCommon? BaseCommon { get; init; }
#else
        public global::RetellAI.NodeBaseCommon? BaseCommon { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseCommon))]
#endif
        public bool IsBaseCommon => BaseCommon != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.ComponentNodeVariant2? ComponentNodeVariant2 { get; init; }
#else
        public global::RetellAI.ComponentNodeVariant2? ComponentNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComponentNodeVariant2))]
#endif
        public bool IsComponentNodeVariant2 => ComponentNodeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComponentNode(global::RetellAI.NodeBaseCommon value) => new ComponentNode((global::RetellAI.NodeBaseCommon?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeBaseCommon?(ComponentNode @this) => @this.BaseCommon;

        /// <summary>
        /// 
        /// </summary>
        public ComponentNode(global::RetellAI.NodeBaseCommon? value)
        {
            BaseCommon = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComponentNode(global::RetellAI.ComponentNodeVariant2 value) => new ComponentNode((global::RetellAI.ComponentNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ComponentNodeVariant2?(ComponentNode @this) => @this.ComponentNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ComponentNode(global::RetellAI.ComponentNodeVariant2? value)
        {
            ComponentNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ComponentNode(
            global::RetellAI.NodeBaseCommon? baseCommon,
            global::RetellAI.ComponentNodeVariant2? componentNodeVariant2
            )
        {
            BaseCommon = baseCommon;
            ComponentNodeVariant2 = componentNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ComponentNodeVariant2 as object ??
            BaseCommon as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseCommon?.ToString() ??
            ComponentNodeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseCommon && IsComponentNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.NodeBaseCommon?, TResult>? baseCommon = null,
            global::System.Func<global::RetellAI.ComponentNodeVariant2?, TResult>? componentNodeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseCommon && baseCommon != null)
            {
                return baseCommon(BaseCommon!);
            }
            else if (IsComponentNodeVariant2 && componentNodeVariant2 != null)
            {
                return componentNodeVariant2(ComponentNodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.NodeBaseCommon?>? baseCommon = null,
            global::System.Action<global::RetellAI.ComponentNodeVariant2?>? componentNodeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseCommon)
            {
                baseCommon?.Invoke(BaseCommon!);
            }
            else if (IsComponentNodeVariant2)
            {
                componentNodeVariant2?.Invoke(ComponentNodeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseCommon,
                typeof(global::RetellAI.NodeBaseCommon),
                ComponentNodeVariant2,
                typeof(global::RetellAI.ComponentNodeVariant2),
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
        public bool Equals(ComponentNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeBaseCommon?>.Default.Equals(BaseCommon, other.BaseCommon) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ComponentNodeVariant2?>.Default.Equals(ComponentNodeVariant2, other.ComponentNodeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ComponentNode obj1, ComponentNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ComponentNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ComponentNode obj1, ComponentNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComponentNode o && Equals(o);
        }
    }
}
