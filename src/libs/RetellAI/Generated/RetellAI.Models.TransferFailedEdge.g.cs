#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TransferFailedEdge : global::System.IEquatable<TransferFailedEdge>
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
        public global::RetellAI.TransferFailedEdgeVariant2? TransferFailedEdgeVariant2 { get; init; }
#else
        public global::RetellAI.TransferFailedEdgeVariant2? TransferFailedEdgeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferFailedEdgeVariant2))]
#endif
        public bool IsTransferFailedEdgeVariant2 => TransferFailedEdgeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferFailedEdge(global::RetellAI.NodeEdge value) => new TransferFailedEdge((global::RetellAI.NodeEdge?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.NodeEdge?(TransferFailedEdge @this) => @this.Node;

        /// <summary>
        /// 
        /// </summary>
        public TransferFailedEdge(global::RetellAI.NodeEdge? value)
        {
            Node = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferFailedEdge(global::RetellAI.TransferFailedEdgeVariant2 value) => new TransferFailedEdge((global::RetellAI.TransferFailedEdgeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::RetellAI.TransferFailedEdgeVariant2?(TransferFailedEdge @this) => @this.TransferFailedEdgeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TransferFailedEdge(global::RetellAI.TransferFailedEdgeVariant2? value)
        {
            TransferFailedEdgeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TransferFailedEdge(
            global::RetellAI.NodeEdge? node,
            global::RetellAI.TransferFailedEdgeVariant2? transferFailedEdgeVariant2
            )
        {
            Node = node;
            TransferFailedEdgeVariant2 = transferFailedEdgeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TransferFailedEdgeVariant2 as object ??
            Node as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Node?.ToString() ??
            TransferFailedEdgeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNode && IsTransferFailedEdgeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.NodeEdge?, TResult>? node = null,
            global::System.Func<global::RetellAI.TransferFailedEdgeVariant2?, TResult>? transferFailedEdgeVariant2 = null,
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
            else if (IsTransferFailedEdgeVariant2 && transferFailedEdgeVariant2 != null)
            {
                return transferFailedEdgeVariant2(TransferFailedEdgeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.NodeEdge?>? node = null,
            global::System.Action<global::RetellAI.TransferFailedEdgeVariant2?>? transferFailedEdgeVariant2 = null,
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
            else if (IsTransferFailedEdgeVariant2)
            {
                transferFailedEdgeVariant2?.Invoke(TransferFailedEdgeVariant2!);
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
                TransferFailedEdgeVariant2,
                typeof(global::RetellAI.TransferFailedEdgeVariant2),
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
        public bool Equals(TransferFailedEdge other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeEdge?>.Default.Equals(Node, other.Node) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.TransferFailedEdgeVariant2?>.Default.Equals(TransferFailedEdgeVariant2, other.TransferFailedEdgeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TransferFailedEdge obj1, TransferFailedEdge obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransferFailedEdge>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TransferFailedEdge obj1, TransferFailedEdge obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransferFailedEdge o && Equals(o);
        }
    }
}
