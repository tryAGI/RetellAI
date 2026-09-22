#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace RetellAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct NodeTool : global::System.IEquatable<NodeTool>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.CustomTool? Custom { get; init; }
#else
        public global::RetellAI.CustomTool? Custom { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.CustomTool? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.CustomTool PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::RetellAI.NodeToolVariant2? NodeToolVariant2 { get; init; }
#else
        public global::RetellAI.NodeToolVariant2? NodeToolVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeToolVariant2))]
#endif
        public bool IsNodeToolVariant2 => NodeToolVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNodeToolVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::RetellAI.NodeToolVariant2? value)
        {
            value = NodeToolVariant2;
            return IsNodeToolVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::RetellAI.NodeToolVariant2 PickNodeToolVariant2() => IsNodeToolVariant2
            ? NodeToolVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'NodeToolVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator NodeTool(global::RetellAI.CustomTool value) => new NodeTool((global::RetellAI.CustomTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.CustomTool?(NodeTool @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public NodeTool(global::RetellAI.CustomTool? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NodeTool FromCustom(global::RetellAI.CustomTool? value) => new NodeTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NodeTool(global::RetellAI.NodeToolVariant2 value) => new NodeTool((global::RetellAI.NodeToolVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::RetellAI.NodeToolVariant2?(NodeTool @this) => @this.NodeToolVariant2;

        /// <summary>
        ///
        /// </summary>
        public NodeTool(global::RetellAI.NodeToolVariant2? value)
        {
            NodeToolVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NodeTool FromNodeToolVariant2(global::RetellAI.NodeToolVariant2? value) => new NodeTool(value);

        /// <summary>
        ///
        /// </summary>
        public NodeTool(
            global::RetellAI.CustomTool? custom,
            global::RetellAI.NodeToolVariant2? nodeToolVariant2
            )
        {
            Custom = custom;
            NodeToolVariant2 = nodeToolVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            NodeToolVariant2 as object ??
            Custom as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Custom?.ToString() ??
            NodeToolVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCustom && IsNodeToolVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::RetellAI.CustomTool?, TResult>? custom = null,
            global::System.Func<global::RetellAI.NodeToolVariant2, TResult>? nodeToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsNodeToolVariant2 && nodeToolVariant2 != null)
            {
                return nodeToolVariant2(NodeToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::RetellAI.CustomTool?>? custom = null,

            global::System.Action<global::RetellAI.NodeToolVariant2>? nodeToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsNodeToolVariant2)
            {
                nodeToolVariant2?.Invoke(NodeToolVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::RetellAI.CustomTool?>? custom = null,
            global::System.Action<global::RetellAI.NodeToolVariant2>? nodeToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsNodeToolVariant2)
            {
                nodeToolVariant2?.Invoke(NodeToolVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Custom,
                typeof(global::RetellAI.CustomTool),
                NodeToolVariant2,
                typeof(global::RetellAI.NodeToolVariant2),
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
        public bool Equals(NodeTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.CustomTool?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::RetellAI.NodeToolVariant2?>.Default.Equals(NodeToolVariant2, other.NodeToolVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(NodeTool obj1, NodeTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NodeTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(NodeTool obj1, NodeTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NodeTool o && Equals(o);
        }
    }
}
