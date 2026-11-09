#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct EscalationFailedEdge : global::System.IEquatable<EscalationFailedEdge>
    {
        /// <summary>
        /// A connection between conversation-flow nodes. When used in a node's edges array, transitions when its condition matches. Equation conditions compare dynamic variables and are checked in array order; the first match wins. If no equation matches, the LLM evaluates prompt conditions against the conversation and selects a matching transition, if any.
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
        public bool TryPickNode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.NodeEdge? value)
        {
            value = Node;
            return IsNode;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeEdge PickNode() => Node is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Node' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.EscalationFailedEdgeVariant2? EscalationFailedEdgeVariant2 { get; init; }
#else
        public global::RetellAI.EscalationFailedEdgeVariant2? EscalationFailedEdgeVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EscalationFailedEdgeVariant2))]
#endif
        public bool IsEscalationFailedEdgeVariant2 => EscalationFailedEdgeVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEscalationFailedEdgeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.EscalationFailedEdgeVariant2? value)
        {
            value = EscalationFailedEdgeVariant2;
            return IsEscalationFailedEdgeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.EscalationFailedEdgeVariant2 PickEscalationFailedEdgeVariant2() => EscalationFailedEdgeVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EscalationFailedEdgeVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EscalationFailedEdge(global::RetellAI.NodeEdge value) => new EscalationFailedEdge((global::RetellAI.NodeEdge?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.NodeEdge?(EscalationFailedEdge @this) => @this.Node;

        /// <summary>
        ///
        /// </summary>
        public EscalationFailedEdge(global::RetellAI.NodeEdge? value)
        {
            Node = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EscalationFailedEdge FromNode(global::RetellAI.NodeEdge? value) => new EscalationFailedEdge(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EscalationFailedEdge(global::RetellAI.EscalationFailedEdgeVariant2 value) => new EscalationFailedEdge((global::RetellAI.EscalationFailedEdgeVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.EscalationFailedEdgeVariant2?(EscalationFailedEdge @this) => @this.EscalationFailedEdgeVariant2;

        /// <summary>
        ///
        /// </summary>
        public EscalationFailedEdge(global::RetellAI.EscalationFailedEdgeVariant2? value)
        {
            EscalationFailedEdgeVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EscalationFailedEdge FromEscalationFailedEdgeVariant2(global::RetellAI.EscalationFailedEdgeVariant2? value) => new EscalationFailedEdge(value);

        /// <summary>
        ///
        /// </summary>
        public EscalationFailedEdge(
            global::RetellAI.NodeEdge? node,
            global::RetellAI.EscalationFailedEdgeVariant2? escalationFailedEdgeVariant2
            )
        {
            Node = node;
            EscalationFailedEdgeVariant2 = escalationFailedEdgeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EscalationFailedEdgeVariant2 as object ??
            Node as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Node?.ToString() ??
            EscalationFailedEdgeVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNode && IsEscalationFailedEdgeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.NodeEdge, TResult>? node = null,
            global::System.Func<global::RetellAI.EscalationFailedEdgeVariant2, TResult>? escalationFailedEdgeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Node is { } __value0 && node != null)
            {
                return node(__value0);
            }
            else if (EscalationFailedEdgeVariant2 is { } __value1 && escalationFailedEdgeVariant2 != null)
            {
                return escalationFailedEdgeVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.NodeEdge>? node = null,

            global::System.Action<global::RetellAI.EscalationFailedEdgeVariant2>? escalationFailedEdgeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Node is { } __value0)
            {
                node?.Invoke(__value0);
            }
            else if (EscalationFailedEdgeVariant2 is { } __value1)
            {
                escalationFailedEdgeVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.NodeEdge>? node = null,
            global::System.Action<global::RetellAI.EscalationFailedEdgeVariant2>? escalationFailedEdgeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Node is { } __value0)
            {
                node?.Invoke(__value0);
            }
            else if (EscalationFailedEdgeVariant2 is { } __value1)
            {
                escalationFailedEdgeVariant2?.Invoke(__value1);
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
                EscalationFailedEdgeVariant2,
                typeof(global::RetellAI.EscalationFailedEdgeVariant2),
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
        public bool Equals(EscalationFailedEdge other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeEdge?>.Default.Equals(Node, other.Node) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.EscalationFailedEdgeVariant2?>.Default.Equals(EscalationFailedEdgeVariant2, other.EscalationFailedEdgeVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EscalationFailedEdge obj1, EscalationFailedEdge obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EscalationFailedEdge>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EscalationFailedEdge obj1, EscalationFailedEdge obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EscalationFailedEdge o && Equals(o);
        }
    }
}
