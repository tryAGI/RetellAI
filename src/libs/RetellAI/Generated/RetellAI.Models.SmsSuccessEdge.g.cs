#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    /// Transition followed by an SMS node after the send operation reports success.
    /// </summary>
    public readonly partial struct SmsSuccessEdge : global::System.IEquatable<SmsSuccessEdge>
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
        public global::RetellAI.SmsSuccessEdgeVariant2? SmsSuccessEdgeVariant2 { get; init; }
#else
        public global::RetellAI.SmsSuccessEdgeVariant2? SmsSuccessEdgeVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmsSuccessEdgeVariant2))]
#endif
        public bool IsSmsSuccessEdgeVariant2 => SmsSuccessEdgeVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSmsSuccessEdgeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.SmsSuccessEdgeVariant2? value)
        {
            value = SmsSuccessEdgeVariant2;
            return IsSmsSuccessEdgeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.SmsSuccessEdgeVariant2 PickSmsSuccessEdgeVariant2() => SmsSuccessEdgeVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SmsSuccessEdgeVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SmsSuccessEdge(global::RetellAI.NodeEdge value) => new SmsSuccessEdge((global::RetellAI.NodeEdge?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.NodeEdge?(SmsSuccessEdge @this) => @this.Node;

        /// <summary>
        ///
        /// </summary>
        public SmsSuccessEdge(global::RetellAI.NodeEdge? value)
        {
            Node = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SmsSuccessEdge FromNode(global::RetellAI.NodeEdge? value) => new SmsSuccessEdge(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SmsSuccessEdge(global::RetellAI.SmsSuccessEdgeVariant2 value) => new SmsSuccessEdge((global::RetellAI.SmsSuccessEdgeVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.SmsSuccessEdgeVariant2?(SmsSuccessEdge @this) => @this.SmsSuccessEdgeVariant2;

        /// <summary>
        ///
        /// </summary>
        public SmsSuccessEdge(global::RetellAI.SmsSuccessEdgeVariant2? value)
        {
            SmsSuccessEdgeVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SmsSuccessEdge FromSmsSuccessEdgeVariant2(global::RetellAI.SmsSuccessEdgeVariant2? value) => new SmsSuccessEdge(value);

        /// <summary>
        ///
        /// </summary>
        public SmsSuccessEdge(
            global::RetellAI.NodeEdge? node,
            global::RetellAI.SmsSuccessEdgeVariant2? smsSuccessEdgeVariant2
            )
        {
            Node = node;
            SmsSuccessEdgeVariant2 = smsSuccessEdgeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SmsSuccessEdgeVariant2 as object ??
            Node as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Node?.ToString() ??
            SmsSuccessEdgeVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNode && IsSmsSuccessEdgeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.NodeEdge, TResult>? node = null,
            global::System.Func<global::RetellAI.SmsSuccessEdgeVariant2, TResult>? smsSuccessEdgeVariant2 = null,
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
            else if (SmsSuccessEdgeVariant2 is { } __value1 && smsSuccessEdgeVariant2 != null)
            {
                return smsSuccessEdgeVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.NodeEdge>? node = null,

            global::System.Action<global::RetellAI.SmsSuccessEdgeVariant2>? smsSuccessEdgeVariant2 = null,
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
            else if (SmsSuccessEdgeVariant2 is { } __value1)
            {
                smsSuccessEdgeVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.NodeEdge>? node = null,
            global::System.Action<global::RetellAI.SmsSuccessEdgeVariant2>? smsSuccessEdgeVariant2 = null,
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
            else if (SmsSuccessEdgeVariant2 is { } __value1)
            {
                smsSuccessEdgeVariant2?.Invoke(__value1);
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
                SmsSuccessEdgeVariant2,
                typeof(global::RetellAI.SmsSuccessEdgeVariant2),
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
        public bool Equals(SmsSuccessEdge other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeEdge?>.Default.Equals(Node, other.Node) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.SmsSuccessEdgeVariant2?>.Default.Equals(SmsSuccessEdgeVariant2, other.SmsSuccessEdgeVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SmsSuccessEdge obj1, SmsSuccessEdge obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SmsSuccessEdge>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SmsSuccessEdge obj1, SmsSuccessEdge obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SmsSuccessEdge o && Equals(o);
        }
    }
}
