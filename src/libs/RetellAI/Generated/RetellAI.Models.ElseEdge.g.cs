#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ElseEdge : global::System.IEquatable<ElseEdge>
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
        public global::RetellAI.ElseEdgeVariant2? ElseEdgeVariant2 { get; init; }
#else
        public global::RetellAI.ElseEdgeVariant2? ElseEdgeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElseEdgeVariant2))]
#endif
        public bool IsElseEdgeVariant2 => ElseEdgeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ElseEdge(global::RetellAI.NodeEdge value) => new ElseEdge((global::RetellAI.NodeEdge?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeEdge?(ElseEdge @this) => @this.Node;

        /// <summary>
        /// 
        /// </summary>
        public ElseEdge(global::RetellAI.NodeEdge? value)
        {
            Node = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ElseEdge(global::RetellAI.ElseEdgeVariant2 value) => new ElseEdge((global::RetellAI.ElseEdgeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.ElseEdgeVariant2?(ElseEdge @this) => @this.ElseEdgeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ElseEdge(global::RetellAI.ElseEdgeVariant2? value)
        {
            ElseEdgeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ElseEdge(
            global::RetellAI.NodeEdge? node,
            global::RetellAI.ElseEdgeVariant2? elseEdgeVariant2
            )
        {
            Node = node;
            ElseEdgeVariant2 = elseEdgeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ElseEdgeVariant2 as object ??
            Node as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Node?.ToString() ??
            ElseEdgeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNode && IsElseEdgeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.NodeEdge?, TResult>? node = null,
            global::System.Func<global::RetellAI.ElseEdgeVariant2?, TResult>? elseEdgeVariant2 = null,
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
            else if (IsElseEdgeVariant2 && elseEdgeVariant2 != null)
            {
                return elseEdgeVariant2(ElseEdgeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.NodeEdge?>? node = null,
            global::System.Action<global::RetellAI.ElseEdgeVariant2?>? elseEdgeVariant2 = null,
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
            else if (IsElseEdgeVariant2)
            {
                elseEdgeVariant2?.Invoke(ElseEdgeVariant2!);
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
                ElseEdgeVariant2,
                typeof(global::RetellAI.ElseEdgeVariant2),
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
        public bool Equals(ElseEdge other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeEdge?>.Default.Equals(Node, other.Node) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.ElseEdgeVariant2?>.Default.Equals(ElseEdgeVariant2, other.ElseEdgeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ElseEdge obj1, ElseEdge obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ElseEdge>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ElseEdge obj1, ElseEdge obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ElseEdge o && Equals(o);
        }
    }
}
