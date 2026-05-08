#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NodeTransitionMessage : global::System.IEquatable<NodeTransitionMessage>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeTransitionMessageBase? Base { get; init; }
#else
        public global::RetellAI.NodeTransitionMessageBase? Base { get; }
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
            out global::RetellAI.NodeTransitionMessageBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? NodeTransitionMessageVariant2 { get; init; }
#else
        public object? NodeTransitionMessageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeTransitionMessageVariant2))]
#endif
        public bool IsNodeTransitionMessageVariant2 => NodeTransitionMessageVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNodeTransitionMessageVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = NodeTransitionMessageVariant2;
            return IsNodeTransitionMessageVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeTransitionMessage(global::RetellAI.NodeTransitionMessageBase value) => new NodeTransitionMessage((global::RetellAI.NodeTransitionMessageBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeTransitionMessageBase?(NodeTransitionMessage @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public NodeTransitionMessage(global::RetellAI.NodeTransitionMessageBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NodeTransitionMessage(
            global::RetellAI.NodeTransitionMessageBase? @base,
            object? nodeTransitionMessageVariant2
            )
        {
            Base = @base;
            NodeTransitionMessageVariant2 = nodeTransitionMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NodeTransitionMessageVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            NodeTransitionMessageVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsNodeTransitionMessageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.NodeTransitionMessageBase, TResult>? @base = null,
            global::System.Func<object, TResult>? nodeTransitionMessageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsNodeTransitionMessageVariant2 && nodeTransitionMessageVariant2 != null)
            {
                return nodeTransitionMessageVariant2(NodeTransitionMessageVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.NodeTransitionMessageBase>? @base = null,

            global::System.Action<object>? nodeTransitionMessageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsNodeTransitionMessageVariant2)
            {
                nodeTransitionMessageVariant2?.Invoke(NodeTransitionMessageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.NodeTransitionMessageBase>? @base = null,
            global::System.Action<object>? nodeTransitionMessageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsNodeTransitionMessageVariant2)
            {
                nodeTransitionMessageVariant2?.Invoke(NodeTransitionMessageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::RetellAI.NodeTransitionMessageBase),
                NodeTransitionMessageVariant2,
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
        public bool Equals(NodeTransitionMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeTransitionMessageBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(NodeTransitionMessageVariant2, other.NodeTransitionMessageVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NodeTransitionMessage obj1, NodeTransitionMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NodeTransitionMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NodeTransitionMessage obj1, NodeTransitionMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NodeTransitionMessage o && Equals(o);
        }
    }
}
