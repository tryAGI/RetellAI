#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SkipResponseEdge : global::System.IEquatable<SkipResponseEdge>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeEdge? Node { get; init; }
#else
        public global::RetellAI.NodeEdge? Node { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Node))]
#endif
        public bool IsNode => Node != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.SkipResponseEdgeVariant2? SkipResponseEdgeVariant2 { get; init; }
#else
        public global::RetellAI.SkipResponseEdgeVariant2? SkipResponseEdgeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SkipResponseEdgeVariant2))]
#endif
        public bool IsSkipResponseEdgeVariant2 => SkipResponseEdgeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SkipResponseEdge(global::RetellAI.NodeEdge value) => new SkipResponseEdge((global::RetellAI.NodeEdge?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeEdge?(SkipResponseEdge @this) => @this.Node;

        /// <summary>
        /// 
        /// </summary>
        public SkipResponseEdge(global::RetellAI.NodeEdge? value)
        {
            Node = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SkipResponseEdge(global::RetellAI.SkipResponseEdgeVariant2 value) => new SkipResponseEdge((global::RetellAI.SkipResponseEdgeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.SkipResponseEdgeVariant2?(SkipResponseEdge @this) => @this.SkipResponseEdgeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SkipResponseEdge(global::RetellAI.SkipResponseEdgeVariant2? value)
        {
            SkipResponseEdgeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SkipResponseEdge(
            global::RetellAI.NodeEdge? node,
            global::RetellAI.SkipResponseEdgeVariant2? skipResponseEdgeVariant2
            )
        {
            Node = node;
            SkipResponseEdgeVariant2 = skipResponseEdgeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SkipResponseEdgeVariant2 as object ??
            Node as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Node?.ToString() ??
            SkipResponseEdgeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNode && IsSkipResponseEdgeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.NodeEdge?, TResult>? node = null,
            global::System.Func<global::RetellAI.SkipResponseEdgeVariant2?, TResult>? skipResponseEdgeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNode && node != null)
            {
                return node(Node!);
            }
            else if (IsSkipResponseEdgeVariant2 && skipResponseEdgeVariant2 != null)
            {
                return skipResponseEdgeVariant2(SkipResponseEdgeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.NodeEdge?>? node = null,
            global::System.Action<global::RetellAI.SkipResponseEdgeVariant2?>? skipResponseEdgeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNode)
            {
                node?.Invoke(Node!);
            }
            else if (IsSkipResponseEdgeVariant2)
            {
                skipResponseEdgeVariant2?.Invoke(SkipResponseEdgeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Node,
                typeof(global::RetellAI.NodeEdge),
                SkipResponseEdgeVariant2,
                typeof(global::RetellAI.SkipResponseEdgeVariant2),
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
        public bool Equals(SkipResponseEdge other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeEdge?>.Default.Equals(Node, other.Node) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SkipResponseEdgeVariant2?>.Default.Equals(SkipResponseEdgeVariant2, other.SkipResponseEdgeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SkipResponseEdge obj1, SkipResponseEdge obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SkipResponseEdge>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SkipResponseEdge obj1, SkipResponseEdge obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SkipResponseEdge o && Equals(o);
        }
    }
}
